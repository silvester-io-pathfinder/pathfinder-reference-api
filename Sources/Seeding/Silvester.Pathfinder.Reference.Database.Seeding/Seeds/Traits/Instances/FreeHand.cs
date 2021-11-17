using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class FreeHand : Template
    {
        public static readonly Guid ID = Guid.Parse("c12bd84b-b3f2-4cc8-b579-eee078031c4d");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Free-Hand",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e9ef051b-8dac-4026-a3d2-224b42f30e14"), Type = TextBlockType.Text, Text = "This weapon doesn’t take up your hand, usually because it is built into your armor. A free-hand weapon can’t be Disarmed. You can use the hand covered by your free-hand weapon to wield other items, perform manipulate actions, and so on. You can’t attack with a free-hand weapon if you’re wielding anything in that hand or otherwise using that hand. When you’re not wielding anything and not otherwise using the hand, you can use abilities that require you to have a hand free as well as those that require you to be wielding a weapon in that hand. Each of your hands can have only one free-hand weapon on it." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6d16a952-46a4-4af0-8b8f-2e54395b0bc5"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
