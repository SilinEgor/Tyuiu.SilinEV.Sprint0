namespace Tyuiu.SilinEV.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionalArray(int[] num)
        {
            var total = 0;
            for (int i = 0; i < num.Length; i++)
            {
                total += num[i];
            }
            return total;
        }

        public static object SubtractionArray(int[] num)
        {
            var total = 0;
            int index = 0;
            while (index < num.Length)
            {
                total -= num[index];
                index++;
            }
            return total;
        }

        public static object MultiplicationArray(int[] num)
        {
            var total = 1;
            int index = 0;
            do
            {
                total *= num[index];
            }
            while (index < num.Length);
            return total;
        }

    }
}
