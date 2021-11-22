using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HolisticCare : Template
    {
        public static readonly Guid ID = Guid.Parse("37bcf2ae-4fd4-43d0-87a8-751768bb2436");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Holistic Care",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("945bb075-229d-4249-8eb7-5be0f89be6ca"), Type = TextBlockType.Text, Text = "You provide emotional and spiritual care. Add frightened, stupefied, and stunned to the list of conditions you can reduce with (feat: Treat Condition). If the stunned condition has a duration instead of a value, you can't use (feat: Treat Condition) to reduce it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("756f4766-cb23-4f8a-ade8-38e0aa8a4d94"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.HaveSpecificFeat(Guid.Parse("d7805f2e-d9ba-478f-a255-f79b87fc7b6f"), Feats.Instances.TreatCondition.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e9159428-9be6-4cf5-b57d-dc4e2a2f9fa1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
