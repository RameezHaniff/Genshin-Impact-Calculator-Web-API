using GenshinWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using GenshinWebApp.Models.DTO;
using GenshinWebApp.Models.Responses;

namespace GenshinWebApp.Controllers
{
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private readonly GenshinImpactContext _context;

        public CharacterController(GenshinImpactContext context)
        {
            _context = context;
        }

        [HttpGet("{charId}")]
        public ActionResult<CharacterInfo> Get( int charId)
        {
            var charName = _context.Characters.Where(x => x.CharacterId == charId).Select(x => x.CharacterName).FirstOrDefault();
            var charElement = _context.Characters.Where(x => x.CharacterId == charId).Select(x => x.Element.ElementName).FirstOrDefault();
            var charRarity = _context.Characters.Where(x => x.CharacterId == charId).Select(x => x.Rarity.RarityName).FirstOrDefault();
            var charWeapon = _context.Characters.Where(x => x.CharacterId == charId).Select(x => x.WeaponType.WeaponTypeName).FirstOrDefault();

            var characterInfo = new CharacterInfo { CharacterName = charName, CharacterElement = charElement, CharacterRarity = charRarity, CharacterWeapon = charWeapon };
            return characterInfo;

        }

        [HttpPost]
        public ActionResult<CharacterResponse> GetData([FromBody] CharDataRequest charData)
        {
            var charAbilities = _context.CharacterAbilities.Include(character => character.Character).Include(ability => ability.Ability).Where(x => x.CharacterId == charData.CharacterId).Select(x => x.AbilityId);
            var abilityList  = charAbilities.ToList();

            var skill1 = abilityList[0];
            var skill2 = abilityList[1];
            var skill3 = abilityList[2];

            var skill1scaling = _context.AbilityDamages.Include(x => x.Ability).Include(x => x.AbilityDamageInstance).Include(x => x.AbilityDamageInstance.Scaling).Where(x => x.AbilityId == skill1);
            var skill2scaling = _context.AbilityDamages.Include(x => x.Ability).Include(x => x.AbilityDamageInstance).Include(x => x.AbilityDamageInstance.Scaling).Where(x => x.AbilityId == skill2);
            var skill3scaling = _context.AbilityDamages.Include(x => x.Ability).Include(x => x.AbilityDamageInstance).Include(x => x.AbilityDamageInstance.Scaling).Where(x => x.AbilityId == skill3);

            var ability1 = skill1scaling.Select(x => new DamageInstance
            {   DamageInstanceName = x.AbilityDamageInstance.DamageInstanceName,
                DamageValues = Filter(x.AbilityDamageInstance.Scaling, charData.NormalAttackLevel),
                DamageType = x.AbilityDamageInstance.Scaling.Scaling.DamageType
            }).ToList();

            var ability2 = skill2scaling.Select(x => new DamageInstance
            {
                DamageInstanceName = x.AbilityDamageInstance.DamageInstanceName,
                DamageValues = Filter(x.AbilityDamageInstance.Scaling, charData.elementalSkillLevel),
                DamageType = x.AbilityDamageInstance.Scaling.Scaling.DamageType

            }).ToList();

            var ability3 = skill3scaling.Select(x => new DamageInstance
            {
                DamageInstanceName = x.AbilityDamageInstance.DamageInstanceName,
                DamageValues = Filter(x.AbilityDamageInstance.Scaling, charData.elementalBurstLevel),
                DamageType = x.AbilityDamageInstance.Scaling.Scaling.DamageType

            }).ToList();

            CharacterResponse characterResponse = new CharacterResponse
            {
                Skills = new List<Skills>() {
                    new Skills { Ability = skill1scaling.FirstOrDefault().Ability, DamageInstances = ability1 },
                    new Skills { Ability = skill2scaling.FirstOrDefault().Ability, DamageInstances = ability2 },
                    new Skills { Ability = skill3scaling.FirstOrDefault().Ability, DamageInstances = ability3 } 
                }
            };

            return characterResponse;
        }
        private static Level Filter(AbilityScalingValue abilityScalings, int index)
        {
            switch (index)
            {
                case 1: return abilityScalings.Scaling.Level1;
                case 2: return abilityScalings.Scaling.Level2;
                case 3: return abilityScalings.Scaling.Level3;
                case 4: return abilityScalings.Scaling.Level4;
                case 5: return abilityScalings.Scaling.Level5;
                case 6: return abilityScalings.Scaling.Level6;
                case 7: return abilityScalings.Scaling.Level7;
                case 8: return abilityScalings.Scaling.Level8;
                case 9: return abilityScalings.Scaling.Level9;
                case 10: return abilityScalings.Scaling.Level10;
                case 11: return abilityScalings.Scaling.Level11;
                case 12: return abilityScalings.Scaling.Level12;
                case 13: return abilityScalings.Scaling.Level13;
                case 14: return abilityScalings.Scaling.Level14;
                case 15: return abilityScalings.Scaling.Level15;
                default: return new Level { };
            }
        }
    }
}

