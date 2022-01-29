using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AmbushAwareness : Template
    {
        public static readonly Guid ID = Guid.Parse("0d50bb7b-79df-4a8f-9547-47af28885a99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ambush Awareness",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9c666f99-bcde-45e3-8bb8-1517dbcef017"), Type = TextBlockType.Text, Text = $"You gain a +2 circumstance bonus to Perception checks attempted as initiative rolls. Additionally, if your initiative roll result is tied with that of an opponent, you go first, regardless of whether you rolled Perception or not." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("10af0fb6-ed68-43a2-92bd-653004663f44"), Traits.Instances.Goloma.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45f256c5-3424-4efa-bd69-79a95fb6d92c"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
