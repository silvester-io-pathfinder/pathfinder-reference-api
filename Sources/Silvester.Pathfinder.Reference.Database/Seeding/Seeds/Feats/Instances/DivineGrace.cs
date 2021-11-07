using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DivineGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("f225bb1a-362a-4972-90f3-769d5d29910c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Divine Grace",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You attempt a save against a spell, before you roll.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("64a74480-1430-435f-96ce-94880e38a276"), Type = TextBlockType.Text, Text = "You call upon your deity’s grace, gaining a +2 circumstance bonus to the save." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8386c8b5-7021-4b89-b62d-45e0279475af"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
