using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlandMarinaData
{
    public class InlandMarinaSlipsManager
    {
        // get all slips
        public static List<Slip> GetSlips()
        {
            using (InlandMarinaContext db = new InlandMarinaContext())
            {
                return db.Slips.ToList();
            }
        }
    }
}
