using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TravelersTransit : Template
    {
        public static readonly Guid ID = Guid.Parse("39c444d7-449b-481e-8c53-a66e85b8b79b");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Traveler's Transit",
                Level = 4,
                Duration = "1 minute.",
                DomainId = Domains.Instances.Travel.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d4b7a4c9-93ec-4688-b1de-e124675e625e"), Type = TextBlockType.Text, Text = "You add power to your muscles, allowing you to swim or climb walls with ease. When you cast this spell, you gain either a climb Speed or a swim Speed. The Speed is equal to your land Speed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("7416ed84-826f-4de3-a7d0-ac9ac591820a"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("3c87f925-5644-4eee-83b3-e5538615577b"), Type = TextBlockType.Text, Text = "You can choose to gain a fly Speed." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("aefeab59-2f06-46ba-b71f-cde298d36720"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("a737b9d1-2137-468e-a09b-556ee87a3a3f"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("c2f2ef1b-43ad-4ea3-9325-3002d9640f03"), Traits.Instances.Evocation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b83aaacf-38d3-40fb-8d5e-292a15f5bf1c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 398
            };
        }
    }
}
