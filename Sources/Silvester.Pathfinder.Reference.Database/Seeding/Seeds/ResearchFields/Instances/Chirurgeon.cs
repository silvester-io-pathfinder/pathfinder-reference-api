using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ResearchFields.Instances
{
    public class Chirurgeon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You concentrate on healing others with alchemy. You start with the formulas for two of the following in your formula book, in addition to your other formulas: lesser antidote, lesser antiplague, or minor elixir of life." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As long as your proficiency rank in Medicine is trained or better, you can attempt a Crafting check instead of a Medicine check for any of Medicine's untrained and trained uses." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new ChoiceEffect
            {
                Id = Guid.Parse(""),
                Choices = new[]
                {
                    new GainSpecificElixirFormulaEffect
                    {
                        Id = Guid.Parse(""),
                        AlchemicalElixirId = AlchemicalElixirs.Instances.Antidote.ID,
                        PotencyId = Potencies.Instances.Lesser.ID
                    },
                    new GainSpecificElixirFormulaEffect
                    {
                        Id = Guid.Parse(""),
                        AlchemicalElixirId = AlchemicalElixirs.Instances.Antiplague.ID,
                        PotencyId = Potencies.Instances.Lesser.ID
                    },
                    new GainSpecificElixirFormulaEffect
                    {
                        Id = Guid.Parse(""),
                        AlchemicalElixirId = AlchemicalElixirs.Instances.ElixirOfLife.ID,
                        PotencyId = Potencies.Instances.Minor.ID
                    }
                }
            };

            //TODO: Add Medicine -> Crafting check effect.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 73
            };
        }
    }
}
