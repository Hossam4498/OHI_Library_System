using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Views.Interface
{
    public interface IStudents
    {
        int Student_ID { get; set; }
        string Student_Name { get; set; }
        string Student_Phone { get; set; }
        string Student_Department { get; set; }
        string Student_Year { get; set; }
    }
}
