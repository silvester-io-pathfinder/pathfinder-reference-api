using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AnticipatePeril : Template
    {
        public static readonly Guid ID = Guid.Parse("4bee021d-ccda-4d75-9b66-b3dc6f74b7f7");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Anticipate Peril",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 creature.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4b9bc651-e56f-45c1-8252-edda99562506"), Type = TextBlockType.Text, Text = "You grant the target brief foresight. The target gains a +1 status bonus to its next initiative roll, after which the spell ends." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1bced878-0138-475a-9623-0dc4a8f5b14a"),
                Level = "+2",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3d2c3833-ede3-4c7d-9c95-6fccb8c54809"), Type = TextBlockType.Text, Text = "The status bonus increases by 1, to a maximum of +4 at 7th level." }
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
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("c6745937-4688-402f-b1cb-72bbeb847d9c"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f326b2b2-d89a-47ca-be23-6230a93b6fb4"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 107
            };
        }
    }
}
