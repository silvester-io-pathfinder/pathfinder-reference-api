using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntimidatingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("9de17887-6a72-4b7c-b2b0-b678fe50fee5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intimidating Strike",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("352cdabb-b457-401e-9b07-bf704fe29019"), Type = TextBlockType.Text, Text = "Your blow not only wounds creatures but also shatters their confidence. Make a melee (Action: Strike). If you hit and deal damage, the target is frightened 1, or frightened 2 on a critical hit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21582f1c-02b4-446e-9918-503488c4f5d6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
