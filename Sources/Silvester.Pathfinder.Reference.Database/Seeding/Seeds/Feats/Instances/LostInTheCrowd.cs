using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LostInTheCrowd : Template
    {
        public static readonly Guid ID = Guid.Parse("33769d82-a8f7-49ed-8bb2-21927c0a4a73");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lost in the Crowd",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("65f07504-30ca-4d36-bafc-98deaf0c19d1"), Type = TextBlockType.Text, Text = "You’ve learned how to move as one with crowds and hide among them, vanishing into a busy street in the blink of an eye. You move at full Speed in crowds and can use cover from crowds to (action: Hide) and (action: Sneak), gaining a +2 circumstance bonus on your Stealth checks when in a crowd of at least 10 creatures and a +4 circumstance bonus on your Stealth checks when in a crowd of at least 100 creatures." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1a61d642-6bd4-458b-b87a-780acdcb86e2"), Feats.Instances.LionBladeDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2c7d0a4-50a2-424e-8680-1cec5fba15a2"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
