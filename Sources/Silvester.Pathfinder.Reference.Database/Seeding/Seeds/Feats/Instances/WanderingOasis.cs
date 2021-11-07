using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WanderingOasis : Template
    {
        public static readonly Guid ID = Guid.Parse("a767af60-eb1e-42c4-8d42-7e18024ef917");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wandering Oasis",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("750fc217-06ed-4df6-9d43-995cdd48145d"), Type = TextBlockType.Text, Text = "You’re surrounded by soothing energy. You and allies within 60 feet of you are protected from severe environmental heat and cold. If you’re legendary in Survival, you and those allies are also protected from extreme environmental heat and cold." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("be89b819-130a-408e-bf0e-1e0af3b91038"), Proficiencies.Instances.Master.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db2b01d8-2f87-4544-b4ad-acb354e8acf7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
