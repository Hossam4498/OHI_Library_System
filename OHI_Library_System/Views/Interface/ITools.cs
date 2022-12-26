using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Views.Interface
{
    public interface ITools
    {
        int Tool_ID { get; set; }
        string Tool_Name { get; set; }
        string Tool_Description { get; set; }
    }
}
