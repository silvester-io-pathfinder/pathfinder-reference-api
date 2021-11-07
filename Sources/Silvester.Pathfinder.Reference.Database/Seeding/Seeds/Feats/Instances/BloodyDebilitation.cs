using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BloodyDebilitation : Template
    {
        public static readonly Guid ID = Guid.Parse("16950f48-d9f8-453a-97bb-752fa7688161");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bloody Debilitation",
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
            yield return new TextBlock { Id = Guid.Parse("4c8d2e39-0426-4d25-af50-ccefb4e36a3a"), Type = TextBlockType.Text, Text = "Your attacks slice arteries and veins. Add the following debilitation to the list you can choose from when you use (feat: Debilitating Strike)." };
            yield return new TextBlock { Id = Guid.Parse("9077aba4-5fc3-4043-a182-6281239cb9e1"), Type = TextBlockType.Enumeration, Text = " Debilitation: The target takes 3d6 persistent bleed damage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4909dead-da96-42b3-84b2-6ccd0261f70d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.HaveSpecificFeat(Guid.Parse("8b84470f-7f07-421c-b8d1-656454d78b49"), Feats.Instances.DebilitatingStrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("842e4e2d-ce80-43d2-ad3e-7eba85dd65bb"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
