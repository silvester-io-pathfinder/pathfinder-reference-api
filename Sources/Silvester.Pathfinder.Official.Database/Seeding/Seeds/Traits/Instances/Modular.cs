using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Modular : Template
    {
        public static readonly Guid ID = Guid.Parse("e5abbf0f-16df-4710-a810-406156167ef5");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Modular" ,
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca2fab94-ec42-48e8-bcd8-bf84398667aa"), Type = TextBlockType.Text, Text = "The weapon has multiple configurations that you can switch between using an Interact action. Typically, switching between configurations of a modular weapon allows it to deal different types of damage (listed in the trait, such as “modular B, P, or S”), though it’s possible for a modular weapon’s description to list more complicated configurations." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("99c5f008-3504-4b4d-9360-2f495e0b4d65"),
                SourceId = GodsAndMagic.ID,
                Page = 120
            };
        }
    }
}
