using IleriRepository.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IleriRepository.Models.ViewModel
{
    public class SehirModel
    {
        public Sehir Sehir{ get; set; }
        public string  Header { get; set; }
        public string  BtnClass { get; set; }
        public string BtnText { get; set; }
    }
}