using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class LitanyOfRighteousness : Template
    {
        public static readonly Guid ID = Guid.Parse("23939a89-110d-4b11-be4d-42d9d5ea2f92");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Litany of Righteousness",
                Level = 7,
                Range = "30 feet.",
                Duration = "1 round.",
                Targets = "1 evil creature.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Champion.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9f341db5-becc-475f-9864-558b48c2bf5b"), Type = TextBlockType.Text, Text = "Your litany denounces an evildoer, rendering it susceptible to the powers of good. The target gains weakness 7 to good. The target then becomes temporarily immune to all of your litanies for 1 minute." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("af9e1d15-8832-4bc2-b8ee-48e2768a8b96"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("0dee91e8-7121-4a62-8b52-b2d91f4fd90f"), Type = TextBlockType.Text, Text = "The weakness increases by 1." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("708ef732-49d7-46c8-abad-c4fb1ecc315d"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("948fb7d5-85ae-4fe7-9f7b-6b0025845c06"), Traits.Instances.Champion.ID);
            builder.Add(Guid.Parse("5cd563d3-ee70-4d94-afba-86f1d23db4f3"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("146302ec-8909-48e5-a2bc-1eb0a31075eb"), Traits.Instances.Good.ID);
            builder.Add(Guid.Parse("cd6cd4bb-d6ee-44a1-9594-bdf640c99786"), Traits.Instances.Litany.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f2932908-867b-4f24-beac-ccdc46880d53"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 388
            };
        }
    }
}
