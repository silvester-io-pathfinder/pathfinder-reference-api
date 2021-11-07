using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuddenCharge : Template
    {
        public static readonly Guid ID = Guid.Parse("cf5324ce-4c4c-4e02-b7b1-b62897434c77");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sudden Charge",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c11a2017-e9ab-4b75-a4f8-e6cf9319c438"), Type = TextBlockType.Text, Text = "With a quick sprint, you dash up to your foe and swing. (Action: Stride) twice. If you end your movement within melee reach of at least one enemy, you can make a melee (Action: Strike) against that enemy. You can use Sudden Charge while (Action: Burrowing | Burrow), (Action: Climbing | Climb), (Action: Flying | Fly), or (Action: Swimming | Swim) instead of (Action: Striding | Stride) if you have the corresponding movement type." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8c5f6df-c0b5-4890-b63d-081a210517d7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
