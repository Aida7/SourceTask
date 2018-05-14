using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class Status
    {
        public int Id { get; set; }
        public string StatusStr { get; set; }
        public virtual ICollection<DataDb> DataDbs { get; set; }
    }
}
