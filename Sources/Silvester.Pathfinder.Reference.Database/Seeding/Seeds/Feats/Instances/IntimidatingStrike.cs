using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class IntimidatingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("18b60d29-60c5-45db-865f-2b5edbe04a00");

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
            yield return new TextBlock { Id = Guid.Parse("9927b3a0-fd64-4bd3-b104-aa01f3db83b7"), Type = TextBlockType.Text, Text = "Your blow not only wounds creatures but also shatters their confidence. Make a melee (Action: Strike). If you hit and deal damage, the target is frightened 1, or frightened 2 on a critical hit." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("57b47e16-0101-4556-a4b9-ab4063b006d5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
