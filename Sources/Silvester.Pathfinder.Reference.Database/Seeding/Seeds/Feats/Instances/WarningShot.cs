using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WarningShot : Template
    {
        public static readonly Guid ID = Guid.Parse("a5794b7f-76eb-4b08-80d9-1f8522bc0cde");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Warning Shot",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("caf3c91a-f216-4e3d-9a2c-96b9ea100c83"), Type = TextBlockType.Text, Text = "Who needs words when the roar of a gun is so much more succinct? You attempt to (action: Demoralize) a foe by firing your weapon into the air, using the firearm’s maximum range rather than the usual range of 30 feet. This check doesn’t take the –4 circumstance penalty if the target doesn’t share a language with you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("77347a0c-e803-4159-af0b-28e07851a695"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89364c30-fa35-4995-9d0f-e385d4d9f297"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
