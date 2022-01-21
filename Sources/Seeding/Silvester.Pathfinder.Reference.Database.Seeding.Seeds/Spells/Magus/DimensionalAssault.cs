using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DimensionalAssault : Template
    {
        public static readonly Guid ID = Guid.Parse("ed51ae59-f69a-4a01-9fbd-6597292c2602");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dimensional Assault",
                Level = 1,
                Range = "Half your Speed.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Magus.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("51b4512d-6844-4fcd-a696-946794c9bc86"), Type = TextBlockType.Text, Text = "You tumble through space, making a short dimensional hop to better position yourself for an attack. Teleport to any square in range that's within reach of a creature, and then make a melee Strike against one creature within your reach." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("b0115469-a1d8-4144-8cc1-0cf63f50ec86"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8cb8cd03-0759-47f6-9879-b2544173966b"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("5e5faf8d-841a-4952-90fd-5443787cabaa"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("99b8187d-52a1-4e4f-b9a6-2628ae566810"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5066c062-deba-472f-ad12-18a9a9671c92"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 143
            };
        }
    }
}
