using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinWebApp.Models.DTO
{
    public class CharacterScaling
    {
        public string CharacterName { get; set; }
        public int CharacterId { get; set; }
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
        public string DamageInstanceName { get; set; }
        public string AbilityName { get; set; }
        public int Cooldown { get; set; }
        public int EnergyCost { get; set; }
    }
}
