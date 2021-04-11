using Aquarismo.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aquarismo.Models
{
    public class Peixe
    {
        public Categoria Categoria { get; set; }

        public string Nome { get; set; }

        public string Tipo_de_Agua { get; set; }

        public string Familia { get; set; }

        public string Especie { get; set; }

        public string Região { get; set; }

        public string Descriçao { get; set; }

        

        
    }
}
