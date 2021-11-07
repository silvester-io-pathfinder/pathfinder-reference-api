using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cindersoul : Template
    {
        public static readonly Guid ID = Guid.Parse("084c6ad1-a34f-4edf-bbac-52eb9ed161f2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cindersoul",
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
            yield return new TextBlock { Id = Guid.Parse("3441a42d-4210-4da8-bd58-062361c9e218"), Type = TextBlockType.Text, Text = "The fire of your elemental ancestor manifests like dying embers of a blaze, and your inner charcoal helps staunch bleeding, purify simple poisons, and absorb acid. The DC for you to recover from persistent acid, bleed, and poison damage is 10 instead of 15 (or 5 if you have particularly effective assistance)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32cfd74f-3249-43a9-b365-a4c8b6cafe5f"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
