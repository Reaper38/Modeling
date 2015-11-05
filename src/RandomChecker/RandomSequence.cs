using System;
using System.Collections.Generic;
using System.IO;

namespace RandomChecker
{
    internal delegate int IntRngFunc(int sbCount);

    internal class RandomSequence
    {
        public IList<int> Data { get { return data; } }
        public byte SignificantBits { get; set; }
        private readonly List<int> data;

        public int this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }
        
        public void SetLength(int length)
        {
            var currentLength = data.Count;
            if (currentLength<length)
            {
                EnsureCapacity(length);
                for (int i = 0; i<length-currentLength; i++)
                    data.Add(0);
            }
            else if (data.Count>length)
                data.RemoveRange(length, currentLength-length);
        }

        public void EnsureCapacity(int capacity)
        {
            if (data.Capacity<capacity)
                data.Capacity = capacity;
        }

        public void EnsureLength(int length)
        {
            if (data.Count<length)
                SetLength(length);
        }

        private RandomSequence(int length, byte sbCount)
        {
            data = new List<int>(length);
            SignificantBits = sbCount;
        }

        public static RandomSequence Load(string filePath, byte sbCount)
        {
            var splitChars = new[] {'\t', '\r', '\n'};
            string text = File.ReadAllText(filePath);
            string[] splitText = text.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            var seq = new RandomSequence(splitText.Length, sbCount);
            for (int i = 0; i<splitText.Length; i++)
                seq.data.Add(int.Parse(splitText[i]));
            return seq;
        }

        public static RandomSequence Generate(int length, byte sbCount, IntRngFunc rng)
        {
            var seq = new RandomSequence(length, sbCount);
            for (int i = 0; i<length; i++)
                seq.data.Add(rng(sbCount));
            return seq;
        }

        public static RandomSequence CreateEmpty(byte sbCount)
        { return new RandomSequence(0, sbCount); }
    }
}
