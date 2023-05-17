using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Notifications;

namespace Entidades.Entidades
{
    [Table("cities")]
    public class City : Notify
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("city_name")]
        [MaxLength(255)]
        public string CityName { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("states")]
        [Column(Order = 1)]
        public string StateId { get; set; }
        public virtual State State { get; set; }
    }
}
