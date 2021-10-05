using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PlaneShift : Template
    {
        public static readonly Guid ID = Guid.Parse("e9e68a2b-1994-4584-9421-29c1d564ba6c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Plane Shift",
                Level = 7,
                CastTime = "10 minutes.",
                Range = "Touch.",
                Targets = "1 willing creature, or up to 8 willing creatures joining hands.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9fa49cc3-4f29-404a-a75d-86b2361386e8"), Type = TextBlockType.Text, Text = "You and your allies traverse the barriers between planes of existence. The targets move to another plane, such as the Plane of Fire, the Shadow Plane, or the Abyss. You must have specific knowledge of the destination plane and use a magic tuning fork created from material from that plane as a focus for the spell. While the tuning forks for most prominent planes are uncommon, just like the spell plane shift, more obscure planes and demiplanes often have rare tuning forks." };
            yield return new TextBlock { Id = Guid.Parse("01a3a694-dea8-4801-9a84-632e236610fd"), Type = TextBlockType.Text, Text = "The spell is highly imprecise, and you appear 1d20×25 miles from the last place one of the targets (of your choice) was located the last time that target traveled to the plane. If it’s the first time traveling to a particular plane for all targets, you appear at a random location on the plane. Plane shift doesn’t provide a means of return travel, though casting plane shift again allows you to return to your previous plane unless there are extenuating circumstances." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Focus.ID;
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("540715d5-04b1-4608-b08d-22c169e94f31"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 357
            };
        }
    }
}
