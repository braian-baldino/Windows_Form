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
    public partial class UpdateBalance : Form
    {
        public List<Spending> MonthSpendings { get; set; }
        public List<Income> MonthIncomes { get; set; }

        /// <summary>
        /// Expects Spendings or Incomes list and month.
        /// </summary>
        /// <param name="data"></param>
        public UpdateBalance(Object data, EMonth month)
        {
            InitializeComponent();
            lblSelectedMonth.Text = month.ToString();

            if (data is List<Spending>)
            {
                MonthSpendings = (List<Spending>)data;
                this.cmbType.DataSource = Enum.GetValues(typeof(ESpending));
                SetInitialSpendingCombo();
            }

            else if (data is List<Income>)
            {
                MonthIncomes = (List<Income>)data;
                this.cmbType.DataSource = Enum.GetValues(typeof(EIncome));
                SetInitialIncomeCombo();
            }

            item.SelectedValueChanged += ItemChange;

        }

        private void ItemChange(object sender, EventArgs e)
        {
            if (MonthSpendings != null)
            {
                foreach (Spending sp in MonthSpendings)
                {
                    if (item.SelectedItem == sp)
                    {
                        txtDescription.Text = sp.Description;
                        numericAmount.Value = (decimal)sp.Amount;
                        cmbType.SelectedItem = sp.Type;
                        dateTimePicker.Value = sp.Date;
                    }
                }
            }
            else if (MonthIncomes != null)
            {
                foreach (Income inc in MonthIncomes)
                {
                    if (item.SelectedItem == inc)
                    {
                        txtDescription.Text = inc.Description;
                        numericAmount.Value = (decimal)inc.Amount;
                        cmbType.SelectedItem = inc.Type;
                        dateTimePicker.Value = inc.Date;
                    }
                }
            }

        }

        private void SetInitialSpendingCombo()
        {
            item.DataSource = MonthSpendings;
            Spending sp = (Spending)item.SelectedItem;
            if (sp != null)
            {
                txtDescription.Text = sp.Description;
                numericAmount.Value = (decimal)sp.Amount;
                cmbType.SelectedItem = sp.Type;
                dateTimePicker.Value = sp.Date;
            }
            else
            {
                MessageBox.Show("No hay gastos para modificar");
                btnAccept.Enabled = false;
                txtDescription.Enabled = false;
                numericAmount.Enabled = false;
                cmbType.Enabled = false;
                dateTimePicker.Enabled = false;
            }

        }

        private void SetInitialIncomeCombo()
        {
            item.DataSource = MonthIncomes;
            Income inc = (Income)item.SelectedItem;
            if (inc != null)
            {
                txtDescription.Text = inc.Description;
                numericAmount.Value = (decimal)inc.Amount;
                cmbType.SelectedItem = inc.Type;
                dateTimePicker.Value = inc.Date;
            }
            else
            {
                MessageBox.Show("No hay entradas para modificar");
                btnAccept.Enabled = false;
                txtDescription.Enabled = false;
                numericAmount.Enabled = false;
                cmbType.Enabled = false;
                dateTimePicker.Enabled = false;
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Esta seguro que desea Guardar los cambios?", "Guardar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MonthSpendings != null)
                {
                    foreach (Spending sp in MonthSpendings)
                    {
                        if (sp == (Spending)item.SelectedItem)
                        {
                            sp.Description = txtDescription.Text;
                            sp.Amount = (double)numericAmount.Value;
                            sp.Type = (ESpending)cmbType.SelectedItem;
                            sp.Date = dateTimePicker.Value;
                            break;
                        }
                    }
                }
                else if (MonthIncomes != null)
                {
                    foreach (Income inc in MonthIncomes)
                    {
                        if (inc == (Income)item.SelectedItem)
                        {
                            inc.Description = txtDescription.Text;
                            inc.Amount = (double)numericAmount.Value;
                            inc.Type = (EIncome)cmbType.SelectedItem;
                            inc.Date = dateTimePicker.Value;
                            break;
                        }
                    }
                }


                this.Close();
            }
        }
    }
}
