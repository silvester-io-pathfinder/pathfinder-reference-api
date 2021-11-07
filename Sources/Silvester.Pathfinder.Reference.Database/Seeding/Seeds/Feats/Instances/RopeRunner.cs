using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class RopeRunner : Template
    {
        public static readonly Guid ID = Guid.Parse("7fa0eb15-e5c6-49d5-9534-a05c884c88fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rope Runner",
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
            yield return new TextBlock { Id = Guid.Parse("5505f2d8-31cf-4276-8ce8-0c00aee50372"), Type = TextBlockType.Text, Text = "You run and climb across ropes and rigging almost as easily as on the ground. You gain a climb Speed of 15 feet, but only on ship’s rigging or similar ropes. Whenever you succeed at an Athletics check to (action: Climb) a rope or an Acrobatics check to (action: Balance) on a rope, you get a critical success instead. You aren’t flat-footed while (action: Climbing | Climb) or (action: Balancing | Balance) on a rope." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("629c5c61-f839-4432-b3e2-97210116d1cc"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("c278ceb4-e0a3-45da-ac6a-9c342b2c9ad3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.HaveSpecificFeat(Guid.Parse("6d648f5b-e584-4aec-a771-d8ba048b2fb3"), Feats.Instances.PirateDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0276674b-4b80-4d36-b2c9-0ddcf8e09099"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
