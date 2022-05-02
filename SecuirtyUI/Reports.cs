using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuirtyUI
{
    class Reports
    {
        public string Where { get; set; }
        public string Who { get; set; }
        public string Explanation { get; set; }


       public string getData()
        {
            return "A security guard has been detected in " + this.Where + ". The security has been described as " + this.Who + "." + "Explaination: " + this.Explanation;
        }
      
    }
}
