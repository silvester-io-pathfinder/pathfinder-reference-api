using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Incorporeal : Template
    {
        public static readonly Guid ID = Guid.Parse("31b0e628-2fb5-4d73-b2bf-7e4e8359a248");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Incorporeal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("92c68a7f-893e-4c01-9e84-a19ccc031520"), Type = TextBlockType.Text, Text = "An incorporeal creature or object has no physical form. It can pass through solid objects, including walls. When inside an object, an incorporeal creature can’t perceive, attack, or interact with anything outside the object, and if it starts its turn in an object, it is slowed 1. Corporeal creatures can pass through an incorporeal creature, but they can’t end their movement in its space." };
            yield return new TextBlock { Id = Guid.Parse("1d0fec83-fae4-4a34-a385-05b2b89ba3cb"), Type = TextBlockType.Text, Text = "An incorporeal creature can’t attempt Strength-based checks against physical creatures or objects—only against incorporeal ones—unless those objects have the ghost touch property rune. Likewise, a corporeal creature can’t attempt Strength-based checks against incorporeal creatures or objects." };
            yield return new TextBlock { Id = Guid.Parse("f19900b5-e127-4214-9bc1-e09c79185b9c"), Type = TextBlockType.Text, Text = "Incorporeal creatures usually have immunity to effects or conditions that require a physical body, like disease, poison, and precision damage. They usually have resistance against all damage (except force damage and damage from Strikes with the ghost touch property rune), with double the resistance against non-magical damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e998745-3037-4e49-af2a-7d8c550f9c50"),
                SourceId = Bestiary.ID,
                Page = 346
            };
        }
    }
}
