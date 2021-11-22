using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class FlammableFumes : Template
    {
        public static readonly Guid ID = Guid.Parse("8d8b2221-5870-4761-8fe3-912c04eeabbc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Flammable Fumes",
                Level = 106,
                Range = "120 feet.",
                Duration = "1 minute/",
                Area = "20-foot burst.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bd682f9d-70c2-435c-be19-e730f356a3e0"), Type = TextBlockType.Text, Text = "Sending magic deep underground, you conjure a cloud of toxic gases that swiftly degenerate into volatile fumes. The gases are invisible, requiring a successful Perception check against your spell DC to detect visually, though their acrid smell and toxic effects are clear once a creature has entered the cloud. A creature that enters the cloud or is within the cloud at the start of its turn takes 2d6 poison damage. A creature can take the poison damage from flammable fumes only once per round." };
            yield return new TextBlock { Id = Guid.Parse("4f376032-e110-4164-b191-3cd36a7fa78e"), Type = TextBlockType.Text, Text = "One round after you conjure the cloud, the gases loses stability and become flammable. If an open flame is brought into the cloud, or if anyone within the area uses a fire effect, the cloud detonates in a massive blaze that deals 10d6 fire damage to all creatures within it, and the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7339d6db-66f4-4c06-91a4-7f7b6240a972"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("b751d9e7-dc20-40d4-99f8-bad6c030b287"), Type = TextBlockType.Text, Text = "The poison damage increases by 1d6 and the fire damage on an explosion increases by 2d6." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Poison.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b48d78b-5a8a-48bc-b69a-e4640ba1bce6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 106
            };
        }
    }
}
