using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeyCantrips : Template
    {
        public static readonly Guid ID = Guid.Parse("f1da18ec-5cec-4f21-bbfd-4fa49f2bbd8f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Cantrips",
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
            yield return new TextBlock { Id = Guid.Parse("89524ee8-223c-4a31-98f2-6dd5cccab1b2"), Type = TextBlockType.Text, Text = "You’ve learned the cantrips sprites have used since time immemorial. You gain (spell: dancing lights) and (spell: ghost sound) as primal innate cantrips. If you have the grig heritage, you also gain (spell: detect magic), and if you have the draxie heritage, you gain (spell: prestidigitation)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d09d52df-9cf7-4876-9a59-6770f1980ca8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
