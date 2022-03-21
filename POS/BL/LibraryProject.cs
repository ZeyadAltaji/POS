using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.BL
{
    internal class LibraryProject
    {
        public DB_SMP db_smp = new DB_SMP();
        public MemoryStream ms = new MemoryStream();
        public byte[] by;
        //convert to byte
        public byte[] convertByte()
        {
            return ms.ToArray();
        }
        //convet to image
        public MemoryStream convetImg()
        {
            ms = new MemoryStream(by);
            return ms;
        }
  

    }
}
