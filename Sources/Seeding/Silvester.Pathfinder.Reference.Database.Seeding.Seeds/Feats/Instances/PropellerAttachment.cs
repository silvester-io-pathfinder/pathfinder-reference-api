using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PropellerAttachment : Template
    {
        public static readonly Guid ID = Guid.Parse("81f8af88-7914-4771-87c6-94ffc1169d91");

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
            yield return new TextBlock { Id = Guid.Parse("f2ccd923-f9fd-4cff-a654-1f0036b8bd9f"), Type = TextBlockType.Text, Text = "You've mastered attaching clockwork propellers to your daily quick-deploy snares that use gears. This allows you to place your snares in the air or underwater, where they remain in place for up to 10 minutes, after which the propeller runs out of power and they fall or sink. Unless you use additional precautions to hide it, a propeller snare's location is usually obvious." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0cda03da-0263-463e-b212-e4f8afa6e004"), Feats.Instances.TrapsmithDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("a920fed5-217e-44ad-bd42-62edd7b5fa59"), Proficiencies.Instances.Master.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc0b40c7-91c5-4456-a571-2a5f42da274e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
