using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GossipLore : Template
    {
        public static readonly Guid ID = Guid.Parse("f18aabc2-c5eb-4b94-85c6-89cdaf47cfed");

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
            yield return new TextBlock { Id = Guid.Parse("5c550f39-c663-452e-b6a5-ace92d82cd10"), Type = TextBlockType.Text, Text = "Your time gossiping in fashionable salons keeps you informed on every topic. You are trained in Gossip Lore, a special Lore skill that can be used only to (action: Recall Knowledge), but on any topic. If you fail a check to (action: Recall Knowledge) with Gossip Lore, you get the effects of the (feat: Dubious Knowledge) skill feat." };
            yield return new TextBlock { Id = Guid.Parse("40ae7e57-c170-44ca-901c-86fba6c9ba18"), Type = TextBlockType.Text, Text = "If you have legendary proficiency in Society, you gain expert proficiency in Gossip Lore, but you can’t increase your proficiency rank in Gossip Lore by any other means." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a769e45b-87f7-4225-84ab-99fbe54a32e2"), Feats.Instances.Dandy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2400baf-09fa-49e2-a517-62156ec49c91"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
