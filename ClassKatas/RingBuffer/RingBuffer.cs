using System;
using System.Collections.Generic;
using System.Text;

namespace RingBuffer
{
    class RingBuffer<T>
    {

        private int size;

        public RingBuffer(int size) {
            this.size = size;
        }

        public void Add(T value)
        {

        }

        public int Size()
        {
            return this.size;
        }




    }
}
