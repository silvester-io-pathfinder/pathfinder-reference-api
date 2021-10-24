using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances
{
    public class CoverTracks : Template
    {
        public static readonly Guid ID = Guid.Parse("c0be71d6-d092-46e1-8f1c-5c59165f0df8");

        protected override SkillAction GetSkillAction()
        {
            return new SkillAction
            {
                Id = ID,
                Name = "Cover Tracks",
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                RequiredProficiencyId = Proficiencies.Instances.Trained.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7b58fb8f-e23a-463b-b2fd-df87dbc3e1b5"), Type = TextBlockType.Text, Text = "You cover your tracks, moving up to half your travel Speed, using the rules on page 479. You don�t need to attempt a Survival check to cover your tracks, but anyone tracking you must succeed at a Survival check against your Survival DC if it is higher than the normal DC to Track." };
            yield return new TextBlock { Id = Guid.Parse("5fb26197-81cb-4c04-b3b1-1c34818c3ac9"), Type = TextBlockType.Text, Text = "In some cases, you might Cover Tracks in an encounter. In this case, Cover Tracks is a single action and doesn�t have the exploration trait." };
        }

        protected override IEnumerable<Guid> GetApplicableSkills()
        {
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Concentrate.ID;
            yield return Traits.Instances.Exploration.ID;
            yield return Traits.Instances.Move.ID;
        }

        protected override IEnumerable<Guid> GetRequiredPlayModes()
        {
            yield return PlayModes.Instances.Exploration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("957253f6-8a5d-4a2c-abe3-f088bc99f0a5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 252
            };
        }
    }
}
