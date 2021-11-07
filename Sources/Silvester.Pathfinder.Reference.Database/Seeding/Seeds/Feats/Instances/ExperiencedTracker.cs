using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExperiencedTracker : Template
    {
        public static readonly Guid ID = Guid.Parse("eabebb98-2245-4383-bf65-4669e54e9058");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Experienced Tracker",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("50250cd9-8628-49a1-8eff-1a907a45a92c"), Type = TextBlockType.Text, Text = "Tracking is second nature to you, and when necessary you can follow a trail without pause. You can (Action: Track) while moving at full Speed by taking a -5 penalty to your Survival check. If you’re a master in Survival, you don’t take the -5 penalty. If you’re legendary in Survival, you no longer need to roll a new Survival check every hour when (Action: Tracking | Track), though you still need to roll whenever there are significant changes in the trail." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4f5171f5-7e4a-4543-802d-f45d3f61913e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c58e73d-7b91-4864-87b3-ddd33f770214"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
