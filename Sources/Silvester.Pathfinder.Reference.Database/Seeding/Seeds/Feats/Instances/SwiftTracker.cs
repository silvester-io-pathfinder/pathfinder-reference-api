using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwiftTracker : Template
    {
        public static readonly Guid ID = Guid.Parse("9beb0b77-2402-4686-b596-8ff0636b7a2f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Swift Tracker",
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
            yield return new TextBlock { Id = Guid.Parse("9c3dfec2-7d93-4703-9a8f-7429b0d252c7"), Type = TextBlockType.Text, Text = "Your keen eyes catch signs of passage even when you’re moving. You can move at your full Speed while you (action: Track). If you have master proficiency in Survival, you don’t need to attempt a new Survival check every hour while (action: Tracking | Track). If you have legendary proficiency in Survival, you can use another exploration activity while (action: Tracking | Track)." };
            yield return new TextBlock { Id = Guid.Parse("a5d63ef2-c6ad-47e7-b565-e29e5f7a044b"), Type = TextBlockType.Text, Text = "If you roll Survival for initiative while (action: Tracking | Track) your hunted prey, when you start your first turn of the encounter, you can (action: Stride) toward your hunted prey as a free action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1bbcfb1b-0ec6-4b68-abd6-06700e739291"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
            builder.HaveSpecificFeat(Guid.Parse("49d25b58-db88-44d5-9873-8459a922c8ff"), Feats.Instances.ExperiencedTracker.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3227a09-5714-4503-a35d-50de866685d0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
