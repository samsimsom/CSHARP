namespace Sorting
{
    public class Exchage
    {
        // Exchange between two integers.
        /*
        int first, second;
        int temp;
        first = 25;
        second = 35;
        temp = first;
        first = second;
        second = temp;
        */
        public void ExchageInt(int[] data, int first, int second)
        {
            int temp;
            temp = data[first];
            data[first] = data[second];
            data[second] = temp;
        }
    }

}