using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealingBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("7d828639-4c3e-4ce4-bf6c-2514ad1cf42f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healing Bomb",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You craft an elixir of life using Quick Alchemy, and that elixir is at least 2 levels lower than your advanced alchemy level.",
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b6b26898-e60b-4f61-aa94-0ee940762a54"), Type = TextBlockType.Text, Text = $"By adding a special catalyst, you transform a healing elixir into a topical projectile. You grant the elixir the {ToMarkdownLink<Models.Entities.Trait>("bomb", Traits.Instances.Bomb.ID)} trait. If you throw a minor {ToMarkdownLink<Models.Items.Instances.AlchemicalElixir>("elixir of life", Items.AlchemicalElixirs.Instances.ElixirOfLife.ID)} bomb at a willing target, you hit even on a failure, though not on a critical failure. If your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} with this elixir bomb hits a living target, the target regains Hit Points as if it had consumed the elixir. On a critical success, the target also gains the elixir's item bonus to saving throws against diseases and poisons for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9654b094-b43f-469e-8c0d-aa30959e4273"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
