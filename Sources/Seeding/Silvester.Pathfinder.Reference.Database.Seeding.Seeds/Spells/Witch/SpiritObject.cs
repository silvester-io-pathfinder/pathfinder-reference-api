using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpiritObject : Template
    {
        public static readonly Guid ID = Guid.Parse("036c4cc5-a099-4575-a687-3efa02e82b0c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Spirit Object",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 unattended object up to 1 Bulk.",
                ActionTypeId = ActionTypes.Instances.OneOrTwoActions.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fb739842-e512-462e-b558-7f9809343574"), Type = TextBlockType.Text, Text = "Using a sliver of Baba Yaga's power, you briefly bring an object to life. The object gains a means of locomotion, such as sprouting chicken legs, and Strides up to 25 feet to a space you decide within range. If you spent 2 actions Casting the Spell, the object then attacks one creature of your choice adjacent to its new space. Make a melee spell attack roll against the creature. On a success, the creature takes bludgeoning, piercing, or slashing damage (as appropriate for the object) equal to 1d4 plus your spellcasting ability modifier, and on a critical success, it takes double damage." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("713cdd89-0a12-4821-bbee-74bf911696cc"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("7baa1ece-1530-43ac-842b-528146c83687"), Type = TextBlockType.Text, Text = "Increase the maximum Bulk of the target by 1 and the damage by 1d4." }
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
            builder.Add(Guid.Parse("0ff571c3-6270-4394-8aeb-e7f16e5c6f1b"), Traits.Instances.Rare.ID);
            builder.Add(Guid.Parse("588f7866-9555-46f4-a34e-cfce8bcb9f2e"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("356c4257-ae8a-43b5-b8fa-2956ae3249ae"), Traits.Instances.Hex.ID);
            builder.Add(Guid.Parse("59b61a13-16c4-4cff-b946-c19b1a84d158"), Traits.Instances.Necromancy.ID);
            builder.Add(Guid.Parse("656c9bd9-9b2e-4d41-ac4c-16121484e483"), Traits.Instances.Witch.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4cb76e81-9582-4f14-b8b5-f5523b547251"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 32
            };
        }
    }
}
