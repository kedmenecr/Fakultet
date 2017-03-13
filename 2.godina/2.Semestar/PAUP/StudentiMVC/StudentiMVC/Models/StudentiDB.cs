﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentiMVC.Models
{

    public class StudentiDB
    {
        //lista studentava
        private List<Student> studenti = new List<Student>();

        public StudentiDB()
        {
            studenti.Add(new Student
            {
                Id = 1,
                Ime = "Marko",
                Prezime = "Marković",
                Spol = Spol.Muški,
                OIB = "12345678903",
                Datumrodjenja = new DateTime(1997,8,9),
                GodinaStudija = GodinaStudija.Peta,
                RedovniStudent = RedovniStudent.Redovni

            });
            studenti.Add(new Student
            {
                Id = 2,
                Ime = "Dominik",
                Prezime = "Rubina",
                Spol = Spol.Ženski,
                OIB = "12345678904",
                Datumrodjenja = new DateTime(1996,8,19),
                GodinaStudija = GodinaStudija.Druga,
                RedovniStudent = RedovniStudent.Vanredni

            });

            


        }

        public List<Student> VratiStudent()
        {
            return studenti;
        }


    }
}

