using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Hazards.Simple
{
    public class SecondChance : Template
    {
        public static readonly Guid ID = Guid.Parse("c235d758-9aa7-42fe-93e0-c5ec36092fc4");

        protected override Hazard GetHazard()
        {
            return new Hazard
            {
                Id = ID,
                Name = "Second Chance",
                Description = "Powerful warding magic tied to an object or location tries to regress the ages of a creature and its allies.",
                Level = 21,
                CanBeDetectedMagically = false,
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
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Trap.ID;
        }

        protected override IEnumerable<HazardAction> GetActions()
        {
            yield return new HazardAction
            {
                Id = Guid.Parse("28f30837-d2d0-459a-bcf2-49afac323a2e"),
                Name = "In the Beginning",
                Traits = FilterTraits("Divine", "Transmutation"),
                Trigger = "A creature tries to steal the object or intrude upon the location. If someone uses a proxy or dupe for the theft or intrusion, the trap unerringly targets the true perpetrator or perpetrators at any distance—even across planes",
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                Details = new List<TextBlock>
                {
                    new TextBlock { Id = Guid.Parse("87bdb9c5-4d60-4e50-938d-4bd6467d5e62"), Type = TextBlockType.Text, Text = "The triggering creature and up to five coconspirators instantly revert to infants, losing all memories, class abilities, and other skills acquired during their lives (DC 44 Fortitude negates). Reversing this effect is nearly impossible, requiring powerful magic such as wish." },
                }
            };
        }

        protected override HazardDetectionRequirement GetDetectionRequirement()
        {
            return new HazardDetectionRequirement
            {
                Id = Guid.Parse("78281610-b064-475a-b32a-7022ae63a45e"),
                RequiredProficiencyId = Proficiencies.Instances.Legendary.ID,
                DifficultyCheck = 44
            };
        }

        protected override IEnumerable<HazardDisableRequirement> GetDisableRequirements()
        {
            yield return new HazardDisableRequirement
            {
                Id = Guid.Parse("0fb1e6a3-00c7-4a77-bad1-949bac1cd5a1"),
                SkillId = Skills.Instances.Thievery.ID,
                RequiredProficiencyId = Proficiencies.Instances.Legendary.ID,
                Description = "To take apart the spell one tiny piece at a time, with eyes closed, while recalling every vivid life memory in order, starting from the earliest memory.",
                DifficultyCheck = 46
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
                Id = Guid.Parse("3aa273d4-ad98-4e64-8ea1-cad0af832e27"),
                SourceId = CoreRulebook.ID,
                Page = 525
            };
        }
    }
}
