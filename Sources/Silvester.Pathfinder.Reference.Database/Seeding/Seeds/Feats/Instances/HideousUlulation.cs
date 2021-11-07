using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HideousUlulation : Template
    {
        public static readonly Guid ID = Guid.Parse("9d63a1b9-c046-441f-ad79-0ad9e0f08dcc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hideous Ululation",
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
            yield return new TextBlock { Id = Guid.Parse("cf35c6a5-8a05-4eb9-bcee-60fd765a0325"), Type = TextBlockType.Text, Text = "Your throat has multiple separate chambers that can give your voice an eerie echo. You can be clearly heard at distances of up to 300 feet regardless of ambient sound, although your voice doesn’t penetrate a magical silence effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("10c27c69-12c4-4ed9-824f-2e80d89cbaac"), Feats.Instances.OozemorphDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ceb624dd-03b6-4077-b09f-39a0cd630c98"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3bd5afc-83b0-496b-88e3-d1dd6c96abb3"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
