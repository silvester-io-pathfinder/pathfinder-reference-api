using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class InfluenceNature : Template
    {
        public static readonly Guid ID = Guid.Parse("63d3dd44-8ba6-4afa-9681-3c2f0d59a7c5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Influence Nature",
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
            yield return new TextBlock { Id = Guid.Parse("bb24bd9b-ecd9-4c28-9629-f1ac6915145b"), Type = TextBlockType.Text, Text = "With patience and time, you can make bird calls, leave game trails, and ultimately influence the behavior of a certain type of animals in the region to favor and even aid you in the days to come. The GM determines the DC of any check required and the amount of time your work requires (usually at least a day or two of downtime). While you can’t directly control how you’ve influenced nature, you can hope for certain effects, such as easier hunts or birds falling silent whenever danger is approaching. If you’re legendary in Nature, you can elicit these same adjustments to animal behavior in the area by spending only 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("a0f117e5-df75-4ea3-884b-f038e3f2c20c"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e722583d-6e76-4c03-8d62-d73d22f3f853"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
