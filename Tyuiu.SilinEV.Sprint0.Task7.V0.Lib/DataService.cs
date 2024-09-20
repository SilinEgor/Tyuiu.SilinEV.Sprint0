using System.Runtime.Serialization.Formatters;

namespace Tyuiu.SilinEV.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] a, int[] b)
        {
            int[] q = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                q[i] = a[i] + b[i];
            }
            return q;
        }
    }
}
