using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockDisplay
{
    public partial class StockDataGridViewForm : Form
    {
        /// <summary>
        /// Default constructor for the StockDataGridViewForm class
        /// </summary>
        public StockDataGridViewForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Finds current directory, then navigates to the StockData folder 
        /// and returns it
        /// </summary>
        /// <returns></returns>
        private string GetRelativePath()
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
        /// <summary>
        /// When Load Stock button is clicked, open the file dialog will open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LoadDataButton_Click(object sender, EventArgs e)
        {
            // Show the open file dialog
            if (this.loadStocksOpenFileDialog.ShowDialog() == DialogResult.OK)
        }
        /// <summary>
        /// When the Update button is clicked, the data grid view will be updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void UpdateButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// When the form is loaded, set the open file dialog's initial directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void StockDataGridViewForm_Load(object sender, EventArgs e)
        {
            // Set initial directory for the open file dialog
            this.loadStocksOpenFileDialog.InitialDirectory = GetRelativePath();
        }
        /// <summary>
        /// 
        /// </summary>
        private void OpenFilePath(string filePath)
        {
            // Create a new stream reader object to read filePath
            StreamReader reader = new StreamReader(filePath);  
            // Create a new list of strings to store the data
        }
        /// Design Notes:
        /// startdateLabel -> startDatetimePicker distance = 78
        ///
    }
}
