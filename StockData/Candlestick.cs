using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDisplay.StockData
{
    internal class Candlestick
    {
        // Date Variable
        public DateTime Date { get; set; }
        // Open Variable
        public double Open { get; set; }
        // High Variable    
        public double High { get; set; }    
        // Low Variable
        public double Low { get; set; }
        // Close Variable
        public double Close { get; set; }
        // Adjusted Close Variable
        public double AdjustedClose { get; set; }
        // Volume Variable
        public double Volume { get; set; }
        // Defualt constructor for Candlestick class
        public Candlestick()
        {
            Date = DateTime.Now;
            Open = 0;
            High = 0;
            Low = 0;
            Close = 0;
            AdjustedClose = 0;
            Volume = 0;
        }
        // Constructor for Candlestick class using string
        public Candlestick(string csvLine)
        {
            // Split the csvLine into an array of strings by delimiter ,
            string[] values = csvLine.Split(',');
            // Set the Date to the first value in the array
            Date = DateTime.Parse(values[0]);
            // Set the Open to the second value in the array
            Open = double.Parse(values[1]);
            // Set the High to the third value in the array
            High = double.Parse(values[2]);
            // Set the Low to the fourth value in the array
            Low = double.Parse(values[3]);
            // Set the Close to the fifth value in the array
            Close = double.Parse(values[4]);
            // Set the Adjusted Close to the sixth value in the array
            AdjustedClose = double.Parse(values[5]);
            // Set the Volume to the seventh value in the array
            Volume = double.Parse(values[6]);
        }   
    }
}
