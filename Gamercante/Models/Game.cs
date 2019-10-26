using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gamercante.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double Preco { get; set; }
        public string Plataforma { get; set; }
        public int TipoNegocio { get; set; }
        public string Descricao { get; set; }
        public string Img { get; set; }
    }
}
