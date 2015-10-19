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
        DataSet1TableAdapters.DataTableMonacoTableAdapter _monacoTa;
        DataSet1TableAdapters.TwrKartyTableAdapter _twrTa;
        DataSet1.TwrKartyDataTable _twrDt;
        DataSet1.DataTableMonacoDataTable _monacoDt;

        public FormMain()
        {
            _monacoTa = new DataSet1TableAdapters.DataTableMonacoTableAdapter();
            _twrTa = new DataSet1TableAdapters.TwrKartyTableAdapter();
            _twrDt = new DataSet1.TwrKartyDataTable();
            _monacoDt = new DataSet1.DataTableMonacoDataTable();
            _frmIlosc = new FormIlosc();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // logika stripowania tekstu
            int ilosc;
            if (textBox1.Text.Length >= 10)
            {
                try
                {
                    _monacoTa.Fill(_monacoDt, textBox1.Text);
                    if (_monacoDt.Rows.Count > 0)
                    {
                        _frmIlosc._ilosc = 0;
                        _frmIlosc.ShowDialog();
                        ilosc = _frmIlosc._ilosc;
                        textBox1.Text = "";
                        if (_frmIlosc._ilosc > 0) //drukuj
                        {
                            przygotujRaport(_monacoDt[0].kod, ilosc.ToString(), _monacoDt[0].Nazwa_elementu_wiodącego, _monacoDt[0].zs);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem z polaczeniem z baza");
                }


            }
            else
            {

            }
        }

        private void przygotujRaport(String _indeks, String _ilosc, String _nazwa, String _zamowienie)
        {
            reportViewer1.LocalReport.SetParameters(new ReportParameter("pIndeks", _indeks));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("pNazwa", _nazwa));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("pIlosc", _ilosc));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("pZamowienie", _zamowienie));
            reportViewer1.RefreshReport();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_RenderingComplete(object sender, RenderingCompleteEventArgs e)
        {
            reportViewer1.PrintDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                szukajIndeksu(textBox1.Text.Trim());
            }
            if (e.KeyChar == (char)27)
            {
                textBox1.Text = string.Empty;
            }
        }

        private void szukajIndeksu(string p)
        {
            int ilosc;
            try
            {
                _twrTa.Fill(_twrDt, p);
                if (_twrDt.Rows.Count > 0)
                {
                    _frmIlosc._ilosc = 0;
                    _frmIlosc.ShowDialog();

                    textBox1.Text = "";
                    ilosc = _frmIlosc._ilosc;
                    if (ilosc > 0)
                    {
                        przygotujRaport(_twrDt[0].Twr_Kod, ilosc.ToString(), _twrDt[0].Twr_Nazwa, "  ");
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Problem z polaczeniem {0}",ex.Message);
            }
        }
    }
}
