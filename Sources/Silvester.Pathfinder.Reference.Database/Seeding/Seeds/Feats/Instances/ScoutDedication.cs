using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScoutDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("759df2c1-1307-44ad-98f9-83a6ffbd7cc5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the scout archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("672c45ea-27a5-4dd2-b155-416a6db79865"), Type = TextBlockType.Text, Text = "You are a highly skilled scout, capable of providing your allies a timely warning of any danger. You gain the (feat: Scout’s Warning) ranger feat. When you’re using the (action: Scout) exploration activity, you grant your allies a +2 circumstance bonus to their initiative rolls instead of a +1 circumstance bonus." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("bf5b327e-ca81-4f03-9800-7d2bf9d9f53a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("d6584370-c21a-4f17-8891-7ce11f233a66"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("71aa797c-1b10-46ae-939d-68bf9f31b6cd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
