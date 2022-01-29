using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class TreatDisease : Template
    {
        public static readonly Guid ID = Guid.Parse("7ebc7ad5-eea7-446f-8325-bacadaebcaff");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Treat Disease",
                Requirements = "you're wearing or holding healer's tools (page 290).",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("503846d7-e5ba-4c19-9f33-8dd3d0b6de79"), Type = TextBlockType.Text, Text = "You spend at least 8 hours caring for a diseased creature. Attempt a Medicine check against the disease's DC. After you attempt to Treat a Disease for a creature, you can't try again until after that creature's next save against the disease." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Downtime.ID;
            yield return Traits.Instances.Manipulate.ID;
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("eb7aef2c-acbe-46ce-9175-e71985f61053"),
                CriticalSuccess = "You grant the creature a +4 circumstance bonus to its next saving throw against the disease.",
                Success = "You grant the creature a +2 circumstance bonus to its next saving throw against the disease.",
                CriticalFailure = "Your efforts cause the creature to take a -2 circumstance penalty to its next save against the disease."
            };
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Downtime.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d893350f-b512-471f-a268-8a8d96e1852a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 248
            };
        }
    }
}
