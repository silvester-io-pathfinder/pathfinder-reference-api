using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FrighteningAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("6a877e70-6f80-43c1-930e-91d849be42e2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Frightening Appearance",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("857e8ce0-93cd-4441-a930-4b543bfa558d"), Type = TextBlockType.Text, Text = "Your dramatic appearances can frighten bystanders. When you make a (feat: Startling Appearance), you can also attempt to (action: Demoralize) each opponent within 10 feet to whom you were unnoticed before your (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("6b6f54b8-b78d-436a-a5a9-2d78d5e2700d"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            builder.HaveSpecificFeat(Guid.Parse("035aae6d-bf9f-4679-8a53-6574abca7f0e"), Feats.Instances.StartlingAppearance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c5046d8f-7fa4-4082-ada7-a46c179ed8e4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
