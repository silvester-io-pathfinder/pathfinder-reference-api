using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Traits.Instances
{
    public class Incorporeal : AbstractTraitTemplate
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Trait GetTrait(TraitSeeder seeder)
        {
            return new Trait
            {
                Id = ID,
                Name = "Incorporeal",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An incorporeal creature or object has no physical form. It can pass through solid objects, including walls. When inside an object, an incorporeal creature can’t perceive, attack, or interact with anything outside the object, and if it starts its turn in an object, it is slowed 1. Corporeal creatures can pass through an incorporeal creature, but they can’t end their movement in its space." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "An incorporeal creature can’t attempt Strength-based checks against physical creatures or objects—only against incorporeal ones—unless those objects have the ghost touch property rune. Likewise, a corporeal creature can’t attempt Strength-based checks against incorporeal creatures or objects." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Incorporeal creatures usually have immunity to effects or conditions that require a physical body, like disease, poison, and precision damage. They usually have resistance against all damage (except force damage and damage from Strikes with the ghost touch property rune), with double the resistance against non-magical damage." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Bestiary.ID,
                Page = 346
            };
        }
    }
}
