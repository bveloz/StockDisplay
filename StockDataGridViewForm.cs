using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDisplay
{
    public partial class StockDataGridViewForm : Form
    {
        public StockDataGridViewForm()
        {
            InitializeComponent();
        }

        string GetRelativePath()
        {
            // Get the current directory
            string curDir = System.IO.Directory.GetCurrentDirectory();
            // Split the current directory into an array of strings by delimiter /
            string[] strs = curDir.Split('\\');
            // Reset curDir
            curDir = "";
            foreach (string str in strs)
            {
                curDir += str + "\\";
                // If the string contains the word "StockDisplay"
                if (str.Contains("StockDisplay"))
                {
                    // Add stock data to the relative path
                    curDir += "StockData";
                    // Return the relative path
                    return curDir;
                }
            }
            // Return the relative path
            return "";
        }

        private void LoadDataButton_Click(object sender, EventArgs e)
        {
            // Show the open file dialog
            this.loadStocksOpenFileDialog.ShowDialog(); 
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void StockDataGridViewForm_Load(object sender, EventArgs e)
        {
            // Set initial directory for the open file dialog
            this.loadStocksOpenFileDialog.InitialDirectory = GetRelativePath();
        }
    }
}
