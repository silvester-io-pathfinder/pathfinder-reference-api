using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Longstrider : Template
    {
        public static readonly Guid ID = Guid.Parse("683a0193-0a17-49f8-b90e-5fc121fac80a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Longstrider",
                Level = 1,
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("85f1c6e3-2526-4fdd-b2f9-f62ef626ce07"), Type = TextBlockType.Text, Text = "You lengthen your stride beyond what should be possible. You gain a + 10 - foot status bonus to your Speed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6dd2f8cc-f2c8-4512-8b87-659f7485abfe"), 
                Level = "2nd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("22bb3841-8950-4032-8050-4a9dee5b5740"), Type = TextBlockType.Text, Text = "The duration increases to 8 hours." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("86cb55d6-f040-46e2-b1b0-c94e33942cdb"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d102f36-f8f9-49aa-a90c-bfa201140473"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 348
            };
        }
    }
}
