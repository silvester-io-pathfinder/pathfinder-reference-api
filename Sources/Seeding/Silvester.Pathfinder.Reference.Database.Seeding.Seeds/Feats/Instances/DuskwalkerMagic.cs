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
    public class DuskwalkerMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("9f11c780-870d-4f90-9b40-3865c2975346");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Duskwalker Magic",
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
            yield return new TextBlock { Id = Guid.Parse("eab6cd5d-77c9-4d8b-803e-c2476a546c1b"), Type = TextBlockType.Text, Text = $"Your connection to psychopomps gives you the power to glimpse the near future and protect corpses from the ravages of undeath. You can cast {ToMarkdownLink<Models.Entities.Spell>("augury", Spells.Instances.Augury.ID)} and {ToMarkdownLink<Models.Entities.Spell>("gentle repose", Spells.Instances.GentleRepose.ID)} each once per day as 2nd-level divine innate spells." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bcad0e5c-197c-45c9-8f6d-0a77f409c6a3"), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a07a4b4d-66fc-4bc1-a8f8-e5dd739f2f25"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
