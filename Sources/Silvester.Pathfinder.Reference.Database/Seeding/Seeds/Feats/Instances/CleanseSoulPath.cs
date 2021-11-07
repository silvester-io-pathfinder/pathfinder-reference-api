using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CleanseSoulPath : Template
    {
        public static readonly Guid ID = Guid.Parse("892e853b-215b-467e-9cbf-94960f90412d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cleanse Soul Path",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4b562c0-3097-449b-b63f-1da6865d7ff6"), Type = TextBlockType.Text, Text = "You meditate, pray, or otherwise try to reinforce your soul’s connection to your soulforged armament. This takes 10 minutes. Attempt a counteract check against your soulforged corruption. The counteract level is half your level rounded up, and the counteract check modifier is your Religion modifier. If successful, reduce the stage of your soulforged corruption by 1 (to a minimum of Stage 1)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e542de4-98f8-4836-9c7c-6fe2370c09b6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
