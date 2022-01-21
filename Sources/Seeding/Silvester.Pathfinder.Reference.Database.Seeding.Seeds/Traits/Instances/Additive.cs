using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class Additive : Template
    {
        public static readonly Guid ID = Guid.Parse("9b4058c8-5257-4a20-bb5b-b7e9c521ce19");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Additive",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2a6ec329-ea6c-496d-91d2-836b90286a2b"), Type = TextBlockType.Text, Text = "Feats with the additive trait allow you to spend actions to add special substances to bombs or elixirs. You can add only one additive to a single alchemical item, and attempting to add another spoils the item. You can typically use actions with the additive trait only when you're creating an infused alchemical item, and some can be used only with the Quick Alchemy action. The additive trait is always followed by a level, such as additive 2. An additive adds its level to the level of the alchemical item you're modifying; the result is the new level of the mixture. The mixture's item level must be no higher than your advanced alchemy level." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75d410af-181e-4599-bac6-8baab2fe2cce"),
                SourceId = CoreRulebook.ID,
                Page = 75
            };
        }
    }
}
