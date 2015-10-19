using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Etykiety
{
    public partial class FormIlosc : Form
    {
        public int _ilosc;
        public FormIlosc()
        {
            InitializeComponent();
            _ilosc = 0;
        }

        private void FormIlosc_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Escape)
                this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            textBoxIlosc.Text = String.Empty;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxIlosc.Text, out _ilosc);
            textBoxIlosc.Text = String.Empty;
            this.Close();

        }
    }
}
