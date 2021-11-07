using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertOracleSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("073389a1-568c-4054-80fa-7aa5f9f65f71");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Oracle Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("e8a8b623-8ccf-4a57-8d20-f3b5cbdbd9bd"), Type = TextBlockType.Text, Text = "Your proficiency ranks for divine spell attack rolls and spell DCs increase to expert, and you gain a 4th-level spell slot. You can select a second spell from your repertoire as a signature spell. At 14th level, you gain a 5th-level spell slot, and at 16th level, you gain a 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("36f5af8d-125f-42d7-b117-6508cee987d5"), Feats.Instances.BasicOracleSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("0518dd37-ebe4-458b-9f91-9e0f3354f1ad"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbe2d2bf-a813-4b17-880d-57d51bbe3684"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
