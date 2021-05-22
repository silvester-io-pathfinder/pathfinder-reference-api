using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class CelestialBrand : Template
    {
        public static readonly Guid ID = Guid.Parse("22e6cf81-cf00-491e-b9dd-911d737d4436");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Celestial Brand",
                Level = 5,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 evil creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a91faef5-2149-4eda-9ee7-db7ceee75f83"), Type = TextBlockType.Text, Text = "A blazing symbol appears on the target, cursing it to face divine justice. You and your allies receive a +1 status bonus to your attack rolls and skill checks against it. Anytime a good creature damages it, the good creature deals an additional 1d4 good damage. The target is then temporarily immune for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6e17b1e8-107e-4b28-9032-bbd94e2419b1"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("11463c85-ed64-4e6e-89a0-227afc174d3e"), Type = TextBlockType.Text, Text = "1 minute. Heightened (+2)" }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Curse.ID;
            yield return Traits.Instances.Necromancy.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("31588d05-b287-4ce1-9b48-5b29110b6f52"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 403
            };
        }
    }
}
