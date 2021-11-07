using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MercifulElixir : Template
    {
        public static readonly Guid ID = Guid.Parse("f168a784-2148-43a9-8000-ee159ab20423");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Merciful Elixir",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You craft an elixir of life using Quick Alchemy, and that elixir is at least 2 levels lower than your Advanced Alchemy level.",
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e868c1a5-d8fc-4846-ab12-79d759728a7e"), Type = TextBlockType.Text, Text = "You mix a special additive into your elixir that calms the drinker’s body and mind. The elixir of life attempts to counteract one fear effect or one effect imposing the paralyzed condition on the drinker using the item’s level and a counteract modifier equal to your class DC – 10." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a8dc686-c67f-4751-b20d-d37f0226b3de"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
