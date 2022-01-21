using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class HealersBlessing : Template
    {
        public static readonly Guid ID = Guid.Parse("9f884f0c-0795-42e8-8389-5993e0fcea4c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Healer's Blessing",
                Level = 1,
                Range = "30 feet.",
                Duration = "1 minute.",
                Targets = "1 willing living creature.",
                DomainId = Domains.Instances.Healing.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ac356683-d3cc-48b4-944e-6cd7d7a9744f"), Type = TextBlockType.Text, Text = "Your words bless a creature with an enhanced connection to positive energy. When the target regains Hit Points from a healing spell, it regains 2 additional Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("2e9dda41-cda9-49df-b53d-fef01907e0a3"), Type = TextBlockType.Text, Text = "The target regains additional Hit Points from healer's blessing only the first time it regains HP from a given healing spell, so a spell that heals the creature repeatedly over a duration would restore additional Hit Points only once." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("f4bed96b-ab91-406f-ab54-917a1b261f2b"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ee0a591d-ff34-4e94-a531-c36f95406c08"), Type = TextBlockType.Text, Text = "The additional healing increases by 2 HP." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("1806395f-6750-4884-90fd-cf83063de12e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("2dbaa65e-769a-4954-94d8-d3db8e149f95"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("cf6d5da8-fa52-4f77-92ed-26a813ba1946"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fec1b7c6-e25d-438d-885e-139c57e294b4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 393
            };
        }
    }
}
