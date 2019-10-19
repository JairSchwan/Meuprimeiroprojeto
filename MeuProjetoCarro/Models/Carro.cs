using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuProjetoCarro.Models
{
    public class Carro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool Ativo { get; set; }
        
    }
}
