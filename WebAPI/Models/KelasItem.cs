using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class KelasItem
    {
        private KelasContext _context;
        public int id { get; set; }
        public string kelas { get; set; }
        public string jurusan { get; set; }
        public int sub { get; set; }
    }
}
