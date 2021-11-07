using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConsumeSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("ce4a79cb-8180-4891-9072-034c729a677b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Consume Spell",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dbe2bad2-8090-4b8e-a714-5663c5b21ccc"), Type = TextBlockType.Text, Text = "When you successfully (feat: Counterspell) a spell of the tradition that matches your bloodline, you consume it, replenishing yourself with its energy. When you do, you are nourished as if you had eaten a meal and regain Hit Points equal to twice the level of the counteracted spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("07b862fd-c2cd-42fa-8d21-d87a1f4f11b3"), Feats.Instances.Counterspell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("387eecab-0435-4286-9cb5-e762948eeb39"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
