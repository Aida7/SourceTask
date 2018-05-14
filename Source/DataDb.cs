using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Source
{
    public class DataDb
    {
        public int Id { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int MessageId { get; set; }
        public Message Message { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
    }
}
