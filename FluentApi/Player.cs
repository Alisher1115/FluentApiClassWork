using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    [Table("sports_players")]
    public class Player
    {
        [Column("ID")]
        [Required]
        [Key]
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Минимальная длина строки 3 символа.")]
        public string FullName { get; set; }

        [Display(Name = "Номер игрока на футболке.")]
        public int Number { get; set; }

        //[NotMapped]
        public virtual Team Team { get; set; }

        [Column("TeamId")]
        [ForeignKey("Team")]
        public int TeamId { get; set; }
    }
}
