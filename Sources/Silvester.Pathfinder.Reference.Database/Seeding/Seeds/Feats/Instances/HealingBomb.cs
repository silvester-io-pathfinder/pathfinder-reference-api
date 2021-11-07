using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealingBomb : Template
    {
        public static readonly Guid ID = Guid.Parse("8461907d-e0f9-4a19-bbb7-327c3492ad00");

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
            yield return new TextBlock { Id = Guid.Parse("a78f096d-cc7e-4b97-8e36-9d4303f1f9be"), Type = TextBlockType.Text, Text = "By adding a special catalyst, you transform a healing elixir into a topical projectile. You grant the elixir the (trait: bomb) trait. If you throw an (item: elixir of life | Elixir of Life minor) bomb at a willing target, you hit even on a failure, though not on a critical failure. If your (action: Strike) with this elixir bomb hits a living target, the target regains Hit Points as if it had consumed the elixir. On a critical success, the target also gains the elixir’s item bonus to saving throws against diseases and poisons for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("262bb640-77a0-4f96-ae39-e7deeef29f04"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
