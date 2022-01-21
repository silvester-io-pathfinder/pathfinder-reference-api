using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class FormulaBook : Template
    {
        public static readonly Guid ID = Guid.Parse("c2ab81a5-73f9-473d-ac8e-7d8f7008d7be");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear 
            {
                Id = ID,
                Name = "Formula Book",
            };
        }

        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("0c14c2f1-0917-475e-94bd-362b01cc6b05"), "A formula book holds the formulas necessary to make items other than the common equipment from this chapter; alchemists typically get one for free. Each formula book can hold the formulas for up to 100 different items. Formulas can also appear on parchment sheets, tablets, and almost any other medium; there's no need for you to copy them into a specific book as long as you can keep them on hand to reference them.");;
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("ece6e249-d282-432b-bba1-2eb22225e814"),
                Name = "Formula Book (Blank)",
                Hands = "1",
                Level = 0,
                Price = 100,
                BulkId = Bulks.Instances.LightBulk.ID,
                RarityId = Rarities.Instances.Common.ID,
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec8a4a5d-8854-480c-8a9b-9fc3aa34e318"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 290
            };
        }
    }
}
