using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HolisticCare : Template
    {
        public static readonly Guid ID = Guid.Parse("31020f60-67e7-493b-8c18-d147770b8172");

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
            yield return new TextBlock { Id = Guid.Parse("f74ae2b7-b333-45fa-8e4c-02a9afd2b15f"), Type = TextBlockType.Text, Text = "You provide emotional and spiritual care. Add frightened, stupefied, and stunned to the list of conditions you can reduce with (feat: Treat Condition). If the stunned condition has a duration instead of a value, you can’t use (feat: Treat Condition) to reduce it." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("3930a33f-cf8a-4e10-92d5-3cff27af8ad7"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.HaveSpecificFeat(Guid.Parse("08a34746-7359-4e96-84af-6b8acc6d6e2c"), Feats.Instances.TreatCondition.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7da932e1-d033-4fa2-83a3-f3e6283b7426"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
