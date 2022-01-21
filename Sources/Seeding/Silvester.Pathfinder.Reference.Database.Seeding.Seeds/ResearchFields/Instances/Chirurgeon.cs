using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ResearchFields.Instances
{
    public class Chirurgeon : Template
    {
        public static readonly Guid ID = Guid.Parse("28d483d6-b63b-4aba-9aad-a6aa3b7bcbc3");

        protected override ResearchField GetResearchField()
        {
            return new ResearchField
            {
                Id = ID, 
                Name = "Chirurgeon", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2d7bb12c-d10a-4767-a5c9-867d88546653"), Type = TextBlockType.Text, Text = "You concentrate on healing others with alchemy. You start with the formulas for two of the following in your formula book, in addition to your other formulas: lesser antidote, lesser antiplague, or minor elixir of life." };
            yield return new TextBlock { Id = Guid.Parse("0b8db4fc-9e00-4b3e-8802-d445f30c71eb"), Type = TextBlockType.Text, Text = "As long as your proficiency rank in Medicine is trained or better, you can attempt a Crafting check instead of a Medicine check for any of Medicine's untrained and trained uses." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("d79e0e38-4f50-4358-9eb6-b5fbef5ecf61"), or =>
            {
                or.GainSpecificElixirFormula(Guid.Parse("2ed5460c-8a51-40ec-ac88-ce9cdee4cf97"), Items.AlchemicalElixirs.Instances.Antidote.ID, Potencies.Instances.Lesser.ID);
                or.GainSpecificElixirFormula(Guid.Parse("18f05ec4-129e-4f7c-bb8d-bbab60576fa2"), Items.AlchemicalElixirs.Instances.Antiplague.ID, Potencies.Instances.Lesser.ID);
                or.GainSpecificElixirFormula(Guid.Parse("00314b51-3e7e-4698-8379-36a386e03014"), Items.AlchemicalElixirs.Instances.ElixirOfLife.ID, Potencies.Instances.Minor.ID);
            });

            //TODO: Add Medicine -> Crafting check effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7cc4cfe1-6ec4-4454-936e-d959523d7649"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
