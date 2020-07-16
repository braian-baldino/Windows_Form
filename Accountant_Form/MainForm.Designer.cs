namespace Accountant_Form
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSavings = new System.Windows.Forms.Button();
            this.pesosSavings = new System.Windows.Forms.Label();
            this.dolarSavings = new System.Windows.Forms.Label();
            this.lblPesosSavings = new System.Windows.Forms.Label();
            this.lblDolarSavings = new System.Windows.Forms.Label();
            this.btnNewBalances = new System.Windows.Forms.Button();
            this.btnResetYear = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMonthDetails = new System.Windows.Forms.Button();
            this.btnYearsDetails = new System.Windows.Forms.Button();
            this.groupMonthBalance = new System.Windows.Forms.GroupBox();
            this.lblMonth_Result = new System.Windows.Forms.Label();
            this.lblMonth_Income = new System.Windows.Forms.Label();
            this.lblMonth_spendings = new System.Windows.Forms.Label();
            this.lblMonth_name = new System.Windows.Forms.Label();
            this.lbl_monthly_result = new System.Windows.Forms.Label();
            this.lbl_monthly_income = new System.Windows.Forms.Label();
            this.lbl_monthly_spending = new System.Windows.Forms.Label();
            this.lbl_monthly_month = new System.Windows.Forms.Label();
            this.groupYearBalance = new System.Windows.Forms.GroupBox();
            this.yearly_result = new System.Windows.Forms.Label();
            this.lblYearly_spent = new System.Windows.Forms.Label();
            this.lblYearly_income = new System.Windows.Forms.Label();
            this.lblYearly_year = new System.Windows.Forms.Label();
            this.lbl_year_result = new System.Windows.Forms.Label();
            this.lbl_year_spending = new System.Windows.Forms.Label();
            this.lbl_year_income = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarIngresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEgresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEgresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupMonthBalance.SuspendLayout();
            this.groupYearBalance.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(85)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.btnSavings);
            this.panel1.Controls.Add(this.pesosSavings);
            this.panel1.Controls.Add(this.dolarSavings);
            this.panel1.Controls.Add(this.lblPesosSavings);
            this.panel1.Controls.Add(this.lblDolarSavings);
            this.panel1.Controls.Add(this.btnNewBalances);
            this.panel1.Controls.Add(this.btnResetYear);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 94);
            this.panel1.TabIndex = 0;
            // 
            // btnSavings
            // 
            this.btnSavings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(191)))));
            this.btnSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavings.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSavings.Location = new System.Drawing.Point(631, 12);
            this.btnSavings.Name = "btnSavings";
            this.btnSavings.Size = new System.Drawing.Size(94, 58);
            this.btnSavings.TabIndex = 7;
            this.btnSavings.Text = "Ahorros";
            this.btnSavings.UseVisualStyleBackColor = false;
            this.btnSavings.Click += new System.EventHandler(this.btnSavings_Click);
            // 
            // pesosSavings
            // 
            this.pesosSavings.AutoSize = true;
            this.pesosSavings.BackColor = System.Drawing.Color.Transparent;
            this.pesosSavings.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesosSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pesosSavings.Location = new System.Drawing.Point(908, 49);
            this.pesosSavings.Name = "pesosSavings";
            this.pesosSavings.Size = new System.Drawing.Size(18, 19);
            this.pesosSavings.TabIndex = 6;
            this.pesosSavings.Text = "$";
            // 
            // dolarSavings
            // 
            this.dolarSavings.AutoSize = true;
            this.dolarSavings.BackColor = System.Drawing.Color.Transparent;
            this.dolarSavings.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolarSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dolarSavings.Location = new System.Drawing.Point(908, 19);
            this.dolarSavings.Name = "dolarSavings";
            this.dolarSavings.Size = new System.Drawing.Size(18, 19);
            this.dolarSavings.TabIndex = 5;
            this.dolarSavings.Text = "$";
            // 
            // lblPesosSavings
            // 
            this.lblPesosSavings.AutoSize = true;
            this.lblPesosSavings.BackColor = System.Drawing.Color.Transparent;
            this.lblPesosSavings.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesosSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblPesosSavings.Location = new System.Drawing.Point(794, 49);
            this.lblPesosSavings.Name = "lblPesosSavings";
            this.lblPesosSavings.Size = new System.Drawing.Size(82, 19);
            this.lblPesosSavings.TabIndex = 4;
            this.lblPesosSavings.Text = "$ Ahorros:";
            // 
            // lblDolarSavings
            // 
            this.lblDolarSavings.AutoSize = true;
            this.lblDolarSavings.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarSavings.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarSavings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDolarSavings.Location = new System.Drawing.Point(794, 19);
            this.lblDolarSavings.Name = "lblDolarSavings";
            this.lblDolarSavings.Size = new System.Drawing.Size(108, 19);
            this.lblDolarSavings.TabIndex = 3;
            this.lblDolarSavings.Text = "USD Ahorros:";
            // 
            // btnNewBalances
            // 
            this.btnNewBalances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(191)))));
            this.btnNewBalances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBalances.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnNewBalances.Location = new System.Drawing.Point(463, 12);
            this.btnNewBalances.Name = "btnNewBalances";
            this.btnNewBalances.Size = new System.Drawing.Size(144, 58);
            this.btnNewBalances.TabIndex = 2;
            this.btnNewBalances.Text = "Balance Mensual";
            this.btnNewBalances.UseVisualStyleBackColor = false;
            this.btnNewBalances.Click += new System.EventHandler(this.btnNewBalances_Click);
            // 
            // btnResetYear
            // 
            this.btnResetYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(148)))), ((int)(((byte)(191)))));
            this.btnResetYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetYear.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnResetYear.Location = new System.Drawing.Point(316, 12);
            this.btnResetYear.Name = "btnResetYear";
            this.btnResetYear.Size = new System.Drawing.Size(126, 58);
            this.btnResetYear.TabIndex = 1;
            this.btnResetYear.Text = "Balance Anual";
            this.btnResetYear.UseVisualStyleBackColor = false;
            this.btnResetYear.Click += new System.EventHandler(this.btnResetYear_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTime.Location = new System.Drawing.Point(37, 31);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "time";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.btnMonthDetails);
            this.panel2.Controls.Add(this.btnYearsDetails);
            this.panel2.Controls.Add(this.groupMonthBalance);
            this.panel2.Controls.Add(this.groupYearBalance);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 661);
            this.panel2.TabIndex = 1;
            // 
            // btnMonthDetails
            // 
            this.btnMonthDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(149)))), ((int)(((byte)(94)))));
            this.btnMonthDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthDetails.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMonthDetails.Location = new System.Drawing.Point(1008, 284);
            this.btnMonthDetails.Name = "btnMonthDetails";
            this.btnMonthDetails.Size = new System.Drawing.Size(74, 43);
            this.btnMonthDetails.TabIndex = 4;
            this.btnMonthDetails.Text = "Detalle";
            this.btnMonthDetails.UseVisualStyleBackColor = false;
            this.btnMonthDetails.Click += new System.EventHandler(this.btnMonthDetails_Click);
            // 
            // btnYearsDetails
            // 
            this.btnYearsDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(149)))), ((int)(((byte)(94)))));
            this.btnYearsDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearsDetails.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearsDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnYearsDetails.Location = new System.Drawing.Point(1008, 116);
            this.btnYearsDetails.Name = "btnYearsDetails";
            this.btnYearsDetails.Size = new System.Drawing.Size(74, 43);
            this.btnYearsDetails.TabIndex = 3;
            this.btnYearsDetails.Text = "Detalle";
            this.btnYearsDetails.UseVisualStyleBackColor = false;
            this.btnYearsDetails.Click += new System.EventHandler(this.btnYearsDetails_Click);
            // 
            // groupMonthBalance
            // 
            this.groupMonthBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupMonthBalance.Controls.Add(this.lblMonth_Result);
            this.groupMonthBalance.Controls.Add(this.lblMonth_Income);
            this.groupMonthBalance.Controls.Add(this.lblMonth_spendings);
            this.groupMonthBalance.Controls.Add(this.lblMonth_name);
            this.groupMonthBalance.Controls.Add(this.lbl_monthly_result);
            this.groupMonthBalance.Controls.Add(this.lbl_monthly_income);
            this.groupMonthBalance.Controls.Add(this.lbl_monthly_spending);
            this.groupMonthBalance.Controls.Add(this.lbl_monthly_month);
            this.groupMonthBalance.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMonthBalance.Location = new System.Drawing.Point(212, 228);
            this.groupMonthBalance.Name = "groupMonthBalance";
            this.groupMonthBalance.Padding = new System.Windows.Forms.Padding(8);
            this.groupMonthBalance.Size = new System.Drawing.Size(766, 165);
            this.groupMonthBalance.TabIndex = 2;
            this.groupMonthBalance.TabStop = false;
            this.groupMonthBalance.Text = "Mensual";
            this.groupMonthBalance.Enter += new System.EventHandler(this.groupMonthBalance_Enter);
            // 
            // lblMonth_Result
            // 
            this.lblMonth_Result.AutoSize = true;
            this.lblMonth_Result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth_Result.Location = new System.Drawing.Point(530, 104);
            this.lblMonth_Result.Name = "lblMonth_Result";
            this.lblMonth_Result.Size = new System.Drawing.Size(0, 18);
            this.lblMonth_Result.TabIndex = 11;
            // 
            // lblMonth_Income
            // 
            this.lblMonth_Income.AutoSize = true;
            this.lblMonth_Income.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth_Income.Location = new System.Drawing.Point(132, 104);
            this.lblMonth_Income.Name = "lblMonth_Income";
            this.lblMonth_Income.Size = new System.Drawing.Size(0, 18);
            this.lblMonth_Income.TabIndex = 9;
            // 
            // lblMonth_spendings
            // 
            this.lblMonth_spendings.AutoSize = true;
            this.lblMonth_spendings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth_spendings.Location = new System.Drawing.Point(324, 104);
            this.lblMonth_spendings.Name = "lblMonth_spendings";
            this.lblMonth_spendings.Size = new System.Drawing.Size(0, 18);
            this.lblMonth_spendings.TabIndex = 10;
            // 
            // lblMonth_name
            // 
            this.lblMonth_name.AutoSize = true;
            this.lblMonth_name.Location = new System.Drawing.Point(27, 104);
            this.lblMonth_name.Name = "lblMonth_name";
            this.lblMonth_name.Size = new System.Drawing.Size(0, 19);
            this.lblMonth_name.TabIndex = 8;
            // 
            // lbl_monthly_result
            // 
            this.lbl_monthly_result.AutoSize = true;
            this.lbl_monthly_result.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthly_result.Location = new System.Drawing.Point(530, 61);
            this.lbl_monthly_result.Name = "lbl_monthly_result";
            this.lbl_monthly_result.Size = new System.Drawing.Size(74, 16);
            this.lbl_monthly_result.TabIndex = 7;
            this.lbl_monthly_result.Text = "Balance";
            // 
            // lbl_monthly_income
            // 
            this.lbl_monthly_income.AutoSize = true;
            this.lbl_monthly_income.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthly_income.Location = new System.Drawing.Point(132, 61);
            this.lbl_monthly_income.Name = "lbl_monthly_income";
            this.lbl_monthly_income.Size = new System.Drawing.Size(112, 16);
            this.lbl_monthly_income.TabIndex = 5;
            this.lbl_monthly_income.Text = "Entrada Total";
            // 
            // lbl_monthly_spending
            // 
            this.lbl_monthly_spending.AutoSize = true;
            this.lbl_monthly_spending.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthly_spending.Location = new System.Drawing.Point(324, 61);
            this.lbl_monthly_spending.Name = "lbl_monthly_spending";
            this.lbl_monthly_spending.Size = new System.Drawing.Size(108, 16);
            this.lbl_monthly_spending.TabIndex = 6;
            this.lbl_monthly_spending.Text = "Egreso Total";
            // 
            // lbl_monthly_month
            // 
            this.lbl_monthly_month.AutoSize = true;
            this.lbl_monthly_month.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthly_month.Location = new System.Drawing.Point(27, 61);
            this.lbl_monthly_month.Name = "lbl_monthly_month";
            this.lbl_monthly_month.Size = new System.Drawing.Size(41, 16);
            this.lbl_monthly_month.TabIndex = 4;
            this.lbl_monthly_month.Text = "Mes";
            // 
            // groupYearBalance
            // 
            this.groupYearBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupYearBalance.Controls.Add(this.yearly_result);
            this.groupYearBalance.Controls.Add(this.lblYearly_spent);
            this.groupYearBalance.Controls.Add(this.lblYearly_income);
            this.groupYearBalance.Controls.Add(this.lblYearly_year);
            this.groupYearBalance.Controls.Add(this.lbl_year_result);
            this.groupYearBalance.Controls.Add(this.lbl_year_spending);
            this.groupYearBalance.Controls.Add(this.lbl_year_income);
            this.groupYearBalance.Controls.Add(this.lbl_year);
            this.groupYearBalance.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupYearBalance.Location = new System.Drawing.Point(212, 51);
            this.groupYearBalance.Name = "groupYearBalance";
            this.groupYearBalance.Padding = new System.Windows.Forms.Padding(8);
            this.groupYearBalance.Size = new System.Drawing.Size(766, 164);
            this.groupYearBalance.TabIndex = 1;
            this.groupYearBalance.TabStop = false;
            this.groupYearBalance.Text = "Anual";
            // 
            // yearly_result
            // 
            this.yearly_result.AutoSize = true;
            this.yearly_result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearly_result.Location = new System.Drawing.Point(529, 96);
            this.yearly_result.Name = "yearly_result";
            this.yearly_result.Size = new System.Drawing.Size(0, 18);
            this.yearly_result.TabIndex = 7;
            // 
            // lblYearly_spent
            // 
            this.lblYearly_spent.AutoSize = true;
            this.lblYearly_spent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearly_spent.Location = new System.Drawing.Point(324, 96);
            this.lblYearly_spent.Name = "lblYearly_spent";
            this.lblYearly_spent.Size = new System.Drawing.Size(0, 18);
            this.lblYearly_spent.TabIndex = 6;
            // 
            // lblYearly_income
            // 
            this.lblYearly_income.AutoSize = true;
            this.lblYearly_income.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearly_income.Location = new System.Drawing.Point(132, 96);
            this.lblYearly_income.Name = "lblYearly_income";
            this.lblYearly_income.Size = new System.Drawing.Size(0, 18);
            this.lblYearly_income.TabIndex = 5;
            // 
            // lblYearly_year
            // 
            this.lblYearly_year.AutoSize = true;
            this.lblYearly_year.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearly_year.Location = new System.Drawing.Point(27, 96);
            this.lblYearly_year.Name = "lblYearly_year";
            this.lblYearly_year.Size = new System.Drawing.Size(0, 18);
            this.lblYearly_year.TabIndex = 4;
            // 
            // lbl_year_result
            // 
            this.lbl_year_result.AutoSize = true;
            this.lbl_year_result.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year_result.Location = new System.Drawing.Point(529, 57);
            this.lbl_year_result.Name = "lbl_year_result";
            this.lbl_year_result.Size = new System.Drawing.Size(74, 16);
            this.lbl_year_result.TabIndex = 3;
            this.lbl_year_result.Text = "Balance";
            // 
            // lbl_year_spending
            // 
            this.lbl_year_spending.AutoSize = true;
            this.lbl_year_spending.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year_spending.Location = new System.Drawing.Point(324, 57);
            this.lbl_year_spending.Name = "lbl_year_spending";
            this.lbl_year_spending.Size = new System.Drawing.Size(108, 16);
            this.lbl_year_spending.TabIndex = 2;
            this.lbl_year_spending.Text = "Egreso Total";
            // 
            // lbl_year_income
            // 
            this.lbl_year_income.AutoSize = true;
            this.lbl_year_income.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year_income.Location = new System.Drawing.Point(132, 57);
            this.lbl_year_income.Name = "lbl_year_income";
            this.lbl_year_income.Size = new System.Drawing.Size(112, 16);
            this.lbl_year_income.TabIndex = 1;
            this.lbl_year_income.Text = "Entrada Total";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_year.Location = new System.Drawing.Point(27, 57);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(40, 16);
            this.lbl_year.TabIndex = 0;
            this.lbl_year.Text = "Año";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(16, 51);
            this.listBox1.Margin = new System.Windows.Forms.Padding(20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 342);
            this.listBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarIngresoToolStripMenuItem,
            this.agregarEgresoToolStripMenuItem,
            this.modificarIngresosToolStripMenuItem,
            this.modificarEgresosToolStripMenuItem,
            this.eliminarMesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 114);
            // 
            // agregarIngresoToolStripMenuItem
            // 
            this.agregarIngresoToolStripMenuItem.Name = "agregarIngresoToolStripMenuItem";
            this.agregarIngresoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agregarIngresoToolStripMenuItem.Text = "Agregar Ingreso";
            this.agregarIngresoToolStripMenuItem.Click += new System.EventHandler(this.agregarIngresoToolStripMenuItem_Click);
            // 
            // agregarEgresoToolStripMenuItem
            // 
            this.agregarEgresoToolStripMenuItem.Name = "agregarEgresoToolStripMenuItem";
            this.agregarEgresoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agregarEgresoToolStripMenuItem.Text = "Agregar Egreso";
            this.agregarEgresoToolStripMenuItem.Click += new System.EventHandler(this.agregarEgresoToolStripMenuItem_Click);
            // 
            // modificarIngresosToolStripMenuItem
            // 
            this.modificarIngresosToolStripMenuItem.Name = "modificarIngresosToolStripMenuItem";
            this.modificarIngresosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modificarIngresosToolStripMenuItem.Text = "Modificar Ingresos";
            this.modificarIngresosToolStripMenuItem.Click += new System.EventHandler(this.modificarIngresosToolStripMenuItem_Click);
            // 
            // modificarEgresosToolStripMenuItem
            // 
            this.modificarEgresosToolStripMenuItem.Name = "modificarEgresosToolStripMenuItem";
            this.modificarEgresosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modificarEgresosToolStripMenuItem.Text = "Modificar Egresos";
            this.modificarEgresosToolStripMenuItem.Click += new System.EventHandler(this.modificarEgresosToolStripMenuItem_Click);
            // 
            // eliminarMesToolStripMenuItem
            // 
            this.eliminarMesToolStripMenuItem.Name = "eliminarMesToolStripMenuItem";
            this.eliminarMesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.eliminarMesToolStripMenuItem.Text = "Eliminar Mes";
            this.eliminarMesToolStripMenuItem.Click += new System.EventHandler(this.eliminarMesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accountant App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupMonthBalance.ResumeLayout(false);
            this.groupMonthBalance.PerformLayout();
            this.groupYearBalance.ResumeLayout(false);
            this.groupYearBalance.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResetYear;
        private System.Windows.Forms.Button btnNewBalances;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMonthDetails;
        private System.Windows.Forms.Button btnYearsDetails;
        private System.Windows.Forms.GroupBox groupMonthBalance;
        private System.Windows.Forms.GroupBox groupYearBalance;
        private System.Windows.Forms.Label lblPesosSavings;
        private System.Windows.Forms.Label lblDolarSavings;
        private System.Windows.Forms.Label dolarSavings;
        private System.Windows.Forms.Button btnSavings;
        private System.Windows.Forms.Label pesosSavings;
        private System.Windows.Forms.Label lbl_monthly_result;
        private System.Windows.Forms.Label lbl_monthly_income;
        private System.Windows.Forms.Label lbl_monthly_spending;
        private System.Windows.Forms.Label lbl_monthly_month;
        private System.Windows.Forms.Label yearly_result;
        private System.Windows.Forms.Label lblYearly_spent;
        private System.Windows.Forms.Label lblYearly_income;
        private System.Windows.Forms.Label lblYearly_year;
        private System.Windows.Forms.Label lbl_year_result;
        private System.Windows.Forms.Label lbl_year_spending;
        private System.Windows.Forms.Label lbl_year_income;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lblMonth_Result;
        private System.Windows.Forms.Label lblMonth_Income;
        private System.Windows.Forms.Label lblMonth_spendings;
        private System.Windows.Forms.Label lblMonth_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarIngresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEgresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEgresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMesToolStripMenuItem;
    }
}

