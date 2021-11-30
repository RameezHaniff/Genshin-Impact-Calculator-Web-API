using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinWebApp.Models
{
    [Table("ability_scaling_value")]
    public class AbilityScalingValue
    {
        [Key]
        [Column("scaling_id")]
        public int ScalingId { get; set; }

        [Column("scaling",TypeName = "jsonb")]
        public Scaling Scaling { get; set; }
    }

    public class Scaling { 
    
        public Level Level1 { get; set; }
        public Level Level2 { get; set; }
        public Level Level3 { get; set; }
        public Level Level4 { get; set; }
        public Level Level5 { get; set; }
        public Level Level6 { get; set; }
        public Level Level7 { get; set; }
        public Level Level8 { get; set; }
        public Level Level9 { get; set; }
        public Level Level10 { get; set; }
        public Level Level11 { get; set; }
        public Level Level12 { get; set; }
        public Level Level13 { get; set; }
        public Level Level14 { get; set; }
        public Level Level15 { get; set; }
        
        public string DamageType { get; set; }

    }

    public class Level
    {
        public decimal MainSkillDamage { get; set; }

        public decimal SubSkillDamage { get; set; }

    }

}
