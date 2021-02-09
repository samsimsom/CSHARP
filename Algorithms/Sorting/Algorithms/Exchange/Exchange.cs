using System;

namespace Exchange
{
    public class Exchage
    {
        public void ExchageValues(int[] data, int first, int second)
        {
            int temp;

            temp = data[first];
            data[first] = data[second];
            data[second] = temp;
        }
    }
}