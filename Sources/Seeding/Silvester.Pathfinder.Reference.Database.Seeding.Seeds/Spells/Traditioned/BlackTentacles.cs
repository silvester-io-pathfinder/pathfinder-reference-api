using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class BlackTentacles : Template
    {
        public static readonly Guid ID = Guid.Parse("436d4b2a-846a-4ff1-ae57-63ecfe80f337");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Black Tentacles",
                Level = 5,
                Range = "120 feet.",
                Duration = "1 minute.",
                Targets = "20-foot burst adjecent to a flat surface.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("410bc6f5-72ec-4aae-9571-4305984478a9"), Type = Utilities.Text.TextBlockType.Text, Text = "Oily black tentacles rise up and attempt to capture creatures in the area. Make spell attack rolls against the Fortitude DC of each creature in the area. Any creature you succeed againstis grabbed by a tentacle and takes 3d6 bludgeoning damage.Whenever a creature ends its turn in the area, the tentacles attempt to grab that creature if they haven't already, and they deal 1d6 bludgeoning damage to any creature already grabbed. The tentacles' Escape DC is equal to your spell DC. A creature can attack a tentacle in an attempt to release its grip. Its AC is equal to your spell DC, and it is destroyed if it takes 12 or more damage. Even if destroyed, additional tentacles continue to grow in the area until the duration ends. You can Dismiss the spell." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e4eab8e1-b451-47f4-827d-945b12a01fc0"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0147410-9f22-4bb3-8e2a-fae5486075d8"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 321
            };
        }
    }
}
