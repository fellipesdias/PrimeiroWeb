using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace primeiroweb.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Range(1, 99, ErrorMessage = "Valor fora da faixa")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public categoria Categoria { get; set; }
    }
}
