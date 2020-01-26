using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.DAL.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
    }
}
