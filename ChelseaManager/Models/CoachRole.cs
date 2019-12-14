using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChelseaManager.Models
{
    //tabela rodzaj pracownika
    class CoachRole
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Role")]
        [Required]
        public string Role { get; set; }

        public virtual List<Coach> Coach { get; set; }//wykorzystywane bo tworzymy relacje jeden do wielu, skoczek do kraju przydzielony a kraj moze miec wiecej niz jednego 


    }
}
