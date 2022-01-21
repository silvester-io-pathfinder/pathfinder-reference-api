using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CombineElixirs : Template
    {
        public static readonly Guid ID = Guid.Parse("81541e4e-3bc4-42eb-959a-7ac2325110b3");

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
            yield return new TextBlock { Id = Guid.Parse("fa9440dc-d29f-42b1-8f1c-5ea5470a33af"), Type = TextBlockType.Text, Text = $"You've discovered how to mix two elixirs into a single hybrid concoction. You can spend 2 additional batches of infused reagents to add the effects of a second elixir to the one you're crafting. The second elixir must be in your {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("formula book", Items.AdventuringGears.Instances.FormulaBook.ID)} and at least 2 levels lower than your Advanced Alchemy level. The combination elixir is an alchemical item two levels higher than the higher of the two elixirs' levels. When this combination elixir is consumed, both the constituent elixirs take effect. For example, you can combine two elixirs of life to create a combined elixir that heals twice the normal amount, or you can combine a {ToMarkdownLink<Models.Entities.Potency>("lesser", Potencies.Instances.Lesser.ID)} {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("darkvision elixir", Items.AlchemicalElixirs.Instances.DarkvisionElixir.ID)} with a {ToMarkdownLink<Models.Entities.Potency>("lesser", Potencies.Instances.Lesser.ID)} {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("eagle-eye elixir", Items.AlchemicalElixirs.Instances.EagleEyeElixir.ID)} to both gain darkvision and find secret doors." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61056d9f-0eeb-495f-b607-4a3996ce633c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
