using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Stance : Template
    {
        public static readonly Guid ID = Guid.Parse("628039bf-14cd-419d-95a2-1f8d6309cca5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Stance",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e5c2f398-1ee5-4ab7-86a4-1859abf9642f"), Type = TextBlockType.Text, Text = "A stance is a general combat strategy that you enter by using an action with the stance trait, and that you remain in for some time. A stance lasts until you get knocked out, until its requirements (if any) are violated, until the encounter ends, or until you enter a new stance, whichever comes first. After you use an action with the stance trait, you can't use another one for 1 round. You can enter or be in a stance only in encounter mode." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e0118dd7-dc3b-49ce-8694-a655ee348df9"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
