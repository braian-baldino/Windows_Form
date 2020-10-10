using ClassLibrary;
using ClassLibrary.Helpers;
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
        public List<Thread> ThreadList { get; set; }
        public YearlyBalance AnualBalance { get; set; }
        public bool FirstRun { get; set; }
        #endregion

        public MainForm()
        {
            InitializeComponent();
            ThreadList = new List<Thread>();
            AnualBalance = new YearlyBalance();
        }

        #region Buttons
 
        private void btnNewBalances_Click(object sender, EventArgs e)
        {
            NewMonthForm addMonthForm = new NewMonthForm(AnualBalance);
            addMonthForm.ShowDialog();
            listBox1.DataSource = new List<Balance>();
            listBox1.DataSource = AnualBalance.Balances;
        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            SavingsForm savingsForm = new SavingsForm(AnualBalance.Savings);
            savingsForm.ShowDialog();
            SetSavings();
        }

        private void btnResetYear_Click(object sender, EventArgs e)
        {
            if (!this.FirstRun)
            {
                if (MessageBox.Show("WARNING! Creating a new year balance will erase the actual one.\nBut will create automatically a PDF file for you.", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.AnualBalance = new YearlyBalance();
                    ClearYear();
                    CreateYear();             
                }
            }
            else
            {
                CreateYear();
                this.FirstRun = false;
            }
        }

        private void btnYearsDetails_Click(object sender, EventArgs e)
        {
            var fileName = $"Balance_Anual_{AnualBalance.Year}.pdf";
            PdfHelper.CreateAnualPdf(fileName,AnualBalance);
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
            foreach (Thread _thr in ThreadList)
            {
                if (_thr.IsAlive)
                    _thr.Abort();
            }
        }

        private void UpdateInformation()
        {
            AnualBalance.Update();
            UpdateMonthSelectedInformation();
            UpdateAnualBalanceInformation();
        }

        /// <summary>
        /// Sets all the information related to the yearly balance section.
        /// </summary>
        private void UpdateAnualBalanceInformation()
        {
            lblYearly_year.Text = AnualBalance.Year.ToString();
            lblYearly_income.Text = "$ " + AnualBalance.TotalSaved.ToString();
            lblYearly_spent.Text = "$ " + AnualBalance.TotalSpent.ToString();
            yearly_result.ForeColor = AnualBalance.Positive ? Color.Green : Color.Red;
            yearly_result.Text = "$ " + String.Format("{0:0.00}", AnualBalance.Result);
        }

        private void UpdateMonthSelectedInformation()
        {
            btnMonthDetails.Enabled = listBox1.SelectedItem != null;
            contextMenuStrip1.Enabled = listBox1.SelectedItem != null;
            Balance item = (Balance)listBox1.SelectedItem;

            try
            {
                foreach (Balance _bal in AnualBalance.Balances)
                {
                    if (_bal.Month == item.Month)
                    {
                        lblMonth_name.Text = _bal.Month.ToString();
                        lblMonth_Income.Text = "$ " + _bal.TotalIncomes.ToString();
                        lblMonth_spendings.Text = "$ " + _bal.TotalSpendings.ToString();
                        lblMonth_Result.ForeColor = (_bal.Result >= 0) ? Color.Green : Color.Red;
                        lblMonth_Result.Text = "$ " + String.Format("{0:0.00}", _bal.Result);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el mes");
            }
        }

        /// <summary>
        /// Sets all the information related to the month balance section every time a new month on the listBox is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void MonthSelectedInformationEvent(object sender, EventArgs args)
        {
            UpdateMonthSelectedInformation();
        }

        private void SetSavings()
        {
            if(AnualBalance.Savings == null)
            {
                AnualBalance.Savings = new Saving();
            }

            dolarSavings.Text = "$ " + String.Format("{0:0.00}", AnualBalance.Savings.UsdSaving);
            pesosSavings.Text = "$ " + String.Format("{0:0.00}", AnualBalance.Savings.PesoSaving);

        }

        /// <summary>
        /// Sets the initial buttons validation and events.
        /// </summary>
        private void IndexFormSetUp()
        {
            listBox1.SelectedIndexChanged += MonthSelectedInformationEvent;
            btnNewBalances.Enabled = false;
            btnMonthDetails.Enabled = false;
            btnYearsDetails.Enabled = false;
            FirstRun = true;
        }

        /// <summary>
        /// Instanciate a new yearly balance and updates the section.
        /// </summary>
        private void CreateYear()
        {
            CreateYearForm createYearForm = new CreateYearForm(AnualBalance);
            createYearForm.ShowDialog();
            btnNewBalances.Enabled = true;
            listBox1.Enabled = true;
            btnYearsDetails.Enabled = true;
            UpdateAnualBalanceInformation();
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

            listBox1.DataSource = null;
        }

        #endregion

        #region Load and Close
        private void MainForm_Load(object sender, EventArgs e)
        {
            IndexFormSetUp();

            try
            {
                if (Xml<YearlyBalance>.ReadBinary("accountantDB.bin", out YearlyBalance _data))
                {
                    btnNewBalances.Enabled = true;
                    listBox1.Enabled = true;
                    btnYearsDetails.Enabled = true;
                    FirstRun = false;

                    AnualBalance = _data;
                    listBox1.DataSource = AnualBalance.Balances;
                    SetSavings();
                    UpdateAnualBalanceInformation();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar accountantDB.bin");
            }

            Thread threadTime = new Thread(SetTime);
            threadTime.Start();
            ThreadList.Add(threadTime);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Xml<YearlyBalance>.SaveBinaryXml("accountantDB.bin", AnualBalance);
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
            if (listBox1.SelectedItem != null)
            {
                AddEntryForm addIncome = new AddEntryForm((Balance)listBox1.SelectedItem, Constants.Income);
                addIncome.ShowDialog();

                UpdateInformation();
            }
        }

        private void agregarEgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                AddEntryForm addSpForm = new AddEntryForm((Balance)listBox1.SelectedItem,Constants.Spending);
                addSpForm.ShowDialog();

                UpdateInformation();
            }
        }

        private void modificarEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Balance monthBalance = (Balance)listBox1.SelectedItem;
                UpdateBalance update = new UpdateBalance(monthBalance.Spendings, monthBalance.Month);
                update.ShowDialog();

                UpdateInformation();
            }
        }

        private void modificarIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Balance monthBalance = (Balance)listBox1.SelectedItem;
                UpdateBalance update = new UpdateBalance(monthBalance.Incomes, monthBalance.Month);
                update.ShowDialog();

                UpdateInformation();
            }
        }

        private void eliminarMesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Balance item = (Balance)listBox1.SelectedItem;
                if (MessageBox.Show($"Seguro que desea eliminar el mes de {item.Month}", "Eliminar Balance Mensual", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AnualBalance -= item.Month;
                    listBox1.DataSource = new List<Balance>();
                    listBox1.DataSource = AnualBalance.Balances;
                    UpdateAnualBalanceInformation();
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
