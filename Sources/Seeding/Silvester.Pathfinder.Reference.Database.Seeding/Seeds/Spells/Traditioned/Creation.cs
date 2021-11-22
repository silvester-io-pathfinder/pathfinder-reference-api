using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Creation : Template
    {
        public static readonly Guid ID = Guid.Parse("311b0146-7b80-4594-800f-b0046237d47f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Creation",
                Level = 4,
                Range = "0 feet.",
                CastTime = "1 minute.",
                Duration = "1 hour.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10f19591-1df1-4976-802c-12a27265350f"), Type = Utilities.Text.TextBlockType.Text, Text = "You conjure a temporary object from eldritch energy. It must be of vegetable matter (such as wood or paper) and 5 cubic feet or smaller. It can't rely on intricate artistry or complex moving parts, never fulfills a cost or the like, and can't be made of precious materials or materials with a rarity of uncommon or higher. It is obviously temporarily conjured, and thus can't be sold or passed off as a genuine item." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            { 
                Id = Guid.Parse("480f3fc8-55c9-4961-8572-5cc86cc4ca85"), 
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("10273eee-70b6-4b64-9119-e1ca2dc37a7f"), Type = Utilities.Text.TextBlockType.Text, Text = "The item is metal and can include common minerals, like feldspar or quartz." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("240ef876-e87e-44e2-9310-24aa54a55f78"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 326
            };
        }
    }
}
