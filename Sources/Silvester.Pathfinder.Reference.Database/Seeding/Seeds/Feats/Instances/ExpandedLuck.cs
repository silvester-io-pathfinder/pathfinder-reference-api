using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpandedLuck : Template
    {
        public static readonly Guid ID = Guid.Parse("051a1cdb-433c-455e-bcef-8d3f297971e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expanded Luck",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59188d55-2c2e-487f-a725-be2f87e5ca5a"), Type = TextBlockType.Text, Text = "You are luckier even than most catfolk. You can trigger (feat: Cat&#39;s Luck) when you fail or critically fail a Fortitude or Will saving throw in addition to Reflex saving throws. You still can use (feat: Cat&#39;s Luck) only once per day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3052a936-8a92-40e5-81e0-4f06593a0072"), Feats.Instances.CatsLuck.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e353949-eb47-42ff-b2aa-0b8f2c14e212"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
