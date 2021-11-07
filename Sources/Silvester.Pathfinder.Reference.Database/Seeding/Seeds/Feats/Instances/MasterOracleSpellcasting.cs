using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterOracleSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("9efbb67b-602c-484e-9c31-42a80c771d32");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Oracle Spellcasting",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("163096ec-ee05-46f6-9480-81ea23c9799d"), Type = TextBlockType.Text, Text = "Your proficiency ranks for divine spell attack rolls and spell DCs increase to master, and you gain a 7th-level spell slot. You can select a third spell from your repertoire as a signature spell. At 20th level, you gain an 8th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5aae7970-27b8-478f-a3d2-495310e4690c"), Feats.Instances.ExpertOracleSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("5048c130-6df4-47bd-a0c2-bb173250fff0"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3ccebe4-c0de-4f19-844b-fdaaef65fe90"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
