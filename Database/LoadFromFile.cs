using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;
using System.IO;

namespace WpfApp4.Database
{
    
    public class LoadFromFile
    {
        private string _csvFilePath;
        private readonly string _cvsFilePath;

        public string ErrorCode { get; set; }
        public List<Order> Orders { get; set; }

        public LoadFromFile()
        {
             _csvFilePath = "C:\\univ\\orders.txt";
            ErrorCode = string.Empty;
            Orders = new List<Order>();
        }

        public bool FromCsv()
        {
            try
            {
                var info = File.ReadAllLines(_csvFilePath);
                foreach(string value in info)
                {
                    var line = value.Split(',');
                    Orders.Add(new Order()
                    {
                        Name = line[0],
                        Price = Convert.ToDecimal(line[1]),
                        IsPaid = Convert.ToBoolean(line[2])
                    });
                }
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

