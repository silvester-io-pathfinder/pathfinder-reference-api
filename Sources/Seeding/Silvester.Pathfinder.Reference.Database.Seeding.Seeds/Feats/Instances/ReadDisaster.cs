using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReadDisaster : Template
    {
        public static readonly Guid ID = Guid.Parse("d8e8d2c4-7d94-4d88-89a4-34ec51205b62");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Read Disaster",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("749aa4ff-fd1e-4a55-a498-75122143e3fe"), Type = TextBlockType.Text, Text = $"You spend 10 minutes and open yourself to the divine mysteries of the world, peering into the most sinister portents of the future. You gain the effects of {ToMarkdownLink<Models.Entities.Spell>("augury", Spells.Instances.Augury.ID)}, except you learn only about the dangers ahead; any results of “weal” are instead “nothing,” and results of “weal and woe” are instead “woe.” If you are legendary in Religion, you take only 1 minute to Read Disaster." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e6b0a91-d39d-47e4-baa1-7fe7882a4bae"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
