using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertMagusSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("fef37f71-f7b0-4c4e-8fe6-60d62a2a25bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Magus Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("7fe2060b-d268-4553-b801-2a2018a6047d"), Type = TextBlockType.Text, Text = "Your proficiency ranks for your Arcane spell attack rolls and spell DCs increase to expert. You gain an additional 3rd-level spell slot. At 14th level, you replace your spell slots with two 4th-level spell slots and one 5th-level spell slot, and at 16th level, you replace your spell slots with two 5th-level spell slots and one 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("577429bd-4bcb-4734-9b70-f5ea63c6461f"), Feats.Instances.BasicMagusSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("0f339878-325c-4c40-91ce-80c6d60576ec"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e505dfa-be19-4049-891c-d360650af885"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
