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
    public class ExperiencedTracker : Template
    {
        public static readonly Guid ID = Guid.Parse("0fa29852-90f3-403a-8381-d8886176da51");

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
            yield return new TextBlock { Id = Guid.Parse("9bcb64c9-e3d0-46e3-87fd-88a388590f06"), Type = TextBlockType.Text, Text = $"Tracking is second nature to you, and when necessary you can follow a trail without pause. You can {ToMarkdownLink<Models.Entities.SkillAction>("Track", SkillActions.Instances.Track.ID)} while moving at full Speed by taking a -5 penalty to your Survival check. If you're a master in Survival, you don't take the -5 penalty. If you're legendary in Survival, you no longer need to roll a new Survival check every hour when {ToMarkdownLink<Models.Entities.SkillAction>("Tracking", SkillActions.Instances.Track.ID)}, though you still need to roll whenever there are significant changes in the trail." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a1bac5bb-951b-4cdf-a523-eb4271ddbef8"), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("475ea213-d708-4006-8e32-2e64c18247ba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
