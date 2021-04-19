using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class BloodthirstyUrge : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("db3fa1f2-4ecb-4bac-96bd-126552730b27");

        protected override Hazard GetHazard(HazardSeeder seeder)
        {
            return new Hazard
            {
                Id = ID,
                Name = "Bloodthirstt Urge",
                Description = "An object haunted by the echoes of a vicious mind attempts to kill someone who comes near.",
                Level = 10,
                CanBeDetectedMagically = false,
                TypeId = seeder.GetHazardTypeByName("Haunts").Id,
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
            yield return "Haunt";
        }

        protected override IEnumerable<HazardAction> GetActions(HazardSeeder seeder)
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("68d1d3fe-bca2-4a85-864c-1359f24d5dbc"),
                Name = "Quietus",
                Traits = seeder.FilterTraits("Death", "Emotion", "Fear", "Illusion", "Mental", "Occult"),
                Trigger = "A creature moves within 10 feet of the haunted object",
                ActionTypeId = seeder.GetActionTypeByName("Reaction").Id,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("2ac0be1a-c1b5-4269-bbac-40a7665853c4"), Type = TextBlockType.Text, Text = "The haunt takes control of the triggering creature, forcing it to attack itself. The creature must attempt a DC 29 Will save." },
                },
                Effects =
                {
                    new RollableHazzardActionEffect
                    {
                        Id = Guid.Parse("10d818d2-a2cc-478f-99f4-50f491710d8a"),
                        CriticalSuccess = "The target is unaffected.",
                        Success = "The target makes a Strike against itself and automatically hits; the target also becomes frightened 1.",
                        Failure = "The target makes a Strike against itself and automatically scores a critical hit; the target also becomes frightened 2.",
                        CriticalFailure = "The target attempts a Fortitude save. If the target succeeds, it is subject to the effects of a failure instead. If the target fails, it is reduced to 0 Hit Points and dies."
                    }
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement(HazardSeeder seeder)
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("7b0c9a23-dce1-484f-acf2-d9fb81c462c2"),
                RequiredProficiencyId = seeder.GetProficiencyByName("Trained").Id,
                DifficultyCheck = 31
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements(HazardSeeder seeder)
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("f19169b1-e3a2-4623-9013-bfb8d2736376"),
                SkillId = seeder.GetSkillByName("Religion").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Master").Id,
                Description = "to exorcise the spirit",
                DifficultyCheck = 29
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("6e779010-cc5a-46e2-92c9-318f82bb524b"),
                SkillId = seeder.GetSkillByName("Diplomacy").Id,
                RequiredProficiencyId = seeder.GetProficiencyByName("Expert").Id,
                Description = "to talk it down",
                DifficultyCheck = 31
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements(HazardSeeder seeder)
        {
            yield break;
        }

        protected override SourcePage GetSourcePage(HazardSeeder seeder)
        {
            return new SourcePage
            {
                Id = Guid.Parse("0a8c30a8-ccbe-4e93-9e9e-fa12cc3f6c1f"),
                SourceId = CoreRulebook.ID,
                Page = 524
            };
        }
    }
}
