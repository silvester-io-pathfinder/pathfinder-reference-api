using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class ForbiddingWard : Template
    {
        public static readonly Guid ID = Guid.Parse("4ccee2aa-e572-4c5c-b117-870c1870b06d");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Forbidding Ward",
                Level = 1,
                Range = "30 feet.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                Targets = "1 ally and 1 enemy.",
                SpellTypeId = SpellTypes.Instances.Cantrip.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ea9ab626-e12b-4189-a847-b4ddebcdc28c"), Type = TextBlockType.Text, Text = "You ward an ally against the attacks and hostile spells from the target enemy. The target ally gains a +1 status bonus to Armor Class and saving throws against the target enemy's attacks, spells, and other effects." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("466e1b93-8fff-433f-a16b-f9fc29fbc608"), 
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("a7927bb4-5bf4-43a5-ab30-5eb2d3931ec3"), Type = TextBlockType.Text, Text = "The status bonus increases to +2." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("cd41909c-d90b-4301-b535-7dd98dbc1837"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("3a2eaaa0-c184-49b9-9c5b-78e3d01e343a"), Traits.Instances.Cantrip.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e1ef050d-d396-4e14-a62a-7409609e46db"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 339
            };
        }
    }
}
