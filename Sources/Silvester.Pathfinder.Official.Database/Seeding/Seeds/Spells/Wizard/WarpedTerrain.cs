using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class WarpedTerrain : Template
    {
        public static readonly Guid ID = Guid.Parse("a23ef392-9c52-493d-a808-bdedcf7b552f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Warped Terrain",
                Level = 1,
                Range = "60 feet.",
                Area = "50foot burst or more.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.OneToThreeActions.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a23ef392-9c52-493d-a808-bdedcf7b552f"), Type = TextBlockType.Text, Text = "You create illusory hazards that cover all surfaces in the area (typically the ground). Any creature moving through the illusion treats the squares as difficult terrain. A creature can attempt to disbelieve the effect as normal after using a Seek action or otherwise spending actions interacting with the illusion. If it successfully disbelieves, it ignores the effect for the remaining duration. For each additional action you use casting the spell, the burst’s radius increases by 5 feet, to a maximum of 10 extra feet for 3 actions." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a23ef392-9c52-493d-a808-bdedcf7b552f"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a23ef392-9c52-493d-a808-bdedcf7b552f"), Type = TextBlockType.Text, Text = "You can make the illusion appear in the air rather than on a surface, causing it to function as difficult terrain for flying creatures." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Illusion.ID;
            yield return Traits.Instances.Visual.ID;
            yield return Traits.Instances.Wizard.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a23ef392-9c52-493d-a808-bdedcf7b552f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 407
            };
        }
    }
}
