using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class CircleOfProtectionSpell : AbstractSpellTemplate
    {
        public static readonly Guid ID = Guid.Parse("35ac23b0-0e3d-4aab-8217-116f931edcb7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Circle of Protection",
                Level = 3,
                Range = 0,
                Area = "10-foor emanation centered on the touched creature.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46b66be4-d7be-4409-b1d9-39853f034475"), Type = Utilities.Text.TextBlockType.Text, Text = "You ward a creature and those nearby against a specified alignment. Choose chaotic, evil, good, or lawful; this spell gains the opposing trait. Creatures in the area gain a +1 status bonus to AC against attacks by creatures of the chosen alignment and to saves against effects from such creatures. This bonus increases to +3 against effects from such creatures that directly control the target and attacks made by summoned creatures of the chosen alignment. Summoned creatures of the chosen alignment can’t willingly enter the area without succeeding at a Will save; repeated attempts use the first save result." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("5da315c4-0930-4154-803d-1d618e8073a4"), 
                Level = 4,
                Details =
                {
                    new TextBlock { Id = Guid.Parse("b1598565-4cb0-4656-bfcb-16b7b5d336fa"), Type = Utilities.Text.TextBlockType.Text, Text = "The duration increases to 1 hour." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Abjuration.ID;
        }
    }
}
