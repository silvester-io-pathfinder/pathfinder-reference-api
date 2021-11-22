using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class WallOfWater : Template
    {
        public static readonly Guid ID = Guid.Parse("00326f86-4e57-40fe-8d4c-07ce56ae5e6e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Wall of Water",
                Level = 3,
                Range = "120 feet.",
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d88769d0-99ab-4121-b908-dbf59a883072"), Type = TextBlockType.Text, Text = "Raising your hand in the air, you call a massive wave onto the battlefield. The wall stays upright in a straight line that is 60 feet long, 10 feet high, and 5 feet thick." };
            yield return new TextBlock { Id = Guid.Parse("29671916-fa77-4203-8cc3-de0b1f6378ca"), Type = TextBlockType.Text, Text = "Any non-magical fires within the wall of water�s area that are its size or smaller are put out instantly. It also attempts to counteract any magical fires in its area. Both of these effects happen when the spell is cast and whenever a fire enters the wall�s area. If the wall fails to counteract a given fire, it can�t counteract that fire for the duration of the spell." };
            yield return new TextBlock { Id = Guid.Parse("23441d32-9e78-4a64-95bd-9a74ae9a5628"), Type = TextBlockType.Text, Text = "Bludgeoning or slashing projectiles can�t pass through the wall, and piercing projectiles have their range increments halved if they pass through the wall. A creature traversing the wall of water needs to Swim through. The rules of aquatic combat (Core Rulebook 478) apply to creatures traversing the wall of water, targeting creatures within the wall, or passing through the wall. For instance, a bludgeoning or slashing melee attack targeting a creature in the wall would take a �2 circumstance penalty." };
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
            yield return Traits.Instances.Water.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ebeda85-c124-4658-8914-0b9edef18974"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 139
            };
        }
    }
}
