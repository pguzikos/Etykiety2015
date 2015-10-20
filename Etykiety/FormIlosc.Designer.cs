namespace Etykiety
{
    partial class FormIlosc
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
            this.textBoxIlosc = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIlosc
            // 
            this.textBoxIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIlosc.Location = new System.Drawing.Point(12, 12);
            this.textBoxIlosc.Name = "textBoxIlosc";
            this.textBoxIlosc.Size = new System.Drawing.Size(260, 31);
            this.textBoxIlosc.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(31, 49);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(66, 32);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "Drukuj";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAnuluj.Location = new System.Drawing.Point(153, 49);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(66, 32);
            this.buttonAnuluj.TabIndex = 2;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // FormIlosc
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonAnuluj;
            this.ClientSize = new System.Drawing.Size(284, 88);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxIlosc);
            this.Name = "FormIlosc";
            this.Text = "Ilość";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormIlosc_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIlosc;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonAnuluj;
    }
}