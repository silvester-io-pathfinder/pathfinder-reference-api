using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class EnhanceVictuals : Template
    {
        public static readonly Guid ID = Guid.Parse("969a5d86-e921-4432-a6b4-996a0e7ef07c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Enhance Victuals",
                Level = 2,
                CastTime = "1 minute.",
                Range = "Touch.",
                Duration = "1 hour.",
                Targets = "up to 1 gallon of non-magical water or up to 5 pounds of food.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.LongAction.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e2b92456-bacd-4cd6-be7e-dc83cf12d700"), Type = TextBlockType.Text, Text = "You transform the target into delicious fare, changing water into wine or another fine beverage or enhancing the food’s taste and ingredients to make it a gourmet treat." };
            yield return new TextBlock { Id = Guid.Parse("da3c267d-086c-477d-b09d-93c9f656beb4"), Type = TextBlockType.Text, Text = "Prior to the transformation, the spell attempts to counteract any poisons in the food or water. The food turns back to normal if not consumed before the duration expires, though any poisons that were counteracted are still gone." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("73b0cf81-d7f5-425d-b86b-f2e60d13ffad"), 
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ff9ebbb1-9e19-4236-8942-d19395f511dc"), Type = TextBlockType.Text, Text = "The number of gallons of water you can target increases by 1, or the number of pounds of food you can target increases by 5." }
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
            yield return MagicTraditions.Instances.Divine.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5ec1b26e-cce6-4832-bbf6-820f1e17ebc3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 335
            };
        }
    }
}
