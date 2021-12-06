using System.Collections;

namespace Module3HW1.Helper
{
    public class IntComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var itemX = (int)x;
            var itemY = (int)y;
            return itemX.CompareTo(itemY);
        }
    }
}
