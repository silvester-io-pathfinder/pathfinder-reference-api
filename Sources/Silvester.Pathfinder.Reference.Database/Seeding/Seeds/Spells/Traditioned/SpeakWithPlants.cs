using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SpeakWithPlants : Template
    {
        public static readonly Guid ID = Guid.Parse("f1ab3438-9952-4921-ab1c-07faebeda112");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Speak With Plants",
                Level = 4,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7fd2d6fe-b453-460e-93ef-926ec445be5d"), Type = TextBlockType.Text, Text = "You can ask questions of and receive answers from plants, but the spell doesn’t make them more friendly or intelligent than normal. Most normal plants have a distinctive view of the world around them, so they don’t recognize details about creatures or know anything about the world beyond their immediate vicinity. Cunning plant monsters are likely to be terse and evasive, while less intelligent ones often make inane comments." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Plant.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("102a21cb-c7bc-4287-a980-a250670db2fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 370
            };
        }
    }
}
