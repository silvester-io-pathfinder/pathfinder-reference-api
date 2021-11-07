using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterClericSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("bd525852-f00e-492b-a376-28175912c492");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Cleric Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("05f47b61-8d42-49a1-b2c0-813a097818cd"), Type = TextBlockType.Text, Text = "Your proficiency ranks for divine spell attack rolls and spell DCs increase to master, and you gain a 7th-level spell slot. At 20th level, you gain an 8th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("acd8fa96-944f-40f3-bc1b-fa6f45c8f8b0"), Feats.Instances.ExpertClericSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("394a515f-fa40-4641-91d1-208d79aae94a"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22324703-1f10-4dd3-a7e2-584f2e2cb101"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
