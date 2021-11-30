using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinWebApp.Models.Responses
{
    public class CharacterResponse
    {
        public List<Skills> Skills;

    }

    public class Skills
    {
        public Ability Ability;

        public List<DamageInstance> DamageInstances;
    }

    public class DamageInstance
    {
        public string DamageInstanceName;

        public Level DamageValues;

        public string DamageType;
    }

    public class CharacterInfo
    {
        public string CharacterName;

        public string CharacterRarity;

        public string CharacterWeapon;

        public string CharacterElement;
    }


}
