using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpeditiousSearch : Template
    {
        public static readonly Guid ID = Guid.Parse("5c86da53-fdab-45ed-9f55-25924cfa847d");

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
            yield return new TextBlock { Id = Guid.Parse("2e8512cf-6450-4209-8956-229bb0e6edb3"), Type = TextBlockType.Text, Text = "You have a system that lets you search at great speed, finding details and secrets twice as quickly as others can. When (Activity: Searching | Search), you take half as long as usual to (Activity: Search) a given area. This means that while exploring, you double the Speed you can move while ensuring you’ve (Activity: Searched | Search) an area before walking into it (up to half your Speed). If you’re legendary in Perception, you instead (Action: Search) areas four times as quickly." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5e98e1a5-378f-488b-b2b6-74d678a55289"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43a3ef76-6c37-40ef-9271-5fd00e39e178"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
