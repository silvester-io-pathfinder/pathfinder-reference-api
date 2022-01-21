using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EfficientApport : Template
    {
        public static readonly Guid ID = Guid.Parse("53aaad8f-4e75-4394-894a-3b06307144dc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Efficient Apport",
                Level = 1,
                Range = "60 feet.",
                Targets = "1 unattended object of light Bulk or less.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Wizard.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6af5db65-6844-4ee3-aa1a-589e8e9cbd1c"), Type = TextBlockType.Text, Text = "Walking over to an item to pick it up is so much effort. Whether it�s your spellbook, a reagent, or a glass of wine, it�s simply more efficient to call it to your hand. You teleport the target into your open hand. If you don�t have a hand free, it falls to the ground at your feet." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("92a49769-7c42-4157-acc6-a7152b00721e"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("527fbba7-d309-4885-b99d-5502be1b14a4"), Type = TextBlockType.Text, Text = "You can target an unattended object with a Bulk of 1 or less." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("e026231e-6f19-42af-aad0-69932693e578"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6edab280-f129-4612-894d-d1265682801c"), Type = TextBlockType.Text, Text = "The range increases to 120 feet, and you can target an unattended object with a Bulk of 1 or less." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("1924d398-82f0-4a12-8856-fe110795214b"),
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("1cadbe3a-f4ad-4e31-94b4-f4d814fb6a74"), Type = TextBlockType.Text, Text = "The range increases to 120 feet, and you can target an unattended object with a Bulk of 2 or less." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("7ad594cf-555b-4bc3-8dbe-dfbccfb6ce68"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("e8ea6a58-3142-4a13-ace3-94e488c5467f"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("a8d4fd40-d9d9-4aef-805f-2beaabeeb598"), Traits.Instances.Teleportation.ID);
            builder.Add(Guid.Parse("5575568c-5781-4610-9dbc-b2c01b81e450"), Traits.Instances.Wizard.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbbf720c-8fed-491b-9de6-b69ecb785f53"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 241
            };
        }
    }
}
