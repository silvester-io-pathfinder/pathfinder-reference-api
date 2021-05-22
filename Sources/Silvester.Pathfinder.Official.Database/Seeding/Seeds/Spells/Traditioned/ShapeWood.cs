using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ShapeWood : Template
    {
        public static readonly Guid ID = Guid.Parse("28ca5d12-0669-4835-9ae8-fb3f90b47c2f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shape Wood",
                Level = 2,
                Range = "Touch.",
                Targets = "An unworked piece of wood up to 20 cubic feet in volume.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eee09187-7c0e-4ffb-8a71-cf7a2331427b"), Type = TextBlockType.Text, Text = "You shape the wood into a rough shape of your choice. The shaping power is too crude to produce with intricate parts, fine details, moving pieces, or the like. You cannot use this spell to enhance the value of the wooden object you are shaping." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Plant.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1b070d5f-25b0-4839-a57c-4f4907366df7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
