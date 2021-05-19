using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class ShadowWalk : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Shadow Walk",
                Level = 5,
                CastTime = "1 minute.",
                Range = "Touch.",
                IsDismissable = true,
                Duration = "8 hours.",
                Targets = "You and up to 9 willing creatures touched.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You access the Shadow Plane, using its warped nature to spread your travels. The targets enter the edge of the Shadow Plane where it borders the Material Plane. Targets can’t see the Material Plane while on the Shadow Plane (although elements of that plane can sometimes be a hazy reflection of the Material Plane). While on the Shadow Plane, the targets are exposed to potential encounters with that plane’s denizens. The shadows on the border between the planes bend space, speeding up your movement with respect to the Material Plane. Every 3 minutes the targets travel along this border, they move as far as they would through the Material Plane in 1 hour. At any point, a target can Dismiss the spell’s effects, although this affects only that target. The shadow bending is inexact, so when the spell ends, the targets appear roughly 1 mile from their intended location on the Material Plane (though those who are traveling together and Dismiss the spell at the same point on the Plane of Shadow appear together)." };
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
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Shadow.ID;
            yield return Traits.Instances.Teleportation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 368
            };
        }
    }
}
