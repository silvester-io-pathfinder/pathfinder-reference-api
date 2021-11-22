using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BitingWords : Template
    {
        public static readonly Guid ID = Guid.Parse("9a4481d4-27c2-4df6-8a5d-233b84c3857e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Biting Words",
                Level = 1,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89e6e074-33ea-4cb3-88e4-a8bb2055c074"), Type = TextBlockType.Text, Text = "You entwine magic with your voice, causing your taunts and jibes to physically harm your enemies. You can attack with your words once when you finish Casting the Spell, and can repeat the attack once on each of your subsequent turns by taking a single action, which has the attack, concentrate, and linguistic traits. After your third attack total, the spell ends." };
            yield return new TextBlock { Id = Guid.Parse("44173f64-940b-46fd-a3a7-94b01d020420"), Type = TextBlockType.Text, Text = "When you attack with biting words, make a ranged spell attack roll against a creature within 30 feet, dealing 2d6 sonic damage if you hit (or double damage on a critical hit)." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6ce2d1d7-dd2a-42e9-8fe0-e5a7f886e3ae"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5b168ed2-a0be-4bec-a22b-141a969bec9e"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attached.ID;
            yield return Traits.Instances.Auditory.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Linguistic.ID;
            yield return Traits.Instances.Sonic.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a79dc42a-8f41-4fe9-8282-3d7417024943"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 90
            };
        }
    }
}
