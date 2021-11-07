using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertDruidSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("aa3cfc60-36d0-4025-a1d2-689faf7cad26");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Druid Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("bce50d3e-bbcf-47bf-b24e-542eae99e883"), Type = TextBlockType.Text, Text = "Your proficiency ranks for primal spell attack rolls and spell DCs increase to expert, and you gain a 4th-level spell slot. At 14th level, you gain a 5th-level spell slot, and at 16th level, you gain a 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("23f1874d-dd19-41be-a920-1a4afc87b4a2"), Feats.Instances.BasicDruidSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("1455d229-8378-467c-9962-23082cd33be7"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9948057b-d045-4093-8552-a30f99a61625"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
