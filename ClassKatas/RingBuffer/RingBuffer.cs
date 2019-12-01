using System;
using System.Collections.Generic;
using System.Text;

namespace RingBuffer
{
    class RingBuffer<T>
    {
        private int size;
        private int currentPosition = -1;

        private List<T> ringBufferValues = new List<T>();

        public RingBuffer(int size) {
            this.size = size;
        }

        public void Add(T value)
        {            
            UpdateCurrentPosition();

            if (Count() < size)
            {
                ringBufferValues.Add(value);
            }
            else
            {
                ringBufferValues.Insert(currentPosition, value);
                ringBufferValues.RemoveAt(size);
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


        #region HelperMethods

        private void UpdateCurrentPosition()
        {
            if (currentPosition == size - 1)
            {
                currentPosition = 0;
            } 
            else
            {
                currentPosition++;
            }
        }

        #endregion

    }
}
