using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class DeathWard : Template
    {
        public static readonly Guid ID = Guid.Parse("3c902d87-38ff-4aad-acb3-266811986252");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Death Ward",
                Level = 5,
                Range = "Touch.",
                Targets = "1 living creature touched.",
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Abjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f42c2728-6212-4aea-a67f-0c87c746330a"), Type = Utilities.Text.TextBlockType.Text, Text = "You shield a creature from the ravages of negative energy. It receives a +4 status bonus to saves against death and negative effects, gains negative resistance 10, and suppresses the effects of the doomed condition." };
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
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("a9e3754e-7b0b-4cbf-bbed-1c7aa4ba1c33"), Traits.Instances.Abjuration.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5b339dc6-9603-4367-9130-5e5848e9ca3f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 328
            };
        }
    }
}
