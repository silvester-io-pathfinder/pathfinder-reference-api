using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AcrobaticPerformer : Template
    {
        public static readonly Guid ID = Guid.Parse("845a38f3-cca8-4fa9-a8da-f381593a3b8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acrobatic Performer",
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
            yield return new TextBlock { Id = Guid.Parse("61860906-bb42-4995-a4af-2d82f46ec09e"), Type = TextBlockType.Text, Text = "You’re an incredible acrobat, evoking wonder and enrapturing audiences with your prowess. It’s almost a performance! You can roll an Acrobatics check instead of a Performance check when using the (action: Perform) action." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("f1358ee1-31a8-4639-8f24-c05a599c3608"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("703286eb-b53c-4c3d-96df-85b18653f7ed"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
