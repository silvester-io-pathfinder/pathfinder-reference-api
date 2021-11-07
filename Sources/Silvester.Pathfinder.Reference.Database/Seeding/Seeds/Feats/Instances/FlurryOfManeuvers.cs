using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlurryOfManeuvers : Template
    {
        public static readonly Guid ID = Guid.Parse("a9e35092-0ff3-4f96-853f-efdca424d1ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flurry of Maneuvers",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2010df1a-f583-41d5-9adf-8532c271e9ba"), Type = TextBlockType.Text, Text = "You flurry is a combination of maneuvers. You can replace one or both of your attacks during a (feat: Flurry of Blows) with (action: Grapples | Grapple), (action: Shoves | Shove), or (action: Trips | Trip)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("80ece851-5a90-46fd-b8e4-46f0deeb803d"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ed54f35-fd0c-40f7-bfef-823d4dfc9f4f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
