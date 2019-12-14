using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class DataItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Grade { get; set; }
        public string Job { get; set; }
        public double TotalEarnings { get; set; }
      
    

      }
 }



