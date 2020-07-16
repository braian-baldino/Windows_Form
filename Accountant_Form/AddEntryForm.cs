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
    public partial class AddEntryForm : Form
    {
        public Balance balance { get; set; }
        public string type { get; set; }

        public AddEntryForm(Balance data,string type)
        {
            InitializeComponent();
            this.cmbType.DataSource = (type == Constants.Income)?Enum.GetValues(typeof(EIncome)):Enum.GetValues(typeof(ESpending));
            this.balance = data;
            this.type = type;
            this.lblSelectedMonth.Text = this.balance.Month.ToString();
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtDescription.Text) && this.cmbType.SelectedItem != null)
            {
                if (type == Constants.Income)
                {
                    try
                    {
                        Income income = new Income((double)numericAmount.Value, txtDescription.Text, (EIncome)cmbType.SelectedItem, dateTimePicker.Value);
                        this.balance += income;
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al agregar Entrada");
                    }
                }
                else if (type == Constants.Spending)
                {
                    try
                    {
                        Spending spending = new Spending((double)numericAmount.Value, txtDescription.Text, (ESpending)cmbType.SelectedItem, dateTimePicker.Value);
                        this.balance += spending;
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al agregar Egreso");
                    }
                }

            }
            else
                MessageBox.Show("One or more fields are not valid. Check selected type and empty descriptions are not allowed.");
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

