using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHI_Library_System.Views.Interface
{
    public interface IExams
    {
        int Exam_ID { get; set; }
        string Exam_Description { get; set; }
        string Doctor_ID { get; set; }
    }
}
