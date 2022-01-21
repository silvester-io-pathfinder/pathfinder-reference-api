using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GossipLore : Template
    {
        public static readonly Guid ID = Guid.Parse("3e698d9f-692c-460d-97d2-1f086d3b44d0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gossip Lore",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9bdeac9f-920c-40eb-91f3-b763f344a4d1"), Type = TextBlockType.Text, Text = "Your time gossiping in fashionable salons keeps you informed on every topic. You are trained in Gossip Lore, a special Lore skill that can be used only to (action: Recall Knowledge), but on any topic. If you fail a check to (action: Recall Knowledge) with Gossip Lore, you get the effects of the (feat: Dubious Knowledge) skill feat." };
            yield return new TextBlock { Id = Guid.Parse("5ab85052-e5ce-4fd4-8ba0-5de898aa9ba3"), Type = TextBlockType.Text, Text = "If you have legendary proficiency in Society, you gain expert proficiency in Gossip Lore, but you can't increase your proficiency rank in Gossip Lore by any other means." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("bb8dbdc9-06b2-4933-8624-6a136e530da9"), Feats.Instances.DandyDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("09f20896-4369-4c4a-ac67-c3af4600d8a4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
