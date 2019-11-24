using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMVC.Models
{
    public class categorymodel
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }   
        public int BlogSayisi { get; set; }
    }
}