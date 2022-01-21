using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class TemptFate : Template
    {
        public static readonly Guid ID = Guid.Parse("8b3f9e90-b622-4643-9bb7-7b44587b6aeb");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tempt Fate",
                Level = 4,
                Trigger = "You or an ally within range attempts a saving throw.",
                Range = "120 feet.",
                Targets = "The triggering creature.",
                DomainId = Domains.Instances.Fate.ID,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                ClassId = Classes.Instances.Cleric.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9265abd3-63c0-4d11-98cc-2688433b9f94"), Type = TextBlockType.Text, Text = "You twist the forces of fate to make a moment dire or uneventful, with no in-between. The target gains a +1 status bonus to the triggering saving throw. If the saving throw's result is a success, it becomes a critical success. If it's a failure, it becomes a critical failure, and the critical failure can't be reduced by abilities that usually reduce critical failure, such as improved evasion." };
            yield return new TextBlock { Id = Guid.Parse("8fb0157e-39c5-40ee-9c33-c534d6bd2a46"), Type = TextBlockType.Text, Text = "If the triggering ability did not have both a critical success and critical failure condition, tempt fate fails, but you don't expend the Focus Point for Casting this Spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("e256ef8b-89de-4562-ba24-400ef7844629"),
                Level = "+8",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("73c48172-6df8-4ada-86b9-3821f3b17b40"), Type = TextBlockType.Text, Text = "The bonus on the saving throw is +2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c491ce5a-78ad-474f-bc27-886aaff2f1e6"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f4f999ec-4793-4fc0-9d09-813fc34c7043"), Traits.Instances.Cleric.ID);
            builder.Add(Guid.Parse("ba8a1d21-e4df-49a2-aa4e-58bd0f6aed4e"), Traits.Instances.Divination.ID);
            builder.Add(Guid.Parse("9529e1b3-c9ac-4198-8ee7-b8efab91981e"), Traits.Instances.Fortune.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0e4e8ab8-095a-4fa4-b804-12868dd63f5f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 397
            };
        }
    }
}
