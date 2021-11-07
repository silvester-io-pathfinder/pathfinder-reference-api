using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DeadlyGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("934cabf7-b19d-41f2-a04c-837524d5f489");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadly Grace",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("185ab71c-c3d3-4cbe-93c1-bc4086c5b644"), Type = TextBlockType.Text, Text = "Your graceful attacks are especially powerful. When you score a critical hit with an (trait: agile) or (trait: finesse) melee weapon that has the (trait: deadly) trait, you double the number of dice from that trait. When you wield an (trait: agile) or (trait: finesse) melee weapon that doesn’t have the (trait: deadly) trait, it gains the (trait: deadly d8) trait instead." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ea74871-3e04-4c6c-8a1c-d09830ea0075"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
