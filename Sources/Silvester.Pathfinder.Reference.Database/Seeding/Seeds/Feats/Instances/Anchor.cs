using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Anchor : Template
    {
        public static readonly Guid ID = Guid.Parse("e5f13cc5-4e62-4786-be02-c997c3604934");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Anchor",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1ed314ac-7fe9-4aa9-8ddc-2d0ead9e3962"), Type = TextBlockType.Text, Text = "You send your roots deeper into the ground, making it harder for you to stumble. Until you move, you gain a +2 circumstance bonus to your Fortitude or Reflex DC against attempts to (action: Shove) or (action: Trip) you (or a +4 circumstance bonus if you’re a root leshy). This bonus also applies to saving throws against spells or effects that attempt to move you or knock you prone." };
            yield return new TextBlock { Id = Guid.Parse("03840fa1-62a3-46e0-af48-e4ee6d482559"), Type = TextBlockType.Text, Text = "If an effect forces you to move, you move only half the normal distance, as some of the effort goes to tearing out the roots. At the GM’s discretion, this ability might not work on ground that’s more resilient than stone, such as metal flooring or magically-reinforced masonry." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0445982-6a34-4b04-82c3-d9ccbdee114a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
