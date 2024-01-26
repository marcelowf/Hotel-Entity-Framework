using System.Collections.Generic;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace Trabalho
{
    public class ConsumoRestaurante
    {
        [Key]
        public int CodConsumoRestaurante{ get; set; }
        public int CodCliente { get; set; }
        public int CodRestaurante { get; set; }
        public int CodNotaFiscal { get; set; }
        [StringLength(150)]
        public string? DescricaoConsumo { get; set; }
        public float ValorConsumo { get; set; }
        public bool EntregaNoQuarto { get; set; }
        public bool Assinado { get; set; }
        public Cliente? Cliente { get; set; }
        public Restaurante? Restaurante { get; set; }
        public CheckOut? CheckOut { get; set; }
    }
}
