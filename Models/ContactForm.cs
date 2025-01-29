using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactFormApp2.Models
{
    public class ContactForm
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Departman { get; set; }
        public string Mesaj { get; set; }
    }

}