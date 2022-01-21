using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("565d7ede-871a-4fe0-ba9f-32fae6769a48"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("c7dd4fdc-5912-49cb-bc0c-06f59f8fdd28"), Traits.Instances.Curse.ID);
            builder.Add(Guid.Parse("06b07785-8878-4368-b029-d98b64aa6b04"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("84051165-cb0c-4064-be5a-411ea8da4598"), Traits.Instances.Sorcerer.ID);
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
