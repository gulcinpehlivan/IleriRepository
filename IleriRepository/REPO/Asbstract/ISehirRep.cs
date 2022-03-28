using IleriRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.REPO.Asbstract
{
    interface ISehirRep
    {
        List<SehirDTO> SehirListe();
        
    }
}
