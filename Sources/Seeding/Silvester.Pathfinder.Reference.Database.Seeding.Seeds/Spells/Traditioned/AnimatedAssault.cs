using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AnimatedAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("d410d3c1-fc7f-413e-9485-40d55d01b5ab");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Animated Assault",
                Level = 2,
                Range = "120 feet.",
                Area = "10-foot burst.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09fd8ec7-ce0c-4d6d-8a79-b43f3dbacf29"), Type = TextBlockType.Text, Text = "You use your mind to manipulate unattended objects in the area, temporarily animating them to attack. The objects hover in the air, then hurl themselves at nearby creatures in a chaotic flurry of debris. This assault deals 2d10 bludgeoning damage (basic Reflex save) to each creature in the area. On subsequent rounds, you can Sustain this Spell, dealing 1d10 bludgeoning damage (basic Reflex save) to each creature in the area." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("86f6f877-820a-4c90-bfe1-ab738a08c4f8"), 
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("60302b49-49db-47f9-83fd-5b6fb1a87e04"), Type = TextBlockType.Text, Text = "The initial damage increases by 2d10 and the subsequent damage increases by 1d10." }
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
            builder.Add(Guid.Parse("8b81f982-c3a5-4ad6-9be9-e275d5dcf38a"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b70697a1-81e2-4cf0-836c-f5ec7e1ca380"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 214
            };
        }
    }
}
