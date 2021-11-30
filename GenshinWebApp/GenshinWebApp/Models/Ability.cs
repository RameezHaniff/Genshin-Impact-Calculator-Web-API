using System;
using System.Collections.Generic;

#nullable disable

namespace GenshinWebApp.Models
{
    public partial class Ability
    {
        public string AbilityName { get; set; }
        public int AbilityId { get; set; }
        public int? Cooldown { get; set; }
        public int? EnergyCost { get; set; }
    }
}
