using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DoubleSlice : Template
    {
        public static readonly Guid ID = Guid.Parse("b1c62ffa-94a8-4d0a-9557-12ddbf2424c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Double Slice",
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
            yield return new TextBlock { Id = Guid.Parse("1ce5259e-57f2-4ebd-9170-427bbfe37dc6"), Type = TextBlockType.Text, Text = "You lash out at your foe with both weapons. Make two (Action: Strikes | Strike), one with each of your two melee weapons, each using your current multiple attack penalty. Both (Action: Strikes | Strike) must have the same target. If the second (Action: Strike) is made with a weapon that doesn’t have the (trait: agile) trait, it takes a -2 penalty." };
            yield return new TextBlock { Id = Guid.Parse("e516dd97-48cb-4dc9-90a2-44a95a352d06"), Type = TextBlockType.Text, Text = "If both attacks hit, combine their damage, and then add any other applicable effects from both weapons. You add any precision damage only once, to the attack of your choice. Combine the damage from both (Action: Strikes | Strike) and apply resistances and weaknesses only once. This counts as two attacks when calculating your multiple attack penalty." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d774293-ef59-4594-b3af-57afab0eee90"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
