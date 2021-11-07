using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ButterflysKiss : Template
    {
        public static readonly Guid ID = Guid.Parse("9ac78927-6424-4a40-b68e-59c02477bafb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Butterfly's Kiss",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71157f72-3272-4eb2-bbdc-25074dc4f0ab"), Type = TextBlockType.Text, Text = "You can make nonlethal (action: Strikes | Strike) with a (item: butterfly sword) without taking a penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("203e30c5-35fb-4cc0-9974-c4edbb6beb7e"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
