using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ExpertClericSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("0aa0705a-a13e-4ce6-b193-209bea6c0d42");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Expert Cleric Spellcasting",
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
            yield return new TextBlock { Id = Guid.Parse("d5abdb4f-60f9-4582-a969-f2091e510fce"), Type = TextBlockType.Text, Text = "Your proficiency ranks for divine spell attack rolls and spell DCs increase to expert, and you gain a 4th-level spell slot. At 14th level, you gain a 5th-level spell slot, and at 16th level, you gain a 6th-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d37b22ae-0d45-4524-b65f-c077904fff08"), Feats.Instances.BasicClericSpellcasting.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("d4796c60-4b83-41f6-8863-ad114902b023"), Proficiencies.Instances.Master.ID, Skills.Instances.Religion.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("42d3f804-bb0e-49aa-a6f1-699c6ff83f8c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
