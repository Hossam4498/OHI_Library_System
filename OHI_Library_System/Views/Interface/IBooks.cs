using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Views.Interface
{
    public interface IBooks
    {
        int Book_ID { get; set; }
        string Book_Category { get; set; }
        string Book_Name { get; set; }
        string Author { get; set; }
        string Copyright { get; set; }
    }
}
