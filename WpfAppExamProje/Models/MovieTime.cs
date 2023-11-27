using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppExamProje.Models
{
    public class MovieTime
    {
        public DateTime DateTime { get; set; }

        public MovieTime()
        {
            DateTime = DateTime.Now;
        }
    }
}
