using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace M1S09ExercicioSemana9.Models
{
    [Table("Semana")]
    public class SemanaModel
    {
        [Key]
        [Column("Código")]
        public int Id { get; set; }

        [NotNull]
        [Column("Data")]
        public DateTime DataSemana { get; set; }
        
        [MaxLength(100)]
        [Column("Conteúdo")]
        public string Conteudo { get; set; }

        [NotNull]
        [Column("Aplicado?")]
        public bool AplicadoConteudo { get; set; }
    }
}
