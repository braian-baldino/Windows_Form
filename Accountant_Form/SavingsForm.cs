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
    public partial class SavingsForm : Form
    {
        public Saving Savings { get; set; }
        public SavingsForm(Saving data)
        {
            InitializeComponent();
            Savings = data;
            numericUSD.Value = (decimal)data.UsdSaving;
            numericPesos.Value = (decimal)data.PesoSaving;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Savings.UsdSaving = (double)numericUSD.Value;
            Savings.PesoSaving = (double)numericPesos.Value;
            MessageBox.Show("Listo!");
            this.Close();
        }
    }
}
