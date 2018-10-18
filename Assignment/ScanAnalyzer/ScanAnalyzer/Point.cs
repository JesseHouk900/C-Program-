using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ScanAnalyzer
{
    // Point contains a row and column
    public class Point : PictureBox
    {
        // private data member specifying the row where the point lies
        private int row;
        // private data member specifying the column where the point lies
        private int column;
        //
        private string imageName;
        // public property that accesses and sets row
        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }
        // public property that accesses and sets column
        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }
        public string ImageName
        {
            get
            {
                return imageName;
            }
            // NEEDS ERROR CHECKING
            set
            {
                imageName = value;
            }
        }
        // parameterized constructor taking in a desired row and column
        public Point(int r, int c, string image) : base()
        {
            row = r;
            column = c;
            imageName = image;
        }

    }
}