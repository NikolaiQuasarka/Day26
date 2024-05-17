using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.DModels
{
    public class Note
    {
        public int IdNote {  get; set; }
        public string StudentFullName { get; set; }
        public string? ConstSubject { get; set; }
        public DateTime ConsultationTime { get; set; }
    }
}
