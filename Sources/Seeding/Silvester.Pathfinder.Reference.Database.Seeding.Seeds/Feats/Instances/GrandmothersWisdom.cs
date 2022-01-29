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
    public class GrandmothersWisdom : Template
    {
        public static readonly Guid ID = Guid.Parse("2e5434b6-5aed-4b7e-94d9-ec77ebb31443");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grandmother's Wisdom",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4749688f-ec7f-432e-b886-8003e553df3b"), Type = TextBlockType.Text, Text = $"You carry the bones of your ancestors with you, and you can ask them for counsel. You can cast {ToMarkdownLink<Models.Entities.Spell>("augury", Spells.Instances.Augury.ID)} twice per day as a 2nd-level occult innate spell." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("36725054-5d7e-4d43-ac01-14c7e38cf5af"), Traits.Instances.Gnoll.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0230b302-611f-44e4-8a9d-a6ea871f4ca7"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
