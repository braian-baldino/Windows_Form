namespace Accountant_Form
{
    partial class SavingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavingsForm));
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.numericUSD = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            this.numericPesos = new System.Windows.Forms.NumericUpDown();
            this.btnAccept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPesos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.BackColor = System.Drawing.Color.Transparent;
            this.lblUSD.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblUSD.Location = new System.Drawing.Point(41, 106);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(123, 23);
            this.lblUSD.TabIndex = 0;
            this.lblUSD.Text = "USD Ahorros";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.BackColor = System.Drawing.Color.Transparent;
            this.lblPesos.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblPesos.Location = new System.Drawing.Point(41, 206);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(135, 23);
            this.lblPesos.TabIndex = 1;
            this.lblPesos.Text = "Pesos Ahorros";
            // 
            // numericUSD
            // 
            this.numericUSD.DecimalPlaces = 2;
            this.numericUSD.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUSD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUSD.Location = new System.Drawing.Point(45, 143);
            this.numericUSD.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numericUSD.Name = "numericUSD";
            this.numericUSD.Size = new System.Drawing.Size(280, 23);
            this.numericUSD.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTitle.Location = new System.Drawing.Point(94, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 23);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Administrar Ahorros";
            // 
            // numericPesos
            // 
            this.numericPesos.DecimalPlaces = 2;
            this.numericPesos.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPesos.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericPesos.Location = new System.Drawing.Point(45, 241);
            this.numericPesos.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numericPesos.Name = "numericPesos";
            this.numericPesos.Size = new System.Drawing.Size(280, 23);
            this.numericPesos.TabIndex = 5;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(149)))), ((int)(((byte)(94)))));
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAccept.Location = new System.Drawing.Point(137, 310);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(89, 43);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // SavingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(380, 406);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.numericPesos);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.numericUSD);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblUSD);
            this.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SavingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ahorros | Accountant App";
            ((System.ComponentModel.ISupportInitialize)(this.numericUSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.NumericUpDown numericUSD;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown numericPesos;
        private System.Windows.Forms.Button btnAccept;
    }
}