using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FreshIngredients : Template
    {
        public static readonly Guid ID = Guid.Parse("e93cab3b-cec2-4fe0-9446-f5415664a0d2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fresh Ingredients",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad674676-d9bc-4a56-8f1d-e2abe4fb513b"), Type = TextBlockType.Text, Text = "When using (feat: Natural Medicine) to (action: Treat Wounds), you can spend a batch of herbs to gain the +2 circumstance bonus from having fresh ingredients, even if not in wilderness. If you spend a batch of herbs in wilderness, you gain a +4 circumstance bonus instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e21b3cbb-eccc-46f0-97f8-35fd8b6c3036"), Feats.Instances.HerbalistDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("2aeddaff-f7d8-4c47-a87f-56bfb90b025a"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07e56418-5494-496a-bb2d-cbb594532a8d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
