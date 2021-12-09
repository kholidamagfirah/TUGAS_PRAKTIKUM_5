using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_3_1204003_LATIHAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPilihMatkul_Click(object sender, EventArgs e)
        {
            if ((rbLaki.Checked == true || rbCewek.Checked == true) && numericTextBox1.Text != "" && charTextBox1.Text != "" && tbAlamat.Text != "" && cbProgramStudi.Text != "" && tbTahunAkademik.Text != "" && numericTextBox2.Text != "")
            {
                if (rbK6.Checked == true)
                {
                    gbMatkul.Enabled = false;
                    gbMatkul.Enabled = true;
                    cbPL.Enabled = false;
                    cbMRP.Enabled = false;
                }
                else if (rbK10.Checked == true)
                {
                    gbMatkul.Enabled = false;
                    gbMatkul.Enabled = true;
                    cbPL.Enabled = false;
                    cbMtk.Enabled = false;
                }

                else if (rbk14.Checked == true)
                {
                    gbMatkul.Enabled = false;
                    gbMatkul.Enabled = true;
                    cbMtk.Enabled = false;
                    cbMRP.Enabled = false;
                }
            }
            Size = new Size(800, 580);
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string matkul = " ";
            if (cbMtk.Checked) { matkul += cbMtk.Text; }
            if (cbPemrog1.Checked) { matkul += cbPemrog1.Text; }
            if (cbPemrog2.Checked) { matkul += cbPemrog2.Text; }
            if (cbPemrog3.Checked) { matkul += cbPemrog3.Text; }
            if (cbPemrog4.Checked) { matkul += cbPemrog4.Text; }
            if (cbPemrog5.Checked) { matkul += cbPemrog5.Text; }
            if (cbPemrog6.Checked) { matkul += cbPemrog6.Text; }
            if (cbPemog7.Checked) { matkul += cbPemog7.Text; }
            if (cbPL.Checked) { matkul += cbPL.Text; }
            if (cbJarkom.Checked) { matkul += cbJarkom.Text; }
            if (cbSisop.Checked) { matkul += cbSisop.Text; }
            if (cbMRP.Checked) { matkul += cbMRP.Text; }
            string JenisKel = rbLaki.Checked == true ? rbLaki.Text : rbCewek.Text;
            string kurikul = "";
            if (rbK6.Checked) { kurikul = rbK6.Text; } else if (rbK10.Checked) { kurikul = rbK10.Text; } else if (rbk14.Checked) { kurikul = rbk14.Text; }
            string message = String.Format("NPM : {0}\nNama : {1}\nJenis Kelamin : {2}\nAlamat : {3}\nProgram Studi : {4}\nTahun Akademik : {5}\nSemester : {6}\nKurikulum : {7}\nKelas : {8}\n", numericTextBox1.Text, charTextBox1.Text, JenisKel, tbAlamat.Text, cbProgramStudi.Text, tbTahunAkademik.Text, numericTextBox2.Text, kurikul, matkul);
            MessageBox.Show(message);
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }


