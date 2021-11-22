using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CleanseSoulPath : Template
    {
        public static readonly Guid ID = Guid.Parse("586b9d44-168a-4bc6-b61a-a1532e03100a");

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
            yield return new TextBlock { Id = Guid.Parse("6ab68780-051e-4e86-9254-d980b69195c4"), Type = TextBlockType.Text, Text = "You meditate, pray, or otherwise try to reinforce your soul's connection to your soulforged armament. This takes 10 minutes. Attempt a counteract check against your soulforged corruption. The counteract level is half your level rounded up, and the counteract check modifier is your Religion modifier. If successful, reduce the stage of your soulforged corruption by 1 (to a minimum of Stage 1)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("694fd29d-540e-4087-911e-794c38a968fa"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
