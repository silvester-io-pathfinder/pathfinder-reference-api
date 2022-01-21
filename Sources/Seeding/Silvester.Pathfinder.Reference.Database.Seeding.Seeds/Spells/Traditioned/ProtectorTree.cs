using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ProtectorTree : Template
    {
        public static readonly Guid ID = Guid.Parse("a2e0d016-bb2e-41e2-ba78-57613afe90bc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Protector Tree",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9273fc15-e6e4-4656-913c-1ac9b0891e97"), Type = TextBlockType.Text, Text = "A Medium tree suddenly grows in an unoccupied square within range. The tree has AC 10 and 10 Hit Points. Whenever an ally adjacent to the tree is hit by a Strike, the tree interposes its branches and takes the damage first. Any additional damage beyond what it takes to reduce the tree to 0 Hit Points is dealt to the original target. The tree isn�t large enough to impede movement through its square." };
            yield return new TextBlock { Id = Guid.Parse("b366db4c-6512-44f5-bda9-4126bbd9db17"), Type = TextBlockType.Text, Text = "If the tree is in soil and survives to the end of the spell�s duration, it remains as an ordinary, non-magical tree, and continues to grow and thrive. The GM might determine that the tree disappears immediately in certain inhospitable situations." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b7446927-da60-4add-8030-0b7d6e184ee2"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("9f752511-7456-45df-8ef0-99338cc8bf74"), Type = TextBlockType.Text, Text = "The tree has an additional 10 Hit Points." }
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1de20027-fc85-49bf-8023-82bf888b9f08"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("8c407b1e-8bfa-4045-bc6b-b09bf467dbda"), Traits.Instances.Plant.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ae2f09d5-9dbf-434f-a359-a8760f4b4cff"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 123
            };
        }
    }
}
