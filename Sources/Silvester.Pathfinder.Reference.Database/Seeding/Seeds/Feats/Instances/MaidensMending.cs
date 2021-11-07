using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MaidensMending : Template
    {
        public static readonly Guid ID = Guid.Parse("5cf97ac1-0d01-4d8e-9efb-eb986c95510b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Maiden's Mending",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You cast a non-cantrip occult spell or an innate spell from a changeling ancestry feat.",
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("880e80f9-4b5e-45fa-8efd-211312c236eb"), Type = TextBlockType.Text, Text = "You can tap into some of the magic that flows through your blood to give you new life. You gain a number of temporary Hit Points equal to half your level (minimum 1) that last until the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f0a2c537-d8d2-4594-8009-31eae6864499"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
