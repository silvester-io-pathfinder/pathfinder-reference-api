using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class TreatPoison : Template
    {
        public static readonly Guid ID = Guid.Parse("0d6f5a5b-7e96-43b4-ae72-544e0986d9f1");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Treat Poison",
                Requirements = "You�re wearing or holding healer�s tools (page 290).",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bfda12f5-1b68-49a2-aac5-2d66337938ba"), Type = TextBlockType.Text, Text = "You treat a patient to prevent the spread of poison. Attempt a Medicine check against the poison�s DC. After you attempt to Treat a Poison for a creature, you can�t try again until after the next time that creature attempts a save against the poison." };
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
                Id = Guid.Parse("d9b2338d-412f-431c-a4fd-ef355c66d054"),
                CriticalSuccess = "You grant the creature a +4 circumstance bonus to its next saving throw against the poison.",
                Success = "You grant the creature a +2 circumstance bonus to its next saving throw against the poison.",
                CriticalFailure = "Your efforts cause the creature to take a �2 circumstance penalty to its next save against the poison."
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
                Id = Guid.Parse("1c2ef6ee-7105-4e55-86d6-98619a8e49af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 248
            };
        }
    }
}
