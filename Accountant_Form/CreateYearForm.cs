using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accountant_Form
{
    public partial class CreateYearForm : Form
    {
        public YearlyBalance newYear { get; set; }

        public CreateYearForm(YearlyBalance _data)
        {
            InitializeComponent();
            this.newYear = _data;
        }

        private void btnAddYear_Click_1(object sender, EventArgs e)
        {
            this.newYear.Year = (int)this.numericYear.Value;
            MessageBox.Show("Listo!");
            this.Close();
        }
    }
}
