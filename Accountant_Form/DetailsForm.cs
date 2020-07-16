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
    public partial class DetailsForm : Form
    {
        public YearlyBalance Year { get; set; }
        public Balance Balance { get; set; }

        public DetailsForm(Object data,string type)
        {
            InitializeComponent();

            if(type == Constants.Anual)
            {
                Year = (YearlyBalance)data;
                this.richTBShow.Text = Year.ShowYearlyBalance();
            }

            else if(type == Constants.MonthBalance)
            {
                Balance = (Balance)data;
                this.richTBShow.Text = Balance.ShowBalanceDetails();
            }

        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            if (Year != null)
                this.richTBShow.Text = Year.ShowYearlyBalance();
            if (Balance != null)
                this.richTBShow.Text = Balance.ShowBalanceDetails();
        }

    }
}
