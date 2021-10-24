using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpectralHand : Template
    {
        public static readonly Guid ID = Guid.Parse("b2146d32-371c-40a7-847e-982000bc2b5b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spectral Hand",
                Level = 2,
                Range = "120 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("157deae1-cb56-4eb9-9df0-c0deeb9de2cc"), Type = TextBlockType.Text, Text = "You create a semicorporeal hand out of your essence that delivers touch spells for you. Whenever you Cast a Spell with a range of touch, you can have the hand crawl to a target within range along the ground, touch it, and then crawl back to you. When making a melee spell attack with the hand, you use your normal bonuses. The hand can move as far as it needs to within range. The hand has your AC and saves, but any damage to the hand destroys it and causes you to take 1d6 damage." };
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
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3836cd3c-1bb0-42d3-a32e-242187159ade"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 370
            };
        }
    }
}
