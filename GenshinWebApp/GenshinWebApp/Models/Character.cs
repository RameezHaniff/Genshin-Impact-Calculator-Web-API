using System;
using System.Collections.Generic;

#nullable disable

namespace GenshinWebApp.Models
{
    public partial class Character
    {
        public string CharacterName { get; set; }
        public int CharacterId { get; set; }
        public int RarityId { get; set; }
        public int ElementId { get; set; }
        public int WeaponTypeId { get; set; }

        public virtual Element Element { get; set; }
        public virtual Rarity Rarity { get; set; }
        public virtual WeaponType WeaponType { get; set; }
    }
}
