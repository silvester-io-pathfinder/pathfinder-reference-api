using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AbundantStep : Template
    {
        public static readonly Guid ID = Guid.Parse("86700caa-5237-4fc5-a256-a1bd919676ff");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Abundant Step",
                Level = 4,
                Range = "15 feet or more.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Monk.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("855f00b1-aad9-4bbc-b465-5776b396b113"), Type = TextBlockType.Text, Text = "You move so fast you blur across planar boundaries. You teleport up to a distance equal to your Speed within your line of sight." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("2beb9e1f-d902-45c4-8348-7037d16a8105"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("8218311a-bd78-48cb-b4fd-693c67c0e891"), Traits.Instances.Conjuration.ID);
            builder.Add(Guid.Parse("965d6f18-f5d5-43e1-90f8-990dddb22e3e"), Traits.Instances.Monk.ID);
            builder.Add(Guid.Parse("dbff62d0-33ed-4ca6-8527-915802b19d83"), Traits.Instances.Teleportation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d969216b-730f-40fd-b729-562d87c64d4e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 401
            };
        }
    }
}
