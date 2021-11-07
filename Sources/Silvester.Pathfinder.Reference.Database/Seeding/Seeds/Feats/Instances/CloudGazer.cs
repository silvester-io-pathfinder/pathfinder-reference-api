using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CloudGazer : Template
    {
        public static readonly Guid ID = Guid.Parse("a911d57b-a323-491e-a141-3326dc2b60e1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cloud Gazer",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("29a3c804-de51-4e8a-9ca8-07d5f9a218c5"), Type = TextBlockType.Text, Text = "Your connection to air allows you to see through obscuring mists. You can see well enough through fog, mist, and clouds that would normally cause creatures to be concealed that you don’t need to succeed at a flat check to target creatures benefiting from such concealment." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("313c52b6-e4ce-4d58-b58a-816f7d49c801"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
