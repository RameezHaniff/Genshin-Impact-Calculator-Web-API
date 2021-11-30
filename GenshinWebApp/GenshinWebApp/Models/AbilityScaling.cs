using System;
using System.Collections.Generic;

#nullable disable

namespace GenshinWebApp.Models
{
    public partial class AbilityScaling
    {
        //public AbilityScaling()
        //{
        //    AbilityDamageInstances = new HashSet<AbilityDamageInstance>();
        //}

        public int ScalingId { get; set; }
        public decimal Level1 { get; set; }
        public decimal Level2 { get; set; }
        public decimal Level3 { get; set; }
        public decimal Level4 { get; set; }
        public decimal Level5 { get; set; }
        public decimal Level6 { get; set; }
        public decimal Level7 { get; set; }
        public decimal Level8 { get; set; }
        public decimal Level9 { get; set; }
        public decimal Level10 { get; set; }
        public decimal Level11 { get; set; }
        public decimal Level12 { get; set; }
        public decimal Level13 { get; set; }
        public decimal Level14 { get; set; }
        public decimal Level15 { get; set; }

        public string DamageType { get; set; }

        //public virtual ICollection<AbilityDamageInstance> AbilityDamageInstances { get; set; }
    }
}
