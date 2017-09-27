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
                new DataColumn("NAME", typeof(string)),
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
                new DataColumn("X", typeof(string)), });

            #region DataTableSettings
            dt.Columns["x"].DefaultValue = "x";
            dt.Columns["EMPTY1"].ReadOnly = true;
            dt.Columns["EMPTY2"].ReadOnly = true;
            dt.Columns["EMPTY3"].ReadOnly = true;
            dt.Columns["EMPTY4"].ReadOnly = true;
            dt.Columns["EMPTY5"].ReadOnly = true;
            dt.Columns["EMPTY6"].ReadOnly = true;
            dt.Columns["EMPTY7"].ReadOnly = true;
            dt.Columns["EMPTY8"].ReadOnly = true;
            dt.Columns["EMPTY9"].ReadOnly = true;
            dt.Columns["X"].ReadOnly = true;
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

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Contains(".txt"))
            {
                string fileDialogFile = openFileDialog1.FileName;

                ConvertEvents eventConversion = new ConvertEvents();

                string[] lines = File.ReadAllLines(fileDialogFile);

                for (int i = 0; i < lines.Length; i++)
                {
                    eventConversion.processedLine = lines[i];
                    eventConversion.delimiter = '#';

                    if (eventConversion.processedLine.Contains(eventConversion.evtId) & !eventConversion.processedLine.Contains(eventConversion.hidTooltip) & !eventConversion.processedLine.Contains(eventConversion.chrEvt))
                    {
                        if (eventConversion.processedLine.Contains(eventConversion.delimiter))
                        {
                            eventConversion.index = eventConversion.processedLine.IndexOf(eventConversion.delimiter);

                            if (eventConversion.index > 0)
                            {
                                eventConversion.delimiter = '=';
                                eventConversion.txtStorage2 = eventConversion.processedLine.Substring(0, eventConversion.index);

                                eventConversion.processedLine = eventConversion.txtStorage2.Substring(eventConversion.txtStorage2.IndexOf(eventConversion.delimiter) + 1);
                                eventConversion.processedLine = eventConversion.processedLine.Replace(" ", String.Empty);

                                dt.Rows.Add(eventConversion.processedLine);
                            }
                        }
                        else
                        {
                            eventConversion.delimiter = '=';
                            if (eventConversion.processedLine.IndexOf(eventConversion.delimiter) > 0)
                            {
                                eventConversion.processedLine = eventConversion.processedLine.Substring(eventConversion.processedLine.IndexOf(eventConversion.delimiter) + 1);
                                eventConversion.processedLine = eventConversion.processedLine.Replace(" ", String.Empty);

                                dt.Rows.Add(eventConversion.processedLine);
                            }
                        }
                    }
                    else if (eventConversion.processedLine.Contains(eventConversion.evtDesc))
                    {
                        eventConversion.processedLine = eventConversion.processedLine.Replace(eventConversion.evtDesc, String.Empty);

                    }
                    else if (eventConversion.processedLine.Contains(eventConversion.optName))
                    {
                        eventConversion.processedLine = eventConversion.processedLine.Replace(eventConversion.optName, String.Empty);
                    }
                }
            }
        }


        private class ConvertEvents
        {
            #region StringsTextSearch
            public int index = 0;
            public char delimiter = '=';
            public string processedLine = "";
            public string txtStorage2 = "";
            public string evtId = "id = ";
            public string evtDesc = "desc = ";
            public string optName = "name = ";
            public string hidTooltip = "hidden_tooltip";
            public string chrEvt = "character_event";
            #endregion
        }
    }
}

