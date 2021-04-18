using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class FireballRune : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("2418608e-7e98-4ea3-8a2a-4f2294cabf5c");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Fireball Rune",
                Description = "An invisible rune creates an invisible, spherical magical sensor with a 20 - foot radius.",
                Level = 5,
                CanBeDetectedMagically = true,
                TypeId = seeder.GetHazardTypeByName("Traps").Id,
                ComplexityId = seeder.GetComplexityByName("Simple").Id
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents(HazardSeeder seeder)
        {
            yield break;
        }

        protected override IEnumerable<string> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<string> GetTraits()
        {
            yield return "Evocation";
            yield return "Fire";
            yield return "Magical";
            yield return "Trap";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("c5259ba8-ad21-4900-bcbf-cf1196ef578a"),
                Name = "Fireball",
                Traits = seeder.FilterTraits("Arcane", "Evocation", "Fire"),
                Trigger = "A living creature enters the sensor area",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                EffectDetails = new List<HazardActionEffectBlock>
                {
                    new HazardActionEffectBlock { Id = Guid.Parse("a93c5058-494c-4df1-988e-f0dc6dee552c"), Text = "The rune detonates a fireball centered on the triggering creature’s square. This is a 3rd level fireball spell that deals 6d6 fire damage (DC 22 basic Reflex save)." },
                },
                Effects =
                {
                    new SpellHazardActionEffect
                    {
                        Id = Guid.Parse("8ecd675c-8894-4b1d-9b07-393c54c68244"),
                        Damage = "6d6",
                        DifficultyCheck = 22,
                        DamageTypeId = seeder.GetDamageTypeByName("Fire").Id,
                        SavingThrowStatId = seeder.GetSavingThrowStatByName("Reflex").Id
                    }
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("8ecd675c-8894-4b1d-9b07-393c54c68244"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                DifficultyCheck = 24
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("c1635247-d147-48f5-b285-85cf09e8e324"),
                SkillId = seeder.GetSkillByName("Thievery").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                Description = "to erase the rune without triggering the sensor",
                DifficultyCheck = 22
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("959242c8-27ee-40a6-a9aa-0c44518a4cbb"),
                Level = 3,
                Description = "to counteract the rune",
                CounteractDifficultyCheck = 20
            };
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdc2a5c0-085f-4294-aa84-72ad76fc0364"),
                SourceId = seeder.GetSourceByName("Core Rulebook").Id,
                Page = 524
            };
        }
    }
}
