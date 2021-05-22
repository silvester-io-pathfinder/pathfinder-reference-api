using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class PurifyFoodAndDrink : Template
    {
        public static readonly Guid ID = Guid.Parse("c4e90b06-cae9-4c8e-9dcb-69aa89084597");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Purify Food and Drink",
                Level = 1,
                Range = "Touch.",
                Targets = "1 cubic foot of contaminated food or water.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Necromancy.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4fdd948c-9083-4ba2-a1f4-bb7d3137b9ca"), Type = TextBlockType.Text, Text = "You remove toxins and contaminations from food and drink, making them safe to consume. This spell doesn’t prevent future contamination, natural decay, or spoilage. One cubic foot of liquid is roughly 8 gallons." };
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

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d50c8c55-905f-4d59-9c80-181fed987230"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 362
            };
        }
    }
}
