using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NASA
{
    internal class APOD
    {
        public int Id { get; set; }
        public string url { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public string explanation { get; set; }
    }
}
