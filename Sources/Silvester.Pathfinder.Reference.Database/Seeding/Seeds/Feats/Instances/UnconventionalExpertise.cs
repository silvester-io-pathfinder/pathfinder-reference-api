using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnconventionalExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("499c3eca-4304-4811-8425-f38d80975c2f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unconventional Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("194776b2-cc47-4261-a3ca-854aee01a838"), Type = TextBlockType.Text, Text = "You’ve continued to advance your powers using your unconventional weapon. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency in the weapon you chose for (feat: Unconventional Weaponry)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8547c386-2370-461d-81a1-798b2fd1a839"), Feats.Instances.UnconventionalWeaponry.ID);
            builder.Manual(Guid.Parse("3f9b6716-b1ea-4f1d-9e9e-c241e96598c6"), "Trained in the weapon you chose for Unconventional Weaponry.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f15a90a-4e62-42e8-82a2-39251abccf44"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
