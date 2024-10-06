using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Entities
{
    public class Avtor
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public ICollection<Knyga> Knygi { get; set; }
    }
}
