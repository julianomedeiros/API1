using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Com_Swagger.Models
{
    [Table("Conta")]
    public class Conta
    {
        [Key]
        [Column("idContaBancaria")]
        public Int32 IdContaBancaria { get; set; }

        [Column("idCliente")]
        public Int32 IdCliente { get; set; }

        [Column("saldo")]
        public float Saldo { get; set; }
    }
}
