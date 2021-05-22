using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class TelekineticProjectile : Template
    {
        public static readonly Guid ID = Guid.Parse("2f0bb8f2-3169-464c-8ae7-d166be2921a2");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Telekinetic Projectile",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2f0bb8f2-3169-464c-8ae7-d166be2921a2"), Type = TextBlockType.Text, Text = "You hurl a loose, unattended object that is within range and that has 1 Bulk or less at the target. Make a spell attack roll against the target. If you hit, you deal bludgeoning, piercing, or slashing damage—as appropriate for the object you hurled—equal to 1d6 plus your spellcasting ability modifier. No specific traits or magic properties of the hurled item affect the attack or the damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2f0bb8f2-3169-464c-8ae7-d166be2921a2"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("2f0bb8f2-3169-464c-8ae7-d166be2921a2"), Type = TextBlockType.Text, Text = "The damage increases by 1d6." }
                }
            };
        }

        public override IEnumerable<RollableEffect> GetRollableEffects()
        {
            yield return new RollableEffect
            {
                Id = Guid.Parse("2f0bb8f2-3169-464c-8ae7-d166be2921a2"),
                CriticalSuccess = "You deal double damage.",
                Success = "You deal full damage."
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Attack.ID;
            yield return Traits.Instances.Cantrip.ID;
            yield return Traits.Instances.Evocation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2f0bb8f2-3169-464c-8ae7-d166be2921a2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 377
            };
        }
    }
}
