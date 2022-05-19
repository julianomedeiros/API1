using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Com_Swagger.Models
{
    [Table("idHistorico")]
    public class Historico
    {
        [Key]
        [Column("idHistorico")]
        public Int32 IdHistorico { get; set; }

        [Column("IdContaBancaria")]
        public Int32 IdContaBancaria { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("valorMovimentacao")]
        public float ValorMovimentacao { get; set; }

        [Column("valorFinal")]
        public float valorFinal{ get; set; }


    }
}
