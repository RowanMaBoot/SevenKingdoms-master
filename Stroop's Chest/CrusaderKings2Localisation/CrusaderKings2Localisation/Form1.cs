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
                new DataColumn("EMPTY1", typeof(string)),
                new DataColumn("SPANISH", typeof(string)),
                new DataColumn("EMPTY2", typeof(string)),
                new DataColumn("EMPTY3", typeof(string)),
                new DataColumn("EMPTY4", typeof(string)),
                new DataColumn("EMPTY5", typeof(string)),
                new DataColumn("EMPTY6", typeof(string)),
                new DataColumn("EMPTY7", typeof(string)),
                new DataColumn("EMPTY8", typeof(string)),
                new DataColumn("EMPTY9", typeof(string)),
                new DataColumn("x", typeof(string)), });

            #region ColumnSettings
            dt.Columns["x"].DefaultValue = "x";
            dt.Columns["x"].ReadOnly = true;
            dt.Columns["Column1"].ReadOnly = true;
            dt.Columns["Column2"].ReadOnly = true;
            dt.Columns["Column3"].ReadOnly = true;
            dt.Columns["Column4"].ReadOnly = true;
            dt.Columns["Column5"].ReadOnly = true;
            dt.Columns["Column6"].ReadOnly = true;
            dt.Columns["Column7"].ReadOnly = true;
            dt.Columns["Column8"].ReadOnly = true;
            dt.Columns["Column9"].ReadOnly = true;
            #endregion

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

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Save before Quitting?";
            string caption = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (
            {

            }
            this.Close();
        }

        private void ExportToCSV(DataGridView gridIn, string outputFilePath)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow gridRow = new DataGridViewRow();
                StreamWriter writeOut = new StreamWriter(outputFilePath);

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "CSV Files(.csv)|*.csv";


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //write header rows to csv
                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            writeOut.Write(";");
                        }
                        writeOut.Write(gridIn.Columns[i].HeaderText);
                    }

                    writeOut.WriteLine();

                    //write DataGridView rows to csv
                    for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                    {
                        if (j > 0)
                        {
                            writeOut.WriteLine();
                        }

                        gridRow = gridIn.Rows[j];

                        for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                writeOut.Write(";");
                            }

                            value = gridRow.Cells[i].Value.ToString();
                            //replace comma's with spaces
                            value = value.Replace(',', ' ');
                            //replace embedded newlines with spaces
                            value = value.Replace(Environment.NewLine, " ");

                            writeOut.Write(value);
                        }
                    }
                    writeOut.Close();

                    MessageBox.Show("The File was saved sucessfully!", "Completed!", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                }
            }
        }

        private void exportLocalisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV Files(.csv)|*.csv";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writeCSV(dataGridView1, saveFileDialog1.FileName);
                MessageBox.Show("Converted successfully to *.csv format");

            }           
        }

        public void writeCSV(DataGridView gridIn, string outputFile)
        {
            
        }
    }
}

