using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OversizedThrow : Template
    {
        public static readonly Guid ID = Guid.Parse("e926faac-c745-4c7b-9cc8-42b6f9b11401");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Oversized Throw",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3c12b750-8e6b-4076-9b6b-a00f246b6d66"), Type = TextBlockType.Text, Text = "With a great heave, you seize a piece of your surroundings, such as a boulder, log, table, wagon, or chunk of earth, and hurl it at your foes. The object must be your size or one size smaller than you, and it must not have too much Bulk for you to lift it in the first place. Make a ranged (action: Strike) with the object; regardless of the result, the object takes the same amount of damage it would deal on a success. The object is a simple ranged weapon that deals 1d10 bludgeoning damage, has a range increment of 20 feet, and has the (trait: thrown) weapon trait. The damage increases to 2d10 if you have weapon specialization in simple weapons, or 3d10 if you have greater weapon specialization." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ba16b70-0a93-4923-9ea2-fce73e93873c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
