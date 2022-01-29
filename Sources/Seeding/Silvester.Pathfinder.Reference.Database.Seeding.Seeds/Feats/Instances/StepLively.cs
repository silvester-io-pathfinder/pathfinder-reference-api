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
    public class StepLively : Template
    {
        public static readonly Guid ID = Guid.Parse("ea45e929-6909-4763-b424-5a06db348e97");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Step Lively",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A Large or larger enemy ends a move action adjacent to you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34e2283e-7fc1-4e63-a9b6-6358c2de793f"), Type = TextBlockType.Text, Text = $"You are an expert at avoiding the lumbering footsteps of larger creatures. You {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} to another space adjacent to the enemy." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("70e5b44d-d7aa-4176-9ccd-49f378070981"), Traits.Instances.Halfling.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a026df98-1efb-4526-af19-670978629474"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
