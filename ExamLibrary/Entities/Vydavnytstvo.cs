using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Entities
{
    public class Vydacnytstvo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Knyga> Knygi { get; set; }

    }
}
