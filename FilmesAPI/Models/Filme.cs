using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obriatório.")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O gênero passou de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1,600, ErrorMessage = "A duração deve ser entre 0 e 600 minutos.")]
        public int Duracao { get; set; }
    }
}
