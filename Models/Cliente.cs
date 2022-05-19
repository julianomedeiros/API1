using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Com_Swagger.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("idCliente")]
        public Int32 IdCliente { get; set; }

        [Column("nome")]
        public String NomeCliente { get; set; }

        [Column("idade")]
        public Int32 Idade { get; set; }

        [Column("IdContaBancaria")]
        public Int32 IdContaBancaria { get; set; }  


    }
}
