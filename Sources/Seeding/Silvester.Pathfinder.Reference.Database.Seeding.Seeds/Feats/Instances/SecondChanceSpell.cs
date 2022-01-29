using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SecondChanceSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("fa4a4abf-3a00-4e70-8a7d-069a3f044147");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Second Chance Spell",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21377a2b-7db5-44d3-9ca2-f8c9c0a127b5"), Type = TextBlockType.Text, Text = $"When your target proves resilient to your magical deceptions, you can try them again on someone else. When you cast an {ToMarkdownLink<Models.Entities.Trait>("enchantment", Traits.Instances.Enchantment.ID)} spell that targets one creature and that creature critically succeeds at its Will save, you can {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} again before the end of your next turn on a different creature without expending an additional spell slot. The second casting doesn't grant you any benefits that you would normally gain for {ToMarkdownLink<Models.Entities.Rule>("Casting a Spell", Rules.Instances.CastASpell.ID)} from a spell slot." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("11dd47c6-2b65-4fd6-9cfc-6c3ebee64962"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
