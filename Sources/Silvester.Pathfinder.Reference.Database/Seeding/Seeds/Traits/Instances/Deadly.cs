using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Deadly : Template
    {
        public static readonly Guid ID = Guid.Parse("933245cf-38d3-44cf-994c-d353e042afbc");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Deadly",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8100f911-7232-40ca-9e07-c2c8d0a373d0"), Type = TextBlockType.Text, Text = "On a critical hit, the weapon adds a weapon damage die of the listed size. Roll this after doubling the weapon’s damage. This increases to two dice if the weapon has a greater striking rune and three dice if the weapon has a major striking rune. For instance, a rapier with a greater striking rune deals 2d8 extra piercing damage on a critical hit. An ability that changes the size of the weapon’s normal damage dice doesn’t change the size of its deadly die." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4d336ca7-18f3-44f9-95c5-48313cec863b"),
                SourceId = CoreRulebook.ID,
                Page = 282
            };
        }
    }
}
