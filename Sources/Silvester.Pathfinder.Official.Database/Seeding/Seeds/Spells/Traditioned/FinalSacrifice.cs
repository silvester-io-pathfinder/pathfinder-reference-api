using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class FinalSacrifice : Template
    {
        public static readonly Guid ID = Guid.Parse("915dfc99-cb73-4b63-a70a-fec412833cfc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Final Sacrifice",
                Level = 2,
                Range = "120 feet.",
                Targets = "1 creature with the minion trait that you summoned or permanently control.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("22aaf18c-63b6-482f-a939-14fe3a6bec0b"), Type = TextBlockType.Text, Text = "You channel disruptive energies through the bond between you and your minion, causing it to violently explode. The target is immediately slain, and creatures within 20 feet of it take 6d6 fire damage (basic Reflex save)." };
            yield return new TextBlock { Id = Guid.Parse("9c1a07c4-eb8b-4284-a8ce-508085ac37b1"), Type = TextBlockType.Text, Text = "If the target has the cold or water trait, the spell instead deals cold damage and gains the cold trait in place of the fire trait. If used on a creature that isn’t mindless, this spell has the evil trait. Attempting to cast this spell targeting a creature that you temporarily seized control of, such as an undead commanded by command undead, automatically fails and breaks the controlling effect." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6c8c0867-db3d-4e51-b040-4364017888d5"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("50ad6921-e712-409a-a4e6-9bf9161183a8"), Type = TextBlockType.Text, Text = "The damage increases by 2d6." }
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
            yield return MagicTraditions.Instances.Primal.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Fire.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("47e1c478-edc9-47f8-8b55-64cf9c4f919d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 219
            };
        }
    }
}
