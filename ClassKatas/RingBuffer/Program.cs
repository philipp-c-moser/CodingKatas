using System;

namespace RingBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RingBuffer - Class Kata");

            var ringBuffer = new RingBuffer<string>(4);

            ringBuffer.Add("A1");
            ringBuffer.Add("A2");
            ringBuffer.Add("A3");
            ringBuffer.Add("A4");
            // Value: A1; A2; A3; A4

            ringBuffer.Add("B1");
            ringBuffer.Add("B2");
            // Value: B1; B2; A3; A4




        }
    }
}