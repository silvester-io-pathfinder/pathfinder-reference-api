using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonLesserServitor : Template
    {
        public static readonly Guid ID = Guid.Parse("e1cd1e7e-3582-4b9c-8298-ce5aafbee148");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Lesser Servitor",
                Level = 1,
                Range = "30 feet.",
                Duration = "Sustained up to 1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6db4b78-391e-47d7-a5c8-e9d2bab98a36"), Type = TextBlockType.Text, Text = "While deities jealously guard their most powerful servants from the summoning spells of those who aren�t steeped in the faith, this spell allows you to conjure an inhabitant of the Outer Sphere with or without the deity�s permission. You summon a celestial, monitor, or fiend whose level is �1 to fight on your behalf. Alternatively, you can choose a magical animal from the Outer Sphere as your lesser servitor. This animal is your choice of an eagle, guard dog, or raven (Bestiary 2 221). It gains the alignment matching your deity (or you, if you don�t have a deity) and has the following trait depending on the alignment it gained: celestial for lawful, monitor for neutral, or fiend for evil." };
            yield return new TextBlock { Id = Guid.Parse("a435e1f6-40d0-4cfc-b29d-b6e60c81f871"), Type = TextBlockType.Text, Text = "You can�t summon a creature if it is opposed to your deity�s alignment on either axis (or opposed to your alignment if you don�t follow a deity). For example, if you deity is lawful good, you can�t summon a chaotic or evil creature. The GM might determine that deities restrict specific types of creatures even if their alignments aren�t diametrically opposed. For example, Pharasma would restrict the summoning of sahkils." };
            yield return new TextBlock { Id = Guid.Parse("82a46915-1e7c-49ae-bb8e-94a91b9d135e"), Type = TextBlockType.Text, Text = "Heightening the spell increases the maximum level of creature you can summon and might add additional animal servitors, which otherwise work like the eagle, guard dog, and raven." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("8270cf11-f3b2-4602-8478-4d8e74c1657b"),
                Level = "2nd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("f6eff563-e744-4957-9c67-5616424e0a97"), Type = TextBlockType.Text, Text = "Level 1." }
                }
            };
            
            yield return new SpellHeightening
            {
                Id = Guid.Parse("92543316-f10d-4e8e-a1dd-9848f0f2058d"),
                Level = "3rd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("7835dbe5-04e6-4756-928e-3ae7b9df6561"), Type = TextBlockType.Text, Text = "Level 2. You can summon a black bear (Bestiary 2 36), giant bat, or leopard." }
                }
            };
            
            yield return new SpellHeightening
            {
                Id = Guid.Parse("d9aacf1a-3e7e-4cca-99f1-68b03fe7da7d"),
                Level = "4th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("03f36557-98e6-47a9-a4f4-5e7728cd5b0f"), Type = TextBlockType.Text, Text = "Level 3. You can summon a great white shark or tiger." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("0fd87cf2-79e9-400d-acf5-896ca793ebcd"), Traits.Instances.Conjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("452b05bc-3346-4606-b2d0-c39534d9985b"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 134
            };
        }
    }
}
