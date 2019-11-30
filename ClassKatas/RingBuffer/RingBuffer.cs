using System;
using System.Collections.Generic;
using System.Text;

namespace RingBuffer
{
    class RingBuffer<T>
    {
        private int size;
        private int currentPosition = 0;

        private List<T> ringBufferValues = new List<T>();

        public RingBuffer(int size) {
            this.size = size;
        }

        public void Add(T value)
        {
            if(Count() < size)
            {
                ringBufferValues.Add(value);
            }
        }

        public int Size()
        {
            return this.size;
        }

        public int Count()
        {
            return ringBufferValues.Count;
        }



    }
}
