using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Views.Interface
{
    public interface IGraduationProjects
    {
        int Project_ID { get; set; }
        string Project_Name { get; set; }
        string Project_Department { get; set; }
        string Project_Year { get; set; }
        string Student_Name { get; set; }
    }
}
