using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertBardSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("9d513cd5-fbc8-4bb6-ab85-bc9aa6520a11");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Bard Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("b3a29841-603c-4b66-bded-57d0a7a3ad57"), Type = TextBlockType.Text, Text = "Your proficiency ranks for occult spell attack rolls and spell DCs increase to expert, and you gain a 4th-level spell slot. You can select a second spell from your repertoire as a signature spell. At 14th level, you gain a 5th-level spell slot, and at 16th level, you gain a 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("44f832a5-3297-4ee9-8c4e-5927b4877011"), Proficiencies.Instances.Master.ID, Skills.Instances.Occultism.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a43f5c0e-48dc-4941-a611-1c906268c12b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
