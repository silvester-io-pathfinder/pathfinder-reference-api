using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterWizardSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("9050964a-581f-4143-9e61-003a995255ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Wizard Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("dcf85027-fd90-4124-8a86-b067059d9141"), Type = TextBlockType.Text, Text = "Your proficiency ranks for arcane spell attack rolls and spell DCs increase to master, and you gain a 7th-level spell slot. At 20th level, you gain an 8th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1f8d7a10-9e73-4fe6-a7a2-bcb3ca8727e0"), Feats.Instances.ExpertWizardSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("71d7f7c1-e04b-423a-88fa-ddec0fbec279"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("136af600-de22-475c-a485-1097b0a91899"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
