using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SettlementScholastics : Template
    {
        public static readonly Guid ID = Guid.Parse("68877c4b-2a8a-462f-abc7-219e283d7133");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Settlement Scholastics",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can take this feat multiple times. When you take this feat again, choose a different settlement.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a2abd1a-1079-4381-88cf-516f541c0fd0"), Type = TextBlockType.Text, Text = "Your studies open up new horizons. You become an expert in a Lore skill about a specific settlement; if you were already trained in that Lore skill, you also become trained in the Lore skill for a different settlement of your choice. Choose a single common or uncommon language prevalent in that settlement. You learn that language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("20843861-f073-4399-8b4d-017e1af0bfe4"), Feats.Instances.ArcheologistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("754ecb60-d8a9-4eaf-9f6a-cfa4ec9b9073"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
