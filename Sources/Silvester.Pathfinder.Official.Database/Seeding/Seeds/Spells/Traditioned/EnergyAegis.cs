using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class EnergyAegis : Template
    {
        public static readonly Guid ID = Guid.Parse("a6f78806-31f1-4032-9ae8-0489b239cb9e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Energy Aegis",
                Level = 7,
                CastTime = "1 minute.",
                Range = "Touch.",
                Duration = "24 hours.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("04dc88e4-e9e5-449b-931c-19731fddf1c2"), Type = TextBlockType.Text, Text = "You protect the target with a powerful, long-lasting energy barrier. The target gains resistance 5 to acid, cold, electricity, fire, force, negative, positive, and sonic damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("ae8f40a7-ebb0-4cc1-8b01-96e6ee5f12ff"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("71801735-65fb-4811-8125-96ebc2fb8079"), Type = TextBlockType.Text, Text = "The resistances increase to 10." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bfffa6c5-5c33-4146-9801-ae6eca8807a8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 335
            };
        }
    }
}
