namespace Accountant_Form
{
    partial class CreateYearForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateYearForm));
            this.numericYear = new System.Windows.Forms.NumericUpDown();
            this.lblYearNum = new System.Windows.Forms.Label();
            this.btnAddYear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).BeginInit();
            this.SuspendLayout();
            // 
            // numericYear
            // 
            this.numericYear.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericYear.Location = new System.Drawing.Point(128, 85);
            this.numericYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericYear.Name = "numericYear";
            this.numericYear.Size = new System.Drawing.Size(140, 23);
            this.numericYear.TabIndex = 0;
            this.numericYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lblYearNum
            // 
            this.lblYearNum.AutoSize = true;
            this.lblYearNum.BackColor = System.Drawing.Color.Transparent;
            this.lblYearNum.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblYearNum.Location = new System.Drawing.Point(148, 37);
            this.lblYearNum.Name = "lblYearNum";
            this.lblYearNum.Size = new System.Drawing.Size(97, 23);
            this.lblYearNum.TabIndex = 1;
            this.lblYearNum.Text = "Elegir año";
            // 
            // btnAddYear
            // 
            this.btnAddYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(149)))), ((int)(((byte)(94)))));
            this.btnAddYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddYear.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddYear.Location = new System.Drawing.Point(161, 152);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(75, 36);
            this.btnAddYear.TabIndex = 2;
            this.btnAddYear.Text = "Aceptar";
            this.btnAddYear.UseVisualStyleBackColor = false;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click_1);
            // 
            // CreateYearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(404, 240);
            this.Controls.Add(this.btnAddYear);
            this.Controls.Add(this.lblYearNum);
            this.Controls.Add(this.numericYear);
            this.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateYearForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Balance Anual | Accountant App";
            ((System.ComponentModel.ISupportInitialize)(this.numericYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericYear;
        private System.Windows.Forms.Label lblYearNum;
        private System.Windows.Forms.Button btnAddYear;
    }
}