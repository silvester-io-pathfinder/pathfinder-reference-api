using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnfetteredHalfling : Template
    {
        public static readonly Guid ID = Guid.Parse("2a8b2f60-08bc-4444-a208-64204a748869");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unfettered Halfling",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3d1ec5f-635e-4753-816c-5c39a53a0ec5"), Type = TextBlockType.Text, Text = "You were forced into service as a laborer, either pressed into indentured servitude or shackled by the evils of slavery, but you’ve since escaped and have trained to ensure you’ll never be caught again. Whenever you roll a success on a check to (Action: Escape) or a saving throw against an effect that would impose the grabbed or restrained condition on you, you get a critical success instead. Whenever a creature rolls a failure on a check to (Action: Grapple) you, they get a critical failure instead. If a creature uses the Grab ability on you, it must succeed at an Athletics check to grab you instead of automatically grabbing you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("561b645b-22e2-45d6-a8dd-b672f9dec433"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
