using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using WpfApp4.Models;

namespace WpfApp4.Database
{
   public  class SaveToFile
    {
        private string _csvFilePath;

        public string ErrorCode { get; set; }

        public SaveToFile()
        {
            _csvFilePath = "C:\\univ\\orders.txt";

            ErrorCode = string.Empty;
        }

        public bool ToCsv( Order order)
        {
            try 
            {
                string csv = $"{order.Name},{order.Price.ToString()},{order.IsPaid.ToString()}";
                csv = csv + Environment.NewLine;
                File.AppendAllText(_csvFilePath, csv.ToString());
                return true;
            }
            catch(Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;

            }



        }
    }
}
