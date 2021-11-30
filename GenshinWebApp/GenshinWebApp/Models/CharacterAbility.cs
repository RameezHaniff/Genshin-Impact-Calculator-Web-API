using System;
using System.Collections.Generic;

#nullable disable

namespace GenshinWebApp.Models
{
    public partial class CharacterAbility
    {
        public int CharacterAbilityId { get; set; }
        public int? AbilityId { get; set; }
        public int? CharacterId { get; set; }

        public virtual Ability Ability { get; set; }
        public virtual Character Character { get; set; }
    }
}
