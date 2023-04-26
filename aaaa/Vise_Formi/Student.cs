using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vise_Formi
{
    internal class Student
    {
        private string ime, prezime, brojindeksa, smjer;
        DateTime datumRodjenja;

        public Student()
        {

        }

        public Student(string ime, string prezime, string brojindeksa, string smjer, DateTime datumRodjenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojindeksa = brojindeksa;
            this.smjer = smjer;
            this.datumRodjenja = datumRodjenja;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Brojindeksa { get => brojindeksa; set => brojindeksa = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public override string ToString()
        {
            return ime + "\t" + prezime + "\t" + brojindeksa + "\t" + smjer + "\t" + datumRodjenja;
        }
    }
}
