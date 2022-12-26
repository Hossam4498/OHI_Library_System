using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Views.Interface
{
    public interface IDoctors 
    {
        int Doctor_ID { get; set; }
        string Doctor_Name { get; set; }
        string Doctor_Phone { get; set; }
        string Doctor_Department { get; set; }
    }
}
