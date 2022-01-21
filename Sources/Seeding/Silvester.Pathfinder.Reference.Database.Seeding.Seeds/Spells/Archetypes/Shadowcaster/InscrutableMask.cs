using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class InscrutableMask : Template
    {
        public static readonly Guid ID = Guid.Parse("b07e2116-e5ff-47f1-aa7e-a8ab558fa68c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Inscrutable Mask",
                Level = 3,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af1bc4fd-a382-4bc4-9930-009df1265f9e"), Type = TextBlockType.Text, Text = "You shroud your form and features in an impenetrable mask of shadow. The mask grants you a +1 status bonus to Deception checks to Lie or Feint, Intimidation checks to Demoralize, and Stealth checks to Hide in areas of dim light or darkness." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("9c2882c0-10de-4749-9bd7-5ffbc193e7d6"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("08a45ca5-2c31-42b7-bb96-2a5cefb04220"), Type = TextBlockType.Text, Text = "The status bonus increases to +2." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("193b8b5d-2c31-4c73-b1a6-bbcc03a558bb"),
                Level = "9th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("9eec47da-4008-45a5-a364-9344337a9711"), Type = TextBlockType.Text, Text = "The status bonus increases to +3." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("616c1cfd-0295-4fe7-9259-8046864fea0b"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("dcde1ae6-432d-44ac-ad99-1fdcc507f679"), Traits.Instances.Disease.ID);
            builder.Add(Guid.Parse("5febc98f-67ef-4d49-ae69-81f16e1bcb25"), Traits.Instances.Evil.ID);
            builder.Add(Guid.Parse("1eb4ff82-6b8c-48b8-8831-73961e90b657"), Traits.Instances.Necromancy.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("169c7827-77ce-4358-bd86-16e01b98e259"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 227
            };
        }
    }
}