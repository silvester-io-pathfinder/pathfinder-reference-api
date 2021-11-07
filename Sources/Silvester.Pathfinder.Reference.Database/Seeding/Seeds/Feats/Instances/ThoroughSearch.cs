using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ThoroughSearch : Template
    {
        public static readonly Guid ID = Guid.Parse("8698daad-9ed8-473c-ad9d-30bb8c94b9ac");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Thorough Search",
                Level = 3,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("210e7e83-b231-4a5e-9834-620ad7850524"), Type = TextBlockType.Text, Text = "You take your time searching to ensure you find everything. When (action: Searching | Search), you can take twice as long to search. Normally this means you (action: Search) at up to one quarter of your Speed, to a maximum of 150 feet per minute to check everything, or 75 feet per minute to check everything before you walk into it. If you do, you gain a +2 circumstance bonus to your Perception checks to (action: Seek)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("e372fc30-e4ff-411e-8464-2625c774253e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47b71579-7c46-419e-ade0-86f0aed5c625"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
