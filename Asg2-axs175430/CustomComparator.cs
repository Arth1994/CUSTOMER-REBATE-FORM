using System.Collections;
using System.Windows.Forms;

namespace Asg2_axs175430
{
    //Custom ListView Sorter - according to the columns-Implements IComparable Interface
    internal class CustomComparator : IComparer
    {

        //column to be sorted
        private int colSort;
        //ascending or descending of sorting specified
        private SortOrder sortingOrder;
        //Ignores Case Comparer
        private CaseInsensitiveComparer flexibleComparer;

        //selects column to apply sorting
        public int SortColumn
        {
            set
            {
                colSort = value;
            }
            get
            {
                return colSort;
            }
        }

        //selects sorting order to apply
        public SortOrder Order
        {
            set { sortingOrder = value; }
            get { return sortingOrder; }
        }

        //Empty Constructor/Default Constrcutor
        public CustomComparator()
        {

            //Initial Sort Order to None
            sortingOrder = SortOrder.None;

            //Column Index starting from 0
            colSort = 0;

            //Initialize CaseInsensitive Comparer Object
            flexibleComparer = new CaseInsensitiveComparer();
        }

        int IComparer.Compare(object x, object y)
        {

            int result;

            ListViewItem a, b;
            //TypeCast Object x and y to the ListViewItems a & b
            a = (ListViewItem)x;
            b = (ListViewItem)y;
            result = flexibleComparer.Compare(a.SubItems[colSort].Text, b.SubItems[colSort].Text);
            //throw new System.NotImplementedException();
            if (sortingOrder == SortOrder.Ascending)
            {
                //Ascending Sort
                return result;
            }
            else if (sortingOrder == SortOrder.Descending)
            {
                //Descending Sort Selected
                return (-1) * (result);
            }
            else
            {
                //Equality Condition
                return 0;
            }
        }

    }

}