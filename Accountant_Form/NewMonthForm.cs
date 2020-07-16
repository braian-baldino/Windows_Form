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
    public partial class NewMonthForm : Form
    {
        public YearlyBalance yearlyB { get; set; }
        public NewMonthForm(YearlyBalance formYearlyBalance)
        {
            InitializeComponent();
            yearlyB = formYearlyBalance;
        }

        private void NewMonthForm_Load(object sender, EventArgs e)
        {
            this.MonthDropDown.DataSource = Enum.GetValues(typeof(EMonth));
        }


        private void btnAddMonth_Click_1(object sender, EventArgs e)
        {
            try
            {
                Balance newBalance = new Balance((EMonth)this.MonthDropDown.SelectedItem);
                yearlyB += newBalance;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
