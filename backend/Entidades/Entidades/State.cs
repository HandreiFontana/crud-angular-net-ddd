using Entidades.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [Table("states")]
    public class State : Notify
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("state_name")]
        [MaxLength(255)]
        public string StateName{ get; set; }

        [Column("federative_unit")]
        [MaxLength(255)]
        public string FederativeUnit { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
