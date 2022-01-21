using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class StoneTell : Template
    {
        public static readonly Guid ID = Guid.Parse("181717d7-fbb3-448c-9d15-91d5e9c74b77");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Stone Tell",
                Level = 6,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1d613f3f-d1fb-4d11-a215-1fed8828a60b"), Type = TextBlockType.Text, Text = "You can ask questions of and receive answers from natural or worked stone. While stone is not intelligent, you speak with the natural spirits of the stone, which have a personality colored by the type of stone, as well as by the type of structure the stone is part of, for worked stone. A stone's perspective, perception, and knowledge give it a worldview different enough from a human's that it doesn't consider the same details important. Stones can mostly answer questions about creatures that touched them in the past and what is concealed beneath or behind them." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("22a66d07-19e5-4982-834b-571f3bdf05e8"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("64e8937e-0bff-418d-b222-a881c97b0e62"), Traits.Instances.Evocation.ID);
            builder.Add(Guid.Parse("f401cf56-9b45-4e7e-b000-577362b79c15"), Traits.Instances.Earth.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ff38c275-7b30-4155-bc6f-6cec50e2366b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 374
            };
        }
    }
}
