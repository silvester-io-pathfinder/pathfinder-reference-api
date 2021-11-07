using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class StoneForm : Template
    {
        public static readonly Guid ID = Guid.Parse("0736dd25-e05c-4ca4-acf8-dbe18cf4f680");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stone Form",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7ab64afc-675a-40ee-9a26-92c51d5f0883"), Type = TextBlockType.Text, Text = "You can transform your body into a pure primal manifestation of earth, an elemental. Once per day, you can cast (spell: elemental form) as a 7th-level primal innate spell, but you can only choose the earth elemental form." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("448600b6-6533-4b9a-b69b-95a46fef7cdf"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
