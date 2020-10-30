using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EF_CODEFIRST_WPF_DEMO
{
    class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
