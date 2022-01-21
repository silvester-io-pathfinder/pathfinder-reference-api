using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PulverizingCascade : Template
    {
        public static readonly Guid ID = Guid.Parse("e610f3ec-d5a7-497d-8bf9-f8623550f22a");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pulverizing Cascade",
                Level = 3,
                Range = "120 feet.",
                Area = "10-foot radius, 20-foot-tall cylinder.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Reflex.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("40ba7e7a-1bad-4fb3-9977-8df7ec08728b"), Type = TextBlockType.Text, Text = "You raise a pair of towering waves and slam them into each other, crushing creatures caught between them. Creatures in the area take 5d6 bludgeoning damage with a basic Reflex save." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("616087b0-d6ff-4a9c-a50e-fae93fadef37"),
                Level = "+1",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("867860dd-1932-4729-bcb8-7888f5746733"), Type = TextBlockType.Text, Text = "Increase the damage by 2d6." }
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
            builder.Add(Guid.Parse("adca91f3-e46f-477a-b01f-438bb477f37e"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("1c85cbf7-fe75-466f-ab55-2150569d67d1"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("ac07e708-b45d-44c2-a0bd-96f33e82bf9d"), Traits.Instances.Water.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dbe0467e-0205-4db8-8862-7acdee1b33ea"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 201
            };
        }
    }
}