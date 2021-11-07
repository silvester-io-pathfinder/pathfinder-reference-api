using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CatfolkLore : Template
    {
        public static readonly Guid ID = Guid.Parse("84c1ae12-1726-48e5-a69a-e76d074d53ad");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Catfolk Lore",
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
            yield return new TextBlock { Id = Guid.Parse("e29c22f7-f959-4538-8d60-e53f51be7182"), Type = TextBlockType.Text, Text = "Growing up among catfolk has taught you the traditional values of freedom to travel, stewardship of the land, and quick reactions when your curiosity lands you in trouble. You gain the trained proficiency rank in Acrobatics and Survival. If you would automatically become trained in one of those skills (from your background or class, for example), you instead become trained in a skill of your choice. You also become trained in Catfolk Lore." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b1e435bc-efbf-4c22-be3a-689ee540254f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
