using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpeakWithAnimals : Template
    {
        public static readonly Guid ID = Guid.Parse("f773ca02-3d69-4845-be81-624f445fca91");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Speak With Animals",
                Level = 2,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f7b97001-bfed-4ae5-b038-a2bc48b8a688"), Type = TextBlockType.Text, Text = "You can ask questions of, receive answers from, and use the Diplomacy skill with animals. The spell doesn't make them more friendly than normal. Cunning animals are likely to be terse and evasive, while less intelligent ones often make inane comments." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("ad9e61de-56d3-45a2-97a1-e1d7dbedddd4"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a3b7f394-ef3b-4173-bd93-b22c02900559"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 370
            };
        }
    }
}
