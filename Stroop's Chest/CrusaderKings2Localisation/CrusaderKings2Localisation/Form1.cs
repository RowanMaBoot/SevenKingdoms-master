using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrusaderKings2Localisation
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

            dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
            new DataColumn("Name", typeof(string)),
            new DataColumn("ENGLISH",typeof(string)) });

            this.dataGridView1.DataSource = dt;
        }

        private void btn_GetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text files(.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileName.Contains(".txt"))
                {
                    string textStorage = "";

                    textBox1.Text = openFileDialog1.FileName;
                    System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);

                    textStorage = file.ReadLine();

                    textStorage = textStorage.Replace("namespace = ", String.Empty);

                    

                    dt.Rows.Add(1, textStorage, "English");
                }
            }
        }
    }
}

