using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AzarketiPurification : Template
    {
        public static readonly Guid ID = Guid.Parse("ae98f411-c766-45a5-9dc6-953a800df150");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azarketi Purification",
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
            yield return new TextBlock { Id = Guid.Parse("72a57631-45f1-40fa-b118-c663a2bd0c7b"), Type = TextBlockType.Text, Text = "You can cast (spell: purify food and drink) as a primal innate spell, but only on liquids. You can cast this spell once every 10 minutes. You can also use your innate (spell: purify food and drink) on a touched creature instead of a liquid to purify their blood, giving that creature a +2 status bonus for 1 minute on their ongoing saves against poisons already present in their body when you cast the spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d4b0814-e113-4691-af20-6a836f141495"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
