using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Uncommon : Template
    {
        public static readonly Guid ID = Guid.Parse("77669ac3-df67-42f2-ad32-984b9dfa66d0");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Uncommon",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8712b4ec-4465-4980-af64-8520d757922e"), Type = TextBlockType.Text, Text = "Something of uncommon rarity requires special training or comes from a particular culture or part of the world. Some character choices give access to uncommon options, and the GM can choose to allow access for anyone. Less is known about uncommon creatures than common creatures. They typically can’t be summoned. The DC of Recall Knowledge checks related to these creature is increased by 2." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0bc1c3b-8502-4110-86cc-8a243cffab68"),
                SourceId = CoreRulebook.ID,
                Page = 637
            };
        }
    }
}
