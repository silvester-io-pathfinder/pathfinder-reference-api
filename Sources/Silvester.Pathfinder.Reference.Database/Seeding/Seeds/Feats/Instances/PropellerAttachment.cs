using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PropellerAttachment : Template
    {
        public static readonly Guid ID = Guid.Parse("cf3e7535-0301-49d2-9271-9581ddfc57c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Propeller Attachment",
                Level = 7,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6a5bdf7e-0379-4dc8-8050-dbafc95067cb"), Type = TextBlockType.Text, Text = "You’ve mastered attaching clockwork propellers to your daily quick-deploy snares that use gears. This allows you to place your snares in the air or underwater, where they remain in place for up to 10 minutes, after which the propeller runs out of power and they fall or sink. Unless you use additional precautions to hide it, a propeller snare’s location is usually obvious." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f8b51337-17f4-4a5e-8950-69807093288c"), Feats.Instances.TrapsmithDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("98ad752f-7e48-4330-a84e-5c7990f62931"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7bf5b29-4a30-40b6-89d4-ace429379e09"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
