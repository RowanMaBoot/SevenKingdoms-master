using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            dt.Columns.AddRange(new DataColumn[15] {
                new DataColumn("Name", typeof(string)),
                new DataColumn("ENGLISH",typeof(string)),
                new DataColumn("FRENCH", typeof(string)),
                new DataColumn("GERMAN", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("SPANISH", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("", typeof(string)),
                new DataColumn("x", typeof(string)), });

            dt.Columns["x"].DefaultValue = "x";

            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void importEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text files(.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileDialogFile = openFileDialog1.FileName;

                if (openFileDialog1.FileName.Contains(".txt"))
                {
                    #region StringsTextSearch
                    int index = 0;
                    char delimiter = '=';
                    string txtStorage1 = "";
                    string txtStorage2 = "";
                    string evtId = "id = ";
                    string evtDesc = "desc = ";
                    string optName = "name = ";
                    string hidTooltip = "hidden_tooltip";
                    string chrEvt = "character_event";
                    #endregion

                    string[] lines = File.ReadAllLines(fileDialogFile);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        txtStorage1 = lines[i];
                        delimiter = '#';

                        if (txtStorage1.Contains(evtId) & !txtStorage1.Contains(hidTooltip) & !txtStorage1.Contains(chrEvt))
                        {
                            if (txtStorage1.Contains(delimiter))
                            {
                                index = txtStorage1.IndexOf(delimiter);

                                if (index > 0)
                                {
                                    delimiter = '=';
                                    txtStorage2 = txtStorage1.Substring(0, index);

                                    txtStorage1 = txtStorage2.Substring(txtStorage2.IndexOf(delimiter) + 1);
                                    txtStorage1 = txtStorage1.Replace(" ", String.Empty);

                                    dt.Rows.Add(txtStorage1);
                                }
                            }
                            else
                            {
                                delimiter = '=';
                                if (txtStorage1.IndexOf(delimiter) > 0)
                                {
                                    txtStorage1 = txtStorage1.Substring(txtStorage1.IndexOf(delimiter) + 1);
                                    txtStorage1 = txtStorage1.Replace(" ", String.Empty);

                                    dt.Rows.Add(txtStorage1);
                                }                            
                            }
                        }
                        else if (txtStorage1.Contains(evtDesc))
                        {
                            txtStorage1 = txtStorage1.Replace(evtDesc, String.Empty);

                        }
                        else if (txtStorage1.Contains(optName))
                        {
                            txtStorage1 = txtStorage1.Replace(optName, String.Empty);
                        }
                    }
                }
            }
        }
    }
}

