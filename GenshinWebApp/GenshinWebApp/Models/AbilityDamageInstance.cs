using System;
using System.Collections.Generic;

#nullable disable

namespace GenshinWebApp.Models
{
    public partial class AbilityDamageInstance
    {
        public int AbilityDamageInstanceId { get; set; }
        public string DamageInstanceName { get; set; }
        public int ScalingId { get; set; }

        public virtual AbilityScalingValue Scaling { get; set; }
    }
}
