using System;
using System.Collections;
using System.Windows.Forms;

namespace NoSQLProject
{
    //Emre Kutuk individual extra assignment
    // Implements the manual sorting of items by columns.
    public class ListViewItemComparer : IComparer
    {
        private int col;
        bool clicked;

        public ListViewItemComparer(int column, bool clicked)
        {
            col = column;
            this.clicked = clicked;
        }

        public int Compare(object x, object y)
        {
            if (clicked)
                return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            else
                return String.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);
        }
    }
}
