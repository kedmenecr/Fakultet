using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentiMVC.Models
{

    public class StudentiDB
    {
        //lista studentava
        private static List<Student> studenti = new List<Student>();
        private static bool inicijaliziraniLista = false;

        public StudentiDB()
        {
            if(inicijaliziraniLista == false)
            {
                inicijaliziraniLista = true;
                //dodavanje prvog studenta
            studenti.Add(new Student
            {
                Id = 1,
                Ime = "Marko",
                Prezime = "Marković",
                Spol = Spol.M,
                OIB = "12345678903",
                Datumrodjenja = new DateTime(1997,8,9),
                GodinaStudija = 1,
                RedovniStudent = RedovniStudent.Redovni

            });
            studenti.Add(new Student
            {
                Id = 2,
                Ime = "Dominik",
                Prezime = "Rubina",
                Spol = Spol.Ž,
                OIB = "12345678904",
                Datumrodjenja = new DateTime(1996,8,19),
                GodinaStudija = 2,
                RedovniStudent = RedovniStudent.Vanredni

            });

            }



        }

        public List<Student> VratiStudent()
        {
            return studenti;
        }
        //azuriranje studenta
        public void AzuriranjeStudenta(Student s)
        {
            int indeks = studenti.FindIndex(x => x.Id == s.Id);
            studenti[indeks] = s;
        }

        public void DodajStudenta(Student s)
        {
            int noviID = (from st in studenti select st).Max(x => x.Id) + 1;
            s.Id = noviID;
            studenti.Add(s);
        }
        public void ObrisiStudenta(Student s)
        {
            int indeks = studenti.FindLastIndex(x => x.Id == s.Id);
            studenti.RemoveAt(indeks);
        }

    }
}

