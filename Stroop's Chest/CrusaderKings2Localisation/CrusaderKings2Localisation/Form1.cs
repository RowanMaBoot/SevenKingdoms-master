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

//If the word "Event" is mentioned in a comment, it's reffering to a CK2 event.

namespace CrusaderKings2Localisation
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

            //Adds the Columns to the DataTable
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

            //Configures the Columns
            #region ColumnSettings
            dt.Columns["x"].DefaultValue = "x";
            dt.Columns["x"].ReadOnly = true;
            dt.Columns["EMPTY1"].ReadOnly = true;
            dt.Columns["EMPTY2"].ReadOnly = true;
            dt.Columns["EMPTY3"].ReadOnly = true;
            dt.Columns["EMPTY4"].ReadOnly = true;
            dt.Columns["EMPTY5"].ReadOnly = true;
            dt.Columns["EMPTY6"].ReadOnly = true;
            dt.Columns["EMPTY7"].ReadOnly = true;
            dt.Columns["EMPTY8"].ReadOnly = true;
            dt.Columns["EMPTY9"].ReadOnly = true;
            #endregion

            //Connects the DataTable to the DataGridView
            this.dataGridView1.DataSource = dt;
        }

        private void importEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lets the User select an Event file to import
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Text files(.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;

            //If the user has selected a "*.txt" file, start scanning the lines of said file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Contains(".txt"))
            {
                PopUp clearLoc = new PopUp();

                clearLoc.message = "Do you want to clear the Data Table?";
                clearLoc.caption = "Confirm";
                clearLoc.buttons = MessageBoxButtons.YesNo;
                clearLoc.result = MessageBox.Show(clearLoc.message, clearLoc.caption, clearLoc.buttons);

                if (clearLoc.result == DialogResult.Yes)
                {
                    dt.Rows.Clear();
                    dataGridView1.Refresh();
                }
                #region StringsTextSearch
                int index = 0;
                string currentLine;
                string evtId = "id = ";
                string evtDesc = "desc = ";
                string optName = "name = ";
                string hidTooltip = "hidden_tooltip";
                string chrEvt = "character_event";
                #endregion

                //Reads all lines in the file, and puts them in an Array
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);

                //Checks if the scanned line contains any of the characters needed to identify which kind of line it is
                for (int i = 0; i < lines.Length; i++)
                {
                    //Stores the currently selected line's index
                    currentLine = lines[i];

                    //Filters out all of the Events which do not require localisation
                    if (currentLine.Contains(evtId) & !currentLine.Contains(hidTooltip) & !currentLine.Contains(chrEvt))
                    {
                        ProcessLines(currentLine, index);
                    }
                    //Unfinished
                    else if (currentLine.Contains(evtDesc) & !currentLine.Contains('{'))
                    {
                        ProcessLines(currentLine, index);
                    }
                    //Unfinished
                    else if (currentLine.Contains(optName))
                    {
                        ProcessLines(currentLine, index);                        
                    }
                }
            }
        }

        private void ProcessLines(string currentLine, int delimiterIndex)
        {
            string tempTxt;
            char delimiter1 = '=';
            char delimiter2 = '#';

            if (currentLine.Contains(delimiter2))
            {
                delimiterIndex = currentLine.IndexOf(delimiter2);

                //Ensures that the delimiter actually has an index, and if it does it switches it to '=', to allow the first part of the EventID to be removed ("ID ="). The line is then added to the DataTable
                if (delimiterIndex > 0)
                {
                    tempTxt = currentLine.Substring(0, delimiterIndex);

                    currentLine = tempTxt.Substring(tempTxt.IndexOf(delimiter1) + 1);
                    currentLine = currentLine.Replace(" ", String.Empty);

                    dt.Rows.Add(currentLine);
                }
            }
            //Removes the first part of the EventID, and then adds the line to the DataTable.
            else
            {
                if (currentLine.IndexOf(delimiter1) > 0)
                {
                    currentLine = currentLine.Substring(currentLine.IndexOf(delimiter1) + 1);
                    currentLine = currentLine.Replace(" ", String.Empty);

                    dt.Rows.Add(currentLine);
                }
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // DON'T MIND ANY OF THIS, FAAAR FROM FINISHED!!!!(!)
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV Files(.csv)|*.csv";

            PopUp exitPopUp = new PopUp();

            exitPopUp.message = "Do you want to Save your work before you Quit?";
            exitPopUp.caption = "Confirm";
            exitPopUp.buttons = MessageBoxButtons.YesNoCancel;
            exitPopUp.result = MessageBox.Show(exitPopUp.message, exitPopUp.caption, exitPopUp.buttons);

            if (exitPopUp.result == DialogResult.Yes)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(dataGridView1, saveFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("Error!");
                }
                this.Close();
            }
            else if (exitPopUp.result == DialogResult.No)
            {
                exitPopUp.message = "Are you sure you want to Quit without Saving?\nPotential Fileloss!";
                exitPopUp.caption = "Are you sure?";
                exitPopUp.buttons = MessageBoxButtons.YesNo;

                if (exitPopUp.result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void ExportToCSV(DataGridView gridIn, string outputFilePath)
        {
            //Checks if the DataGridView has any rows, and if it does the saving process is started.
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow gridRow = new DataGridViewRow();
                StreamWriter writeOut = new StreamWriter(outputFilePath);

                //    PopUp exportPopUp = new PopUp();
                //  exportPopUp.message = "The File was saved sucessfully!";
                // exportPopUp.caption = "Completed!";

                //Write header rows to csv
                for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        writeOut.Write(";");
                    }
                    writeOut.Write(gridIn.Columns[i].HeaderText);
                }

                writeOut.WriteLine();

                //Write DataGridView rows to csv
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

                        //Partly stolen, hence I'm researching exactly what the whole embedded newlines business is about.
                        value = gridRow.Cells[i].Value.ToString();
                        //Replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //Replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");

                        writeOut.Write(value);
                    }

                    writeOut.Close();

                    //MessageBox.Show(exportPopUp.message, exportPopUp.caption, exportPopUp.buttons, exportPopUp.icon, exportPopUp.defaultButtons);
                }
            }
            else
            {
                PopUp errorBox = new PopUp();
                errorBox.Message("The File could not be saved, missing rows");
                errorBox.Caption("Critical Error");
                errorBox.Icon(MessageBoxIcon.Error);

                MessageBox.Show(errorBox.message, errorBox.caption, errorBox.buttons, errorBox.icon, errorBox.defaultButtons);
            }
        }

        private void exportLocalisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initializes the PopUp class and a SaveFileDialog
            PopUp toolStripPopUp = new PopUp();
            toolStripPopUp.Message("The File was saved succesfully!");

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV Files(.csv)|*.csv";

            //If the User sucessfully managed to choose a File Name, do ExportToCSV.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
            }
        }
    }
}

