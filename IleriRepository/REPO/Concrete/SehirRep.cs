using IleriRepository.CORE.Concrete;
using IleriRepository.DTO;
using IleriRepository.Models.Data;
using IleriRepository.REPO.Asbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IleriRepository.REPO.Concrete
{
    public class SehirRep : BaseRepository<Sehir>, ISehirRep
    {
        public List<SehirDTO> SehirListe()
        {
           return Set().Select(x => new SehirDTO
            {
                SehirId = x.SehirId,
                SehirAd = x.SehirAd
            }).ToList();
         
        }
    }
}