using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FrighteningAppearance : Template
    {
        public static readonly Guid ID = Guid.Parse("481b2cbf-9868-4a6c-9bd4-181e14ea3f61");

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
            yield return new TextBlock { Id = Guid.Parse("316cda1c-78c9-4be4-8557-67c9cb4d5f40"), Type = TextBlockType.Text, Text = "Your dramatic appearances can frighten bystanders. When you make a (feat: Startling Appearance), you can also attempt to (action: Demoralize) each opponent within 10 feet to whom you were unnoticed before your (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5689ebd1-6094-4aef-83ba-db65641e9bb9"), Proficiencies.Instances.Expert.ID, Skills.Instances.Intimidation.ID);
            builder.HaveSpecificFeat(Guid.Parse("f2c77029-3062-438a-8bc4-e44884dd1879"), Feats.Instances.StartlingAppearance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c86199d3-fcec-44c9-b5c6-8a83bdc235c3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}