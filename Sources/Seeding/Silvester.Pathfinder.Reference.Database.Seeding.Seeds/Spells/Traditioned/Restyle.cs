using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Restyle : Template
    {
        public static readonly Guid ID = Guid.Parse("1c0efda9-41f2-4cf8-82e2-2089e6b9e49d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Restyle",
                Level = 1,
                Range = "Touch.",
                Duration = "Unlimited.",
                Targets = "1 piece of clothing currently worn by you or an ally.",
                CastTime = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c4ca61d-8ed2-4ecb-9790-97e4a73f3f86"), Type = TextBlockType.Text, Text = "You permanently change the appearance of one piece of clothing currently worn by you or an ally to better fit your aesthetic sensibilities. You can change its color, texture, pattern, and other minor parts of its design, but the changes can�t alter the clothing�s overall shape, size, or purpose. The changes can�t increase the quality of the craftsmanship or artistry of the piece of clothing, but particularly gauche choices for the new color and pattern might decrease its aesthetic appeal. This spell transforms existing materials into the desired appearance and never alters the material or creates more material than what�s originally part of the object. The object�s statistics also remain unchanged." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("74bac52a-5013-4663-95c8-c5e5e7bf741a"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("523df0d1-9539-45ef-98c5-e937cda384c6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 126
            };
        }
    }
}
