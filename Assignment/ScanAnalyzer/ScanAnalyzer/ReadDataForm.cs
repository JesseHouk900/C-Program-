using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ScanAnalyzer
{
    public partial class ReadDataForm : Form
    {
        string fileName;
        static Point [] gridSizes;
        public ReadDataForm()
        {
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            fileName = FileNameTextBox.Text;
            ReadFile();
            
            SwitchForm();
        }
        //Example of code to read a file
        private void ReadFile()
        {
            //create reference to stream
            StreamReader textIn;
            //open stream to file - by the way things could go wrong here
            textIn = new StreamReader(new FileStream(this.fileName, FileMode.Open,
                       FileAccess.Read));
            string[] fItem = new string[2];
            gridSizes = new Point[3];
            // get rows and columns from data file
            for (int i = 0; i < 3; i++)
            {
                fItem[0] = textIn.ReadLine();
                fItem = fItem[0].Split(' ');
                gridSizes[i] = new Point(Int32.Parse(fItem[0]), Int32.Parse(fItem[1]));
            }
            //} while (textIn.Peek() != -1);
            textIn.Close();
        }

        private void SwitchForm()
        {
            HubForm hub = new HubForm();
            hub.Show();
            this.Hide();
        }
    }
}
