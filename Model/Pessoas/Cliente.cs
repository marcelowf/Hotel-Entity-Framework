using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class Cliente
    {
        [Key]
        public int CodCliente { get; set; }
        [StringLength(50)]
        public string? NomeCliente { get; set; }
        [StringLength(50)]
        public string? EmailCliente { get; set; }
        [StringLength(50)]
        public string? NacionalidadeCliente { get; set; }
        public ICollection<ContatosCliente>? Contatos { get; set; }
        public ICollection<Checkin>? Checkins { get; set; }
        public ICollection<CheckOut>? CheckOuts { get; set; }
        public ICollection<ConsumoRestaurante>? ConsumosRestaurante { get; set; }
        public ICollection<ConsumoFrigobar>? ConsumosFrigobar { get; set; }
        public ICollection<ConsumoLavanderia>? ConsumosLavanderia { get; set; }
    }
}
