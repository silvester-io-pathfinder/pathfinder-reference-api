using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertWizardSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("7709a95a-677d-4b60-b98e-db6577a6bbd8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Wizard Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("5e5dd215-bcf2-43ef-920c-7f64cbd15894"), Type = TextBlockType.Text, Text = "Your proficiency ranks for arcane spell attack rolls and spell DCs increase to expert, and you gain a 4th-level spell slot. At 14th level, you gain a 5th-level spell slot, and at 16th level, you gain a 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("601d66b2-6567-4de9-bb94-2ac3101f5b94"), Feats.Instances.BasicWizardSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("e323393a-fc5a-40b8-a91f-13dee46e578c"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("733c1859-b86b-463f-8293-1fd99bfdb009"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
