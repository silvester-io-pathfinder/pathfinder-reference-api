using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Conditions.Instances
{
    public class Broken : Template
    {
        public static readonly Guid ID = Guid.Parse("8ecb38b2-d7fb-440f-b096-cf381652b2ff");

        public override Condition GetCondition()
        {
            return new Condition
            {
                Id = ID,
                Name = "Broken",
            };
        }

        public override IEnumerable<TextBlock> GetConditionDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4ccf1630-ee1b-4a52-b41a-d80832acccc8"), Type = Utilities.Text.TextBlockType.Text, Text = "Broken is a condition that affects objects. An object is broken when damage has reduced its Hit Points to equal or less than its Broken Threshold. A broken object can’t be used for its normal function, nor does it grant bonuses— with the exception of armor. Broken armor still grants its item bonus to AC, but it also imparts a status penalty to AC depending on its category: –1 for broken light armor, –2 for broken medium armor, or –3 for broken heavy armor." };
            yield return new TextBlock { Id = Guid.Parse("d5009a32-f90e-465d-a23d-c0d1bf4957e7"), Type = Utilities.Text.TextBlockType.Text, Text = "A broken item still imposes penalties and limitations normally incurred by carrying, holding, or wearing it. For example, broken armor would still impose its Dexterity modifier cap, check penalty, and so forth." };
            yield return new TextBlock { Id = Guid.Parse("91795d9e-e963-4fe4-98ab-bfc3f00b1b63"), Type = Utilities.Text.TextBlockType.Text, Text = "If an effect makes an item broken automatically and the item has more HP than its Broken Threshold, that effect also reduces the item’s current HP to the Broken Threshold." };
        }

        public override SourcePage? GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("535f3f02-9a6f-4b34-9080-460f626a969c"),
                SourceId = CoreRulebook.ID,
                Page = 618
            };
        }
    }
}
