namespace Accountant_Form
{
    partial class NewMonthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMonthForm));
            this.btnAddMonth = new System.Windows.Forms.Button();
            this.MonthDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddMonth
            // 
            this.btnAddMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(149)))), ((int)(((byte)(94)))));
            this.btnAddMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMonth.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddMonth.Location = new System.Drawing.Point(155, 152);
            this.btnAddMonth.Name = "btnAddMonth";
            this.btnAddMonth.Size = new System.Drawing.Size(90, 52);
            this.btnAddMonth.TabIndex = 0;
            this.btnAddMonth.Text = "Aceptar";
            this.btnAddMonth.UseVisualStyleBackColor = false;
            this.btnAddMonth.Click += new System.EventHandler(this.btnAddMonth_Click_1);
            // 
            // MonthDropDown
            // 
            this.MonthDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthDropDown.FormattingEnabled = true;
            this.MonthDropDown.Location = new System.Drawing.Point(93, 67);
            this.MonthDropDown.Name = "MonthDropDown";
            this.MonthDropDown.Size = new System.Drawing.Size(223, 32);
            this.MonthDropDown.TabIndex = 1;
            // 
            // NewMonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(420, 258);
            this.Controls.Add(this.MonthDropDown);
            this.Controls.Add(this.btnAddMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewMonthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Balance Mensual | Accountant App";
            this.Load += new System.EventHandler(this.NewMonthForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMonth;
        private System.Windows.Forms.ComboBox MonthDropDown;
    }
}