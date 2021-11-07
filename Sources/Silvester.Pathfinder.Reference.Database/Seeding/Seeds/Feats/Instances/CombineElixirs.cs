using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CombineElixirs : Template
    {
        public static readonly Guid ID = Guid.Parse("0f525485-d4c0-4874-bd28-add50d1c4626");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Combine Elixirs",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You use Quick Alchemy to craft an alchemical item that has the elixir trait and is at least 2 levels lower than your Advanced Alchemy level.",
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("303cee32-0ec0-4b8e-b741-cb11f2a67483"), Type = TextBlockType.Text, Text = "You’ve discovered how to mix two elixirs into a single hybrid concoction. You can spend 2 additional batches of infused reagents to add the effects of a second elixir to the one you’re crafting. The second elixir must be in your (item: formula book) and at least 2 levels lower than your Advanced Alchemy level. The combination elixir is an alchemical item two levels higher than the higher of the two elixirs’ levels. When this combination elixir is consumed, both the constituent elixirs take effect. For example, you can combine two elixirs of life to create a combined elixir that heals twice the normal amount, or you can combine a (item: lesser darkvision elixir | Darkvision Elixir lesser) with a (item: lesser eagle-eye elixir | Eagle-Eye Elixir lesser) to both gain darkvision and find secret doors." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2aa6339f-b02a-43cf-9a98-8eca72cead56"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
