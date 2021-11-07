using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CoatingOfSlime : Template
    {
        public static readonly Guid ID = Guid.Parse("3517777b-0199-4425-8b82-990a162dba9f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Coating of Slime",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6375a26d-c698-4b47-bc2f-90c9bb9c5e71"), Type = TextBlockType.Text, Text = "An acidic ooze coats your limbs. Your unarmed attacks deal an additional 1d4 persistent acid damage on a critical hit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab0bcd11-44e4-4116-b7f8-7e0b15168734"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
