using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class SeeInvisibility : Template
    {
        public static readonly Guid ID = Guid.Parse("42c5b56f-3497-474d-9902-80f2eda13778");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "See Invisibility",
                Level = 2,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Divination.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba79ea8e-2611-429b-83c7-d53cd49d6e76"), Type = TextBlockType.Text, Text = "You can see invisible creatures and objects. They appear to you as translucent shapes, and they are concealed to you." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("48f5ad1e-0e55-49fb-9da8-047648f1dd7c"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ae4a5e0d-a862-401c-ade5-932f7c72c7d8"), Type = TextBlockType.Text, Text = "The spell has a duration of 8 hours." }
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Revelation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bbc0ef38-8945-40f1-b72e-aa21a2c9231c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 367
            };
        }
    }
}
