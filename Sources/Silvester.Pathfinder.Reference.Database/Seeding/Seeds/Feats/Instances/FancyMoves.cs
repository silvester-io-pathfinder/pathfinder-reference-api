using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FancyMoves : Template
    {
        public static readonly Guid ID = Guid.Parse("406a9611-9200-484a-b43d-e3b4b55f38c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fancy Moves",
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
            yield return new TextBlock { Id = Guid.Parse("d47bf55f-82c3-43e5-99b0-09d9da0c4abd"), Type = TextBlockType.Text, Text = "You show off your fighting style to discourage your foes. You can use Performance to (action: Demoralize)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cab80328-2a3f-47cd-935c-f733fd76a714"), Feats.Instances.GladiatorDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ae7a9e03-c248-49e2-ba24-8671524dd0cc"), Proficiencies.Instances.Expert.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c924e8e-a590-48be-9a89-ab92c016b20f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
