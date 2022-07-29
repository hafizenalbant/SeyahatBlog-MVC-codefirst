using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Sınıflar
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; }
        public int Baslik { get; set; }
        public int Aciklama { get; set; }

    }
}