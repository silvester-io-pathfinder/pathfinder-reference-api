using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EphemeralTracking : Template
    {
        public static readonly Guid ID = Guid.Parse("debf17cf-da6b-42b7-be28-c6af09d84f8e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ephemeral Tracking",
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
            yield return new TextBlock { Id = Guid.Parse("e6384490-68fb-4209-b756-76d3718066c3"), Type = TextBlockType.Text, Text = "You are able to track your quarry through impossible places. You gain the (spell: ephemeral tracking) warden spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4f1e4d74-d121-4313-a9b5-34a80108f874"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
            builder.HaveSpecificClass(Guid.Parse("0d00b0cb-92aa-479b-8bb9-9b7666eb69c5"), Classes.Instances.Ranger.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4323ee82-e47a-4444-8aa9-96f97ec3f75f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
