using System;
using System.Collections.Generic;

#nullable disable

namespace GenshinWebApp.Models
{
    public partial class AbilityDamage
    {
        public int AbilityDamageId { get; set; }
        public int? AbilityId { get; set; }
        public int? AbilityDamageInstanceId { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual AbilityDamageInstance AbilityDamageInstance { get; set; }
    }
}
