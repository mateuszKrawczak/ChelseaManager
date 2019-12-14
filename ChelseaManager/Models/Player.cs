using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChelseaManager.Models
{
    //tabela zawodnik
    class Player
    {
        [Key]
        [DisplayName("Number")]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(250)]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        public int PositionID { get; set; }
        [ForeignKey("PositionID")]
        public virtual Position Position { get; set; }


        [DisplayName("Birthdate")]
        public DateTime Birthdate { get; set; }
        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country Country { get; set; }

        [DisplayName("Number")]
        public int Number { get; set; }


    }
}
