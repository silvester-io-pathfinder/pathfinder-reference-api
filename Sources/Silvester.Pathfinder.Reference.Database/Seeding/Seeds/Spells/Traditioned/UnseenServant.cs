using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class UnseenServant : Template
    {
        public static readonly Guid ID = Guid.Parse("12480683-3983-4868-9856-bacbcaf58396");

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
            yield return new TextBlock { Id = Guid.Parse("6a6fcd00-d9ab-44ee-bae8-1db47cc1a469"), Type = TextBlockType.Text, Text = "You summon an unseen servant (see the sidebar), which you can command as part of Sustaining the Spell. It serves you until its Hit Points are reduced to 0, at which point the spell ends, or until you stop Sustaining the Spell. The unseen servant gains the summoned trait." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2fa93ef7-46f3-482e-90fa-8653378b3dde"), 
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("34c8ee4f-1c1c-4667-8cbd-7c9181a6ed7b"), Type = TextBlockType.Text, Text = "" }
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
                Id = Guid.Parse("83d379b7-3b91-4a6c-885a-361d7b0604bf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 380
            };
        }
    }
}
