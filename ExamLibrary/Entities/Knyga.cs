using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Entities
{
    public class Knyga
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountPages { get; set; }
        public int Year { get; set; }
        public int Sobivartist { get; set; }
        public int CinaDlaProdagy { get; set; }
        public string Prodovgenna { get; set; }//yes/no
        public Avtor Avtor { get; set; }
        public int AvtorId { get; set; }
        public Ganr Ganr { get; set; }
        public int GanrId { get; set; }
        public Vydacnytstvo Vydacnytstvo { get; set; }
        public int VydacnytstvoId { get; set; }

    }
}
