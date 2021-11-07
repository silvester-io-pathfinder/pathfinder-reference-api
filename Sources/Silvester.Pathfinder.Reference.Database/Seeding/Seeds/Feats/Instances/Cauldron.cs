using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Cauldron : Template
    {
        public static readonly Guid ID = Guid.Parse("4db4e2d4-73ee-40f0-ba25-291387e33a65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cauldron",
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
            yield return new TextBlock { Id = Guid.Parse("1b465249-676b-4b32-bf9e-f76498c8683d"), Type = TextBlockType.Text, Text = "You can use the (action: Craft) activity to create oils and potions. You immediately gain the formulas for four common 1st-level oils or potions. At 4th level and every 2 levels beyond that, you gain the formula for a common oil or potion of that level or lower (a 4th-level potion if you’re 4th level, a 6th-level potion if you’re 6th level, and so on). If you have a familiar, you can have your familiar learn these formulas rather than storing them in a (item: formula book). Your familiar can learn new formulas in the same way it learns new spells, and these formulas are transferred from a slain familiar to a new familiar in the same way spells are." };
            yield return new TextBlock { Id = Guid.Parse("08a78e53-6b93-49fb-bd02-bede46d248dc"), Type = TextBlockType.Text, Text = "You can brew a great deal of magic within your cauldron. When you (action: Craft) a batch of oils or potions, you can make up to six in a batch instead of the usual four per batch." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2721dc21-d23a-4c77-a2cd-18a9d36dcd4a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
