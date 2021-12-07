using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ObrasSociales
    {

        public enum ObraSocial { NoTiene, CoberturaBasica, CoberturaCompleta }

        public static ObraSocial devolverObraSocialRandom()
        {
            int numeroRandom = new Random().Next(1, 4);
            ObraSocial obrasocial = ObraSocial.NoTiene;
            switch (numeroRandom)
            {
                case 1: obrasocial = ObraSocial.NoTiene; break;
                case 2: obrasocial = ObraSocial.CoberturaBasica; break;
                case 3: obrasocial = ObraSocial.CoberturaCompleta; break;
          
            }
            
            return obrasocial;
        }


    }
}
