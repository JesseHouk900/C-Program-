using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanAnalyzer
{
    public partial class HubForm : Form
    {
        public HubForm()
        {
            InitializeComponent();
        }

        public HubForm(Point[] gridSizes) {
            InitializeComponent();

        }

        private void FingerPrintButton_Click(object sender, EventArgs e)
        {
            int d = ReadDataForm.gridSizes[0].Row;
            SwitchForm();
        }

        private void SwitchForm()
        {
            FindSampleGame sample = new FindSampleGame();
            sample.Show();
            this.Hide();
        }
    }
}
