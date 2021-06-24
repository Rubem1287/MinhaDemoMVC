using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O Campo Título é obrigatório.")]
        [StringLength(60,MinimumLength =3, ErrorMessage ="O Título precisa ter entre 3 a 60 caracteres.")]
        [Display(Name ="Título")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage ="Data em formato incorreto.")]
        [Required(ErrorMessage ="Campo data de Lançamento é obrigatório.")]
        [Display(Name ="Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w]*$", ErrorMessage ="Gênero em formato inválido.")]
        [StringLength(30,ErrorMessage ="Máximo de 30 caracteres."), Required(ErrorMessage ="O campo Gênero é requerido.")]
        [Display(Name ="Gênero")]
        public string Genero { get; set; }

        [Range(1,1000, ErrorMessage ="Valor de 1 a 1000 esperado.")]
        [Required(ErrorMessage ="Preencha o campo Valor")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage ="Preencha o campo Avaliação.")]
        [Display(Name ="Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage ="Somente números")]
        public int Avaliacao { get; set; }

    }
}
