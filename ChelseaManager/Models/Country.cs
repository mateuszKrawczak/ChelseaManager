using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChelseaManager.Models
{
    //tabela kraj
    class Country
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Country")]
        [Required]
        public string Name { get; set; }
        public virtual List<Player> Player { get; set; }//wykorzystywane bo tworzymy relacje jeden do wielu, skoczek do kraju przydzielony a kraj moze miec wiecej niz jednego skoczka

        public virtual List<Coach> Coach { get; set; }//wykorzystywane bo tworzymy relacje jeden do wielu, skoczek do kraju przydzielony a kraj moze miec wiecej niz jednego skoczka


    }
}
