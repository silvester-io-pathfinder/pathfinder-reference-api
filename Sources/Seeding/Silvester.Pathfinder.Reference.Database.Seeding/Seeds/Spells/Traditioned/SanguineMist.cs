using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SanguineMist : Template
    {
        public static readonly Guid ID = Guid.Parse("db30ef71-385b-4537-8c70-266dc4f660e9");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Sanguine Mist",
                Level = 4,
                Range = "60 feet.",
                Duration = "Sustained up to 1 minute.",
                Area = "10-foot burst.",
                IsDismissable = true,
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Fortitude.ID,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1cc91a1f-4c1b-4d2a-95cf-eeae30354dfd"), Type = TextBlockType.Text, Text = "You unleash a cloud of foul, blood-sucking fog that drains the vitality from the living to bolster your own. Each living creature in the area when you Cast the Spell, aside from you, takes 6d6 negative damage with a basic Fortitude save. Creatures in the area are concealed, and all creatures outside the cloud become concealed to creatures within it." };
            yield return new TextBlock { Id = Guid.Parse("56e2ef90-02d0-450a-a189-a661cdc05ae6"), Type = TextBlockType.Text, Text = "The first time each round you Sustain this Spell on subsequent turns, living creatures in the area take an additional 2d6 negative damage with another basic Fortitude save. You also gain temporary Hit Points equal to half the damage a single creature took when you Sustained the spell this turn; calculate these temporary Hit Points using the creature that took the most damage. You lose any remaining temporary Hit Points after 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("742aebc0-93fe-45ca-ab2a-2c91dac41419"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("cb9a72ab-28e8-45d7-9a56-28bc65e12d16"), Type = TextBlockType.Text, Text = "The initial damage increases by 2d6 and the secondary damage increases by 1d6." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Death.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Negative.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb43cadb-13d5-42fa-91f8-b98b35b8c43b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 127
            };
        }
    }
}
