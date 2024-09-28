using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models;

public class News
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Título")]
    public string Title { get; set; }
    [Required]
    [DisplayName("Descrição")]
    public string Description { get; set; }
    [Required]
    [DisplayName("Mensagem")]
    public string Mensagem { get; set; }
    public DateTime DatePost { get; set; }
    [DisplayName("Imagem")]
    public string? PathImage { get; set; }
}
