using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Attached : Template
    {
        public static readonly Guid ID = Guid.Parse("bca7730f-377b-429b-ba4b-86ffeacc3f84");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Attached",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("928e9ca0-6b10-4f28-8cdf-8cbd06dd8e97"), Type = TextBlockType.Text, Text = "An attached weapon must be combined with another piece of gear to be used. The trait lists what type of item the weapon must be attached to. You must be wielding or wearing the item the weapon is attached to in order to attack with it. For example, shield spikes are attached to a shield, allowing you to attack with the spikes instead of a shield bash, but only if you're wielding the shield. An attached weapon is usually bolted onto or built into the item it's attached to, and typically an item can have only one weapon attached to it. An attached weapon can be affixed to an item with 10 minutes of work and a successful DC 10 Crafting check; this includes the time needed to remove the weapon from a previous item, if necessary. If an item is destroyed, its attached weapon can usually be salvaged." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c822e78-3a01-4a7b-94e7-ff7fcccd4eed"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
