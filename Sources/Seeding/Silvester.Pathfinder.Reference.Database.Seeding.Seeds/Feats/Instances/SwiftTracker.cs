using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SwiftTracker : Template
    {
        public static readonly Guid ID = Guid.Parse("f1f799d6-c703-4e91-83fb-ef463f8998e6");

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
            yield return new TextBlock { Id = Guid.Parse("f562a2f5-5a26-422d-b37e-693829743704"), Type = TextBlockType.Text, Text = $"Your keen eyes catch signs of passage even when you're moving. You can move at your full Speed while you {ToMarkdownLink<Models.Entities.SkillAction>("Track", SkillActions.Instances.Track.ID)}. If you have master proficiency in Survival, you don't need to attempt a new Survival check every hour while {ToMarkdownLink<Models.Entities.SkillAction>("Tracking", SkillActions.Instances.Track.ID)}. If you have legendary proficiency in Survival, you can use another exploration activity while {ToMarkdownLink<Models.Entities.SkillAction>("Tracking", SkillActions.Instances.Track.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("cdaf9c8f-8099-4d01-a040-e0e66371bc8d"), Type = TextBlockType.Text, Text = $"If you roll Survival for initiative while {ToMarkdownLink<Models.Entities.SkillAction>("Tracking", SkillActions.Instances.Track.ID)} your hunted prey, when you start your first turn of the encounter, you can {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} toward your hunted prey as a free action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("1a7022dc-c882-47ad-a156-a57e853d0144"), Proficiencies.Instances.Expert.ID, Skills.Instances.Survival.ID);
            builder.HaveSpecificFeat(Guid.Parse("9263e984-27f6-473e-94f1-2961a8c242a3"), Feats.Instances.ExperiencedTracker.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de3c5190-468c-437d-93a3-98c0de1dc045"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
