using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EchoingWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("9a6cd70d-ee17-4878-8e5a-b355e5b21a85");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Echoing Weapon",
                Level = 1,
                Range = "Touch.",
                Duration = "1 minute.",
                Targets = "1 weapon.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("aa27b91d-d611-4e39-a7c2-0adfd67525cb"), Type = TextBlockType.Text, Text = "You channel magical energy into the target weapon, and the air around it faintly hums each time you strike a blow, as the impact is absorbed into the weapon. If a creature is wielding the weapon at the end of its turn, the weapon discharges a burst of sound targeting one creature adjacent to the wielder (if any). The sonic damage this deals is equal to the number of successful Strikes with the target weapon that the wielder made that turn (to a maximum of 4 sonic damage if the wielder hits with four Strikes)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("09a373d4-b68e-428c-a064-8d6be49269a8"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3d716f0e-68ac-4632-a9df-56d5cfe3710e"), Type = TextBlockType.Text, Text = "The sonic damage increases by 1 per Strike (and the maximum damage increases by 4)." }
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
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("48b3faa5-7820-4d0c-9c63-122b7d41e84d"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("0ec5b178-f7a6-42da-9bad-9d3285bd08a9"), Traits.Instances.Sonic.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b4bf4f0-a916-45ff-abf8-2df4c93b480c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 101
            };
        }
    }
}
