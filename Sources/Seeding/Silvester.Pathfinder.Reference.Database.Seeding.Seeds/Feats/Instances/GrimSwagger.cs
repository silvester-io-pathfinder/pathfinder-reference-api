using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrimSwagger : Template
    {
        public static readonly Guid ID = Guid.Parse("3754dd92-cbb5-4784-9a2d-75af95589841");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grim Swagger",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1b9bc90-3214-4080-bb43-fd4e0633a458"), Type = TextBlockType.Text, Text = $"You attempt to clear the room by promising a grim fate to anyone who doesn't do what you say, and quickly. Attempt a Deception or Intimidation check against the Will DCs of each creature within 30 feet, except for your allies. Regardless of whether you succeed or fail, each subject is temporarily immune to your Grim Swagger for 10 minutes." };
            yield return new TextBlock { Id = Guid.Parse("840cde92-2280-453d-abd9-a31660300051"), Type = TextBlockType.Text, Text = $"For example, if you attempt a Deception check, you lie and boast about your prowess or the large group of friends on their way to back you up. If you attempt an Intimidation check, you promise everyone in the room that you're going to be the last thing they see." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("abb6a1f0-a5c0-49af-aa29-fdf0f2d44d16"),
                CriticalSuccess = "The creature becomes frightened 3. If it's lower level than you, it's also fleeing for 1 round.",
                Success = "The creature becomes frightened 2.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a7af1fff-6760-43d5-bafb-80c522cedf34"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
