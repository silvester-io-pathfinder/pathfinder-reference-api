using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class UnseenServant : Template
    {
        public static readonly Guid ID = Guid.Parse("30e82bf0-a2a0-4588-af81-fcc804363898");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Unseen Servant",
                Level = 1,
                Range = "60 feet.",
                IsDismissable = true,
                Duration = "Sustained.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("30e82bf0-a2a0-4588-af81-fcc804363898"), Type = TextBlockType.Text, Text = "You summon an unseen servant (see the sidebar), which you can command as part of Sustaining the Spell. It serves you until its Hit Points are reduced to 0, at which point the spell ends, or until you stop Sustaining the Spell. The unseen servant gains the summoned trait." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("30e82bf0-a2a0-4588-af81-fcc804363898"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("30e82bf0-a2a0-4588-af81-fcc804363898"), Type = TextBlockType.Text, Text = "" }
                }
            };
        }

        protected override IEnumerable<Guid> GetSummonedCreatures()
        {
            yield return Creatures.Instances.UnseenServant.ID;
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("30e82bf0-a2a0-4588-af81-fcc804363898"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
