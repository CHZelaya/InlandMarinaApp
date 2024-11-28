using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public class Lease
    {
        public int ID { get; set; }
        [Display (Name = "Slip Number")]
        public int SlipID { get; set; }
        [Display (Name = "Customer")]
        public int CustomerID { get; set; }

        //navigation properties
        public virtual Customer Customer { get; set; }
        public virtual Slip Slip { get; set; }
    }
}
