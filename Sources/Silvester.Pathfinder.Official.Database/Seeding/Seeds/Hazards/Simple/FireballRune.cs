using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class FireballRune : Template
    {
        public static readonly Guid ID = Guid.Parse("2418608e-7e98-4ea3-8a2a-4f2294cabf5c");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Fireball Rune",
                Description = "An invisible rune creates an invisible, spherical magical sensor with a 20 - foot radius.",
                Level = 5,
                CanBeDetectedMagically = true,
                TypeId = HazardTypes.Instances.Traps.ID,
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("c5259ba8-ad21-4900-bcbf-cf1196ef578a"),
                Name = "Fireball",
                Traits = FilterTraits("Arcane", "Evocation", "Fire"),
                Trigger = "A living creature enters the sensor area",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("a93c5058-494c-4df1-988e-f0dc6dee552c"), Type = TextBlockType.Text, Text = "The rune detonates a fireball centered on the triggering creature’s square. This is a 3rd level fireball spell that deals 6d6 fire damage (DC 22 basic Reflex save)." },
                },
                Effects =
                {
                    new SpellHazardActionEffect
                    {
                        Id = Guid.Parse("8ecd675c-8894-4b1d-9b07-393c54c68244"),
                        Damage = "6d6",
                        DifficultyCheck = 22,
                        DamageTypeId = DamageTypes.Instances.Fire.ID,
                        SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID
                    }
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("8ecd675c-8894-4b1d-9b07-393c54c68244"),
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                DifficultyCheck = 24
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("c1635247-d147-48f5-b285-85cf09e8e324"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Expert.ID,
                Description = "to erase the rune without triggering the sensor",
                DifficultyCheck = 22
            };
        }

        protected override IEnumerable<HazardDispellRequirement> GetDispellRequirements()
        {
            yield return new HazardDispellRequirement
            {
                Id = Guid.Parse("959242c8-27ee-40a6-a9aa-0c44518a4cbb"),
                Level = 3,
                Description = "to counteract the rune",
                CounteractDifficultyCheck = 20
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bdc2a5c0-085f-4294-aa84-72ad76fc0364"),
                SourceId = CoreRulebook.ID,
                Page = 524
            };
        }
    }
}
