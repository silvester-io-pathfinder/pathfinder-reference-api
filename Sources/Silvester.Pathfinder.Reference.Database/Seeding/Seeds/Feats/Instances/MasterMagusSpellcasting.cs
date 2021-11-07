using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterMagusSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("2b73e02d-427c-43a7-b810-117076f277b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Magus Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("41d08d2f-a04b-4d50-9aff-db97347883d6"), Type = TextBlockType.Text, Text = "Your proficiency ranks for your Arcane spell attack rolls and spell DCs increase to master. You gain an additional 6th-level spell slot. At 20th level, you replace your two 5th-level spell slots with two 7th-level spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a1011edd-bce7-49be-8191-60c73cb407b7"), Feats.Instances.ExpertMagusSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("cd4465fa-875b-4c24-b368-718a1254500d"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40d81fa1-e568-4a8c-b488-1e7281c6b451"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
