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
    public class ExpeditiousSearch : Template
    {
        public static readonly Guid ID = Guid.Parse("9739228e-e703-4e7f-8273-482e41ae1fd9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expeditious Search",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4fdbce81-adb9-4a47-9314-94ec8b4b32e8"), Type = TextBlockType.Text, Text = $"You have a system that lets you search at great speed, finding details and secrets twice as quickly as others can. When {ToMarkdownLink<Models.Entities.Activity>("Searching", Activities.Instances.Search.ID)}, you take half as long as usual to {ToMarkdownLink<Models.Entities.Activity>("Search", Activities.Instances.Search.ID)} a given area. This means that while exploring, you double the Speed you can move while ensuring you've {ToMarkdownLink<Models.Entities.Activity>("Searched", Activities.Instances.Search.ID)} an area before walking into it (up to half your Speed). If you're legendary in Perception, you instead {ToMarkdownLink<Models.Entities.Activity>("Search", Activities.Instances.Search.ID)} areas four times as quickly." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("59197458-41a5-400b-a489-d12a4727903f"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.General.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("461beea1-fa3a-494d-93c8-439f49365243"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
