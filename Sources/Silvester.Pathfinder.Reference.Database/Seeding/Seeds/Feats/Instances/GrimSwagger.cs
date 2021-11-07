using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrimSwagger : Template
    {
        public static readonly Guid ID = Guid.Parse("f552ee49-1af7-4b58-86b0-6b0fd7acd1e7");

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
            yield return new TextBlock { Id = Guid.Parse("546bced3-0cbc-48f0-8fbf-e35fe525a4e4"), Type = TextBlockType.Text, Text = "You attempt to clear the room by promising a grim fate to anyone who doesn’t do what you say, and quickly. Attempt a Deception or Intimidation check against the Will DCs of each creature within 30 feet, except for your allies. Regardless of whether you succeed or fail, each subject is temporarily immune to your Grim Swagger for 10 minutes." };
            yield return new TextBlock { Id = Guid.Parse("f6e8a1a9-5994-44cc-9df5-b5c517bc1728"), Type = TextBlockType.Text, Text = "For example, if you attempt a Deception check, you lie and boast about your prowess or the large group of friends on their way to back you up. If you attempt an Intimidation check, you promise everyone in the room that you’re going to be the last thing they see." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("3049961c-cefa-4ad8-b542-02a3b079a728"),
                CriticalSuccess = "The creature becomes frightened 3. If it’s lower level than you, it’s also fleeing for 1 round.",
                Success = "The creature becomes frightened 2.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c6524c70-8c72-4657-b05f-354f8e5fad39"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
