using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AcrobatDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("3b3b9d67-2fac-4c1b-a6f5-29971dc73ff4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Acrobat Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the acrobat archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("df41886a-20a1-4171-a4dc-9fa7ac5845c5"), Type = TextBlockType.Text, Text = "You become an expert in Acrobatics. At 7th level, you become a master in Acrobatics, and at 15th level, you become legendary in Acrobatics. Whenever you critically succeed at an Acrobatics check to (action: Tumble Through) an enemy’s space, you don’t treat the enemy’s space as difficult terrain." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("ae2a41ac-2c0c-4c46-a61a-946082da3c0e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee7faffb-a79e-4ef9-bf84-406cf661d640"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
