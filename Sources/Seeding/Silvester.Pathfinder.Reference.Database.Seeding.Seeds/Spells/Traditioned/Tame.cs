using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Tame : Template
    {
        public static readonly Guid ID = Guid.Parse("b8513b78-5dc9-4913-84f2-ae121de4d52e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tame",
                Level = 1,
                Range = "10 feet.",
                Duration = "1 minute.",
                Targets = "1 non-hostile domesticated animal.",
                IsSavingThrowBasic = false,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b9cdbc53-c19c-4431-a56f-76b81b6f3adf"), Type = TextBlockType.Text, Text = "As you make comforting sounds and gestures, you approach the target in a friendly manner combining caution and confidence. You improve the target's attitude to you by one step (unfriendly to neutral, neutral to friendly, friendly to helpful) for the duration of the spell unless it succeeds at a Will save. Afterward, the target is temporarily immune for 1 day." };
            yield return new TextBlock { Id = Guid.Parse("10202f37-a351-4dac-bbbc-9372891267b8"), Type = TextBlockType.Text, Text = "This spell works on only domesticated animals; for example, you could use it on guard dogs or stray dogs, but not feral dogs or wolves. If the socialization of the animal is in question, the decision is up to the GM." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("faee8884-abfd-439f-bcbc-f215f3b77ee9"),
                Level = "3rd",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("31de7148-de3a-4d1e-89e5-4f6da5b5b6e2"), Type = TextBlockType.Text, Text = "The duration becomes 10 minutes." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("9cfd80f2-7a46-4fe7-a5d7-7357a1cbc972"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5183394d-59cb-4a15-90dc-dcf0f3afecb7"), Type = TextBlockType.Text, Text = "The duration becomes 1 hour." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Occult.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ab623bbb-4ca1-4ff8-a3f0-58d4ef981e6b"), Traits.Instances.Auditory.ID);
            builder.Add(Guid.Parse("5e77183d-c287-4b44-870f-22070964119a"), Traits.Instances.Cantrip.ID);
            builder.Add(Guid.Parse("2059c12a-f2bd-455c-bf52-f9362797b0a4"), Traits.Instances.Enchantment.ID);
            builder.Add(Guid.Parse("6eed085d-4243-4a43-86b2-c80eb1ce2a90"), Traits.Instances.Mental.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f1505e4-6a4d-45a6-8685-e181b7fc449a"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 135
            };
        }
    }
}
