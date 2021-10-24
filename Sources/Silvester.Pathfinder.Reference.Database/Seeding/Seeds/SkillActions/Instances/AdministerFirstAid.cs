using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class AdministerFirstAid : Template
    {
        public static readonly Guid ID = Guid.Parse("38a9d68d-888d-4b15-8353-97ca8915383e");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Administer First Aid",
                Requirements = "You�re wearing or holding healer�s tools (page 290).",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                RequiredProficiencyId = Proficiencies.Instances.Untrained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ef084ad4-a7a5-443e-b902-dba3c625ab5b"), Type = TextBlockType.Text, Text = "You perform first aid on an adjacent creature that is dying or bleeding. If a creature is both dying and bleeding, choose which ailment you�re trying to treat before you roll. You can Administer First Aid again to attempt to remedy the other effect." };
            yield return new TextBlock { Id = Guid.Parse("264adad3-c61b-44bb-a99d-75e2026a1421"), Type = TextBlockType.Enumeration, Text = "Stabilize - Attempt a Medicine check on a creature that has 0 Hit Points and the dying condition. The DC is equal to 5 + that creature�s recovery roll DC (typically 15 + its dying value)." };
            yield return new TextBlock { Id = Guid.Parse("c9664356-8e97-4ca7-806b-47709a21afb6"), Type = TextBlockType.Enumeration, Text = "Stop Bleeding - Attempt a Medicine check on a creature that is taking persistent bleed damage (page 452), giving them a chance to make another flat check to remove the persistent damage. The DC is usually the DC of the effect that caused the bleed." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Manipulate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("76b65be7-95e9-4cef-b770-e22f10110928"),
                Success = "If you�re trying to stabilize, the creature loses the dying condition (but remains unconscious). If you�re trying to stop bleeding, the creature attempts a flat check to end the bleeding.",
                CriticalFailure = "If you were trying to stabilize, the creature�s dying value increases by 1. If you were trying to stop bleeding, it immediately takes an amount of damage equal to its persistent bleed damage."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Encounter.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f23362d0-7791-449f-9974-bf0872bf5627"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 248
            };
        }
    }
}
