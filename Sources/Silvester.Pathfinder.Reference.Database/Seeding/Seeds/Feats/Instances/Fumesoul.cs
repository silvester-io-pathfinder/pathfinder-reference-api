using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Fumesoul : Template
    {
        public static readonly Guid ID = Guid.Parse("bfbde94e-416f-4897-80b0-dd0ce79a3986");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fumesoul",
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
            yield return new TextBlock { Id = Guid.Parse("0bcf5241-bca0-4e51-92a8-6edf43844f36"), Type = TextBlockType.Text, Text = "The air inside you asserts itself as a toxic miasma, inuring you to most poisons. You gain resistance to poison equal to half your level (minimum 1)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81c12f1d-0535-4e16-b4ba-553a52838520"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
