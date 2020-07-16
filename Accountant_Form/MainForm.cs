using ClassLibrary;
using ClassLibrary.Serializer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accountant_Form
{
    public partial class MainForm : Form
    {
        #region Properties
        public List<Thread> threadList { get; set; }
        public YearlyBalance yearlyBal { get; set; }
        public bool firstRun { get; set; }
        #endregion

        public MainForm()
        {
            InitializeComponent();
            this.threadList = new List<Thread>();
            this.yearlyBal = new YearlyBalance();
        }

        #region Buttons
 
        private void btnNewBalances_Click(object sender, EventArgs e)
        {
            NewMonthForm addMonthForm = new NewMonthForm(this.yearlyBal);
            addMonthForm.ShowDialog();
            listBox1.DataSource = new List<Balance>();
            listBox1.DataSource = yearlyBal.Balances;
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            SavingsForm savingsForm = new SavingsForm(yearlyBal.Savings);
            savingsForm.ShowDialog();
            SetSavings();
        }

        private void btnResetYear_Click(object sender, EventArgs e)
        {
            if (!this.firstRun)
            {
                if (MessageBox.Show("WARNING! Creating a new year balance will erase the actual one.\nBut will create automatically a PDF file for you.", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.yearlyBal = new YearlyBalance();
                    ClearYear();
                    CreateYear();             
                }
            }
            else
            {
                CreateYear();
                this.firstRun = false;
            }
        }

        private void btnYearsDetails_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm(this.yearlyBal,Constants.Anual);
            detailsForm.ShowDialog();
        }

        private void btnMonthDetails_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm((Balance)this.listBox1.SelectedItem,Constants.MonthBalance);
            detailsForm.ShowDialog();
        }

        #endregion

        #region Private custom methods
        /// <summary>
        /// Sets the time in the menu.
        /// </summary>
        private void SetTime()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (this.InvokeRequired)
                {
                    this.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblTime.Text = DateTime.Now.ToString();
                    });
                }
                else
                    lblTime.Text = DateTime.Now.ToString();
            }
        }

        /// <summary>
        /// Kill all the threads.
        /// </summary>
        private void KillThreads()
        {
            foreach (Thread _thr in threadList)
            {
                if (_thr.IsAlive)
                    _thr.Abort();
            }
        }

        /// <summary>
        /// Sets all the information related to the yearly balance section.
        /// </summary>
        private void YearlyInformation()
        {

            lblYearly_year.Text = yearlyBal.Year.ToString();
            lblYearly_income.Text = "$ " + yearlyBal.TotalSaved.ToString();
            lblYearly_spent.Text = "$ " + yearlyBal.TotalSpent.ToString();
            yearly_result.ForeColor = (yearlyBal.Positive) ? Color.Green : Color.Red;
            yearly_result.Text = "$ " + String.Format("{0:0.00}", yearlyBal.Result);
        }

        /// <summary>
        /// Sets all the information related to the month balance section every time a new month on the listBox is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void MonthSelectedInformation(object sender, EventArgs args)
        {
            this.btnMonthDetails.Enabled = (this.listBox1.SelectedItem != null) ? true : false;
            this.contextMenuStrip1.Enabled = (this.listBox1.SelectedItem != null) ? true : false;
            Balance item = (Balance)this.listBox1.SelectedItem;
            try
            {
                foreach (Balance _bal in yearlyBal.Balances)
                {
                    if (_bal.Month == item.Month)
                    {
                        lblMonth_name.Text = _bal.Month.ToString();
                        lblMonth_Income.Text = "$ " + _bal.TotalIncomes.ToString();
                        lblMonth_spendings.Text = "$ " + _bal.TotalSpendings.ToString();
                        lblMonth_Result.ForeColor = (_bal.Result >= 0)?Color.Green:Color.Red;
                        lblMonth_Result.Text = "$ "+String.Format("{0:0.00}", _bal.Result);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el mes");
            }
        }

        private void SetSavings()
        {
            if(yearlyBal.Savings == null)
            {
                yearlyBal.Savings = new Saving();
            }

            dolarSavings.Text = "$ " + String.Format("{0:0.00}", yearlyBal.Savings.UsdSaving);
            pesosSavings.Text = "$ " + String.Format("{0:0.00}", yearlyBal.Savings.PesoSaving);

        }

        /// <summary>
        /// Sets the initial buttons validation and events.
        /// </summary>
        private void IndexFormSetUp()
        {
            this.listBox1.SelectedIndexChanged += MonthSelectedInformation;
            this.btnNewBalances.Enabled = false;
            this.btnMonthDetails.Enabled = false;
            this.btnYearsDetails.Enabled = false;
            this.firstRun = true;
        }

        /// <summary>
        /// Instanciate a new yearly balance and updates the section.
        /// </summary>
        private void CreateYear()
        {
            CreateYearForm createYearForm = new CreateYearForm(this.yearlyBal);
            createYearForm.ShowDialog();
            this.btnNewBalances.Enabled = true;
            this.listBox1.Enabled = true;
            this.btnYearsDetails.Enabled = true;
            YearlyInformation();
        }

        /// <summary>
        /// Cleans all the information on both sections.
        /// </summary>
        private void ClearYear()
        {
            lblYearly_year.ResetText();
            lblYearly_income.ResetText();
            lblYearly_spent.ResetText();

            lblMonth_name.ResetText();
            lblMonth_Income.ResetText();
            lblMonth_spendings.ResetText();
            lblMonth_Result.ResetText();

            this.listBox1.DataSource = null;

        }

        #endregion

        #region Load and Close
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IndexFormSetUp();
            try
            {
                if (Xml<YearlyBalance>.ReadBinary("accountantDB.bin", out YearlyBalance _data))
                {
                    this.btnNewBalances.Enabled = true;
                    this.listBox1.Enabled = true;
                    this.btnYearsDetails.Enabled = true;
                    this.firstRun = false;

                    yearlyBal = _data;
                    listBox1.DataSource = yearlyBal.Balances;
                    SetSavings();
                    YearlyInformation();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error ocurred while loading balance list.");
            }

            Thread threadTime = new Thread(SetTime);
            threadTime.Start();
            threadList.Add(threadTime);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Xml<YearlyBalance>.SaveBinaryXml("accountantDB.bin", this.yearlyBal);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar los cambios.");
            }

            KillThreads();
        }

        #endregion

        #region Menu lateral
        private void agregarIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                AddEntryForm addIncome = new AddEntryForm((Balance)this.listBox1.SelectedItem,Constants.Income);
                addIncome.ShowDialog();

                yearlyBal.Update();
                MonthSelectedInformation(null, null);
                YearlyInformation();
            }
        }

        private void agregarEgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                AddEntryForm addSpForm = new AddEntryForm((Balance)this.listBox1.SelectedItem,Constants.Spending);
                addSpForm.ShowDialog();

                yearlyBal.Update();
                MonthSelectedInformation(null, null);
                YearlyInformation();
            }
        }

        private void modificarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                Balance monthBalance = (Balance)this.listBox1.SelectedItem;
                UpdateBalance update = new UpdateBalance(monthBalance.Spendings, monthBalance.Month);
                update.ShowDialog();

                yearlyBal.Update();
                MonthSelectedInformation(null, null);
                YearlyInformation();
            }
        }

        private void modificarIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                Balance monthBalance = (Balance)this.listBox1.SelectedItem;
                UpdateBalance update = new UpdateBalance(monthBalance.Incomes, monthBalance.Month);
                update.ShowDialog();

                yearlyBal.Update();
                MonthSelectedInformation(null, null);
                YearlyInformation();
            }
        }

        private void eliminarMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem != null)
            {
                Balance item = (Balance)this.listBox1.SelectedItem;
                if (MessageBox.Show($"Seguro que desea eliminar el mes de {item.Month.ToString()}", "Eliminar Balance Mensual", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.yearlyBal -= item.Month;
                    listBox1.DataSource = new List<Balance>();
                    listBox1.DataSource = yearlyBal.Balances;
                    YearlyInformation();
                    MessageBox.Show("Listo!");
                }
            }
        }

        #endregion
        private void groupMonthBalance_Enter(object sender, EventArgs e)
        {

        }
    }
}
