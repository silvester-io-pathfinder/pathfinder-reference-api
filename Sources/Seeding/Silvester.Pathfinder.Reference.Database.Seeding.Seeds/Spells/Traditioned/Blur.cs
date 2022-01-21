using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Blur : Template
    {
        public static readonly Guid ID = Guid.Parse("4f77cd26-f3f0-4e6a-8424-b01480daadc4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Blur",
                Level = 2,
                Duration = "1 minute.",
                Range = "Touch.",
                Targets = "1 creature.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Illusion.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("de383eb7-ec7f-460b-8b53-87dafd843c6e"), Type = Utilities.Text.TextBlockType.Text, Text = "The target's form appears blurry. It becomes concealed. As the nature of this effect still leaves the target's location obvious, the target can't use this concealment to Hide or Sneak." };
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
            builder.Add(Guid.Parse("4beed3b7-1add-43fa-b450-84cf6980529a"), Traits.Instances.Illusion.ID);
            builder.Add(Guid.Parse("569874e6-8994-420b-bccf-1b815e3b519f"), Traits.Instances.Visual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf1f9da8-f71d-4123-8a78-7cfd906243b9"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 321
            };
        }
    }
}
