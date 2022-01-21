using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Tongues : Template
    {
        public static readonly Guid ID = Guid.Parse("f0583901-0af4-4771-9a6e-a033f62b9cdc");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Tongues",
                Level = 5,
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("17965ba8-55ed-468e-aaa1-04f793753449"), Type = TextBlockType.Text, Text = "The target can understand all words regardless of language and also speak the languages of other creatures. When in a mixed group of creatures, each time the target speaks, it can choose a creature and speak in a language that creature understands, even if the target doesn't know what language that is." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("6bb72eb1-90ed-46e6-8110-f74f997b034f"), 
                Level = "7th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("eb12abd4-1401-4448-a1f1-0ad8918ea15f"), Type = TextBlockType.Text, Text = "The duration is 8 hours." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("872e9551-7c6e-41c4-b645-56b172d1ba71"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("9bc66fd5-1e79-43fb-a134-dd8495677b37"), Traits.Instances.Divination.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2502bff9-cd59-4dca-9942-a1f030a6aa5a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 378
            };
        }
    }
}
