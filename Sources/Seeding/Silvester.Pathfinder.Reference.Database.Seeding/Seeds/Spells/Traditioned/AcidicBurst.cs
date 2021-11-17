using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AcidicBurst : Template
    {
        public static readonly Guid ID = Guid.Parse("c9f7b57a-fec0-42f6-aea5-7001e2fae46a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Acidic Burst",
                Level = 1,
                Area = "5-foot emanation",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c66eaea7-8416-4973-a58f-cc88877dbec1"), Type = TextBlockType.Text, Text = "You create a shell of acid around yourself that immediately bursts outward, dealing 2d6 acid damage to each creature in the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("a1e05eeb-60b4-4cd0-96f9-7ee8fd992750"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("7f9524ee-b831-49d1-87f2-afd0cbbb88f1"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Acid.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cc009f21-6e2b-4fec-b009-1985fad8a26c"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 106
            };
        }
    }
}
