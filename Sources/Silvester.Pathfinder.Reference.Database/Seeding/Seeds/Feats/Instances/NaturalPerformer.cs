using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NaturalPerformer : Template
    {
        public static readonly Guid ID = Guid.Parse("1a8dbbcf-1631-4ff5-81d9-92cc567577b7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Natural Performer",
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
            yield return new TextBlock { Id = Guid.Parse("54fd8c0d-d247-45ad-abc4-193a793b5dbc"), Type = TextBlockType.Text, Text = "Entertainment comes naturally to you. You become trained in Performance and gain one 1st-level Performance skill feat." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a04c2a18-251d-4b35-b9b5-5dc6eb459e80"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
