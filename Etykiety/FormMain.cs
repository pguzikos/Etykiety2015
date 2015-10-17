using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Etykiety
{
    public partial class FormMain : Form
    {
        FormIlosc _frmIlosc;

        public FormMain()
        {
            _frmIlosc = new FormIlosc();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // logika stripowania tekstu
            if (textBox1.Text.Length >= 10)
            {
                _frmIlosc._ilosc = 0;
                _frmIlosc.ShowDialog();
                textBox1.Text = "";
                if (_frmIlosc._ilosc > 0) //drukuj
                {
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("pIndeks", "Ala ma kota"));
                    reportViewer1.LocalReport.SetParameters(new ReportParameter("pIlosc", "10"));
                    reportViewer1.RefreshReport();       
                }
            }
        }
        private void odczytajDane(string nrPrzewodnika)
        {
            SqlConnection sqlConnection1 = new SqlConnection("Your Connection String");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Customers";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            sqlConnection1.Close();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            reportViewer1.PrintDialog();
        }
    }
}
