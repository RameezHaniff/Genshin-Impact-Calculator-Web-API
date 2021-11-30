using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinWebApp.Models.DTO
{
    public class CharDataRequest
    {
        public int CharacterId { get; set; }
        public int NormalAttackLevel { get; set; }
        public int elementalSkillLevel { get; set; }
        public int elementalBurstLevel { get; set; }

    }
}
