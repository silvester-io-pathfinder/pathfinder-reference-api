using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertMagusSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("f6176a5e-3983-448e-ae6f-1b672bebd7cb");

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
            yield return new TextBlock { Id = Guid.Parse("c0feb3d1-c5a5-42fa-905e-69d145b754df"), Type = TextBlockType.Text, Text = "Your proficiency ranks for your Arcane spell attack rolls and spell DCs increase to expert. You gain an additional 3rd-level spell slot. At 14th level, you replace your spell slots with two 4th-level spell slots and one 5th-level spell slot, and at 16th level, you replace your spell slots with two 5th-level spell slots and one 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("72f72a6c-f4b1-475f-b37a-cfe224e6347e"), Feats.Instances.BasicMagusSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("efd3650b-b89e-4b22-b30b-157e7d50c0f5"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c3b63ed-5392-4819-9c01-96775cea414e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
