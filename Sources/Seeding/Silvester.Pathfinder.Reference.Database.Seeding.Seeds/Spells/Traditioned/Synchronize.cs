using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Synchronize : Template
    {
        public static readonly Guid ID = Guid.Parse("90e702ee-0cd5-4db8-bdbd-bc22fa409eda");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Synchronize",
                Level = 1,
                Range = "Touch.",
                Duration = "Up to 24 hours.",
                Targets = "Up to 5 willing creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("38e47ae2-9911-423d-af77-e569cb5fc353"), Type = TextBlockType.Text, Text = "You harmlessly place your unique magic sigil, which is about 1 square inch in size, on your targets. When you Cast the Spell, you set the duration by choosing a time at which point the sigil flashes dimly three times. After that point, the spell ends. Even though spell durations aren�t normally exact, the effects of synchronize are precise to the second. The timer is based on the place where the spell was cast, so entering a plane or area where time flows differently changes how the time elapses." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e1a5b92f-99dc-4f7a-90ac-53a3fe57b35e"),
                Level = "2nd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("12f05cf8-c4f4-46f6-8182-11553c995320"), Type = TextBlockType.Text, Text = "The spell can target up to 20 willing creatures." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("d9411957-3988-4ac1-a35e-6612729b5842"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fc288bc3-d8ec-43f1-8312-70a50a63b162"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 135
            };
        }
    }
}
