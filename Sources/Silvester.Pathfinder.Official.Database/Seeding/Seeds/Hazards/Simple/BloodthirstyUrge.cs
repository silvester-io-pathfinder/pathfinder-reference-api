using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class BloodthirstyUrge : AbstractHazardTemplate
    {
        public static readonly Guid ID = Guid.Parse("db3fa1f2-4ecb-4bac-96bd-126552730b27");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Bloodthirstt Urge",
                Description = "An object haunted by the echoes of a vicious mind attempts to kill someone who comes near.",
                Level = 10,
                CanBeDetectedMagically = false,
                TypeId = HazardTypes.Instances.Haunts.ID,
                ComplexityId = HazardComplexities.Instances.Simple.ID
            };
        }

        protected override IEnumerable<HazardComponent> GetComponents()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetImmunities()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Haunt.ID;
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("68d1d3fe-bca2-4a85-864c-1359f24d5dbc"),
                Name = "Quietus",
                Traits = FilterTraits("Death", "Emotion", "Fear", "Illusion", "Mental", "Occult"),
                Trigger = "A creature moves within 10 feet of the haunted object",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
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

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("7b0c9a23-dce1-484f-acf2-d9fb81c462c2"),
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID,
                DifficultyCheck = 31
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("f19169b1-e3a2-4623-9013-bfb8d2736376"),
                SkillId = Skills.Instances.Religion.ID,
                RequiredProficiencyId = Proficiencies.Instances.Master.ID,
                Description = "to exorcise the spirit",
                DifficultyCheck = 29
            };

            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("6e779010-cc5a-46e2-92c9-318f82bb524b"),
                SkillId = Skills.Instances.Diplomacy.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "to talk it down",
                DifficultyCheck = 31
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield break;
        }

        protected override SourcePage GetSourcePage()
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
