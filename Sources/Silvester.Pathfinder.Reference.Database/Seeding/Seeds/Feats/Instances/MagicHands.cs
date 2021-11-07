using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicHands : Template
    {
        public static readonly Guid ID = Guid.Parse("f0fff397-25ff-4350-86b3-1cc1ba429feb");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Hands",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d9b57a5a-23d9-407e-a50a-665258a0709c"), Type = TextBlockType.Text, Text = "The blessing of your deity heightens your healing ability, making your mundane healing work as if by magic. When you succeed at a Medicine check to (action: Treat Wounds), your action gains the divine trait and you heal the maximum amount for the 2d8 (or 4d8 on a critical success). If you have an ability that adds additional dice to your (action: Treat Wounds), you still roll those normally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("207ebb4d-7901-470d-8834-4189f5cfe856"), Feats.Instances.HealingHands.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0ac5c30-26b7-4422-81df-fbd7d7b0a34d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
