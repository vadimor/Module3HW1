using Module3HW1.Collection;
using Module3HW1.Helper;

namespace Module3HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int>();
            var array = new int[] { 3, 2, 1 };
            list.AddRange(array);
            list.Remove(1);
            var comparer = new IntComparer();
            list.Sort(comparer);
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
