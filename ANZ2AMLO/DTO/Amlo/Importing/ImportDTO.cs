using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Amlo.Importing
{
  public  class ImportDTO: BaseDTO
    {

      public string HID { get; set; }
        public string DID { get; set; }
        public string ImportID { get; set; }
        public DataSet Data { get; set; }
    }


}
