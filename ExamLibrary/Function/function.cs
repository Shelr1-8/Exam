using Exam.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLibrary.Function
{
    public class KnygaManager
    {
        public List<Knyga> books = new List<Knyga>();
        public List<Avtor> avtors = new List<Avtor>();
        public List<Ganr> ganrs = new List<Ganr>();


        public void AddKnyga(Knyga knyga)
        {
            books.Add(knyga);
            Console.WriteLine("Succes");
        }

        public void RemoveKnyga(Knyga knyga)
        {
            books.Remove(knyga);
        }

        public void SellKnyga(Knyga knyga)
        {
            if (knyga != null)
            {
                Console.WriteLine($"Knyga '{knyga.Name}' was sale by {knyga.CinaDlaProdagy} grn.");
                books.Remove(knyga);
            }
            else
            {
                Console.WriteLine("Knyga not find.");
            }
        }

        public List<Knyga> SearchByName(string name)
        {
            return books.FindAll(b => b.Name == name);
        }

        public List<Avtor> SearchByAvtor(string avtor)
        {
            return avtors.FindAll(a => a.SurName == avtor);
        }
        public List<Ganr> SearchByGanre(string ganr)
        {
            return ganrs.FindAll(b => b.Name == ganr);
        }

        public void ShowKnyga()
        {
            foreach (var i in books)
            {
                Console.WriteLine($"Name: {i.Name}, Avtor: {i.Avtor}, Ganr: {i.Ganr}, Vydacnytstvo:{i.Vydacnytstvo}");
            }
        }

        internal void AddKnyga(string? name)
        {
            throw new NotImplementedException();
        }

        internal void RemoveKnyga(string? removeknyga)
        {
            throw new NotImplementedException();
        }

        internal void SellKnyga(string? sellknyga)
        {
            throw new NotImplementedException();
        }
    }
}
