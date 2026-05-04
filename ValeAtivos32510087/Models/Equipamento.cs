using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ValeAtivos32510087.Models
{
    public class Equipamento
    {
        [Key]
        public int Id { get; set; } //Identificador único do ativo
        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        public string Nome { get; set; } = string.Empty; //Nome da unidade ou máquina (ex: Carregador de Navios CN-01, Escavadeira CAT-7495).
        public string Tipo { get; set; } = string.Empty; //Categoria do ativo (ex: Mina, Ferrovia, Porto, Usina).
        public string Localizacao { get; set; } = string.Empty; //Complexo minerador ou terminal logístico (ex: Carjás, Itabira, Porto de Tubarão).
        public double CapacidadeProcessamento { get; set; } //Capacidade diária em toneladas (tpd).
        public DateTime DataUltimaManutencao { get; set; } = DateTime.UtcNow; //Data em que ocorreu a última intervenção técnica.
        public bool EmOperacao { get; set; } //Indica se o equipamento está operante ou parado para reparo.
    }
}