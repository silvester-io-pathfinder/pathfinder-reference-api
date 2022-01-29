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
    public class Runtsage : Template
    {
        public static readonly Guid ID = Guid.Parse("851dcb95-ec31-40dd-87a8-09b5ede60ca3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Runtsage",
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
            yield return new TextBlock { Id = Guid.Parse("66e2d9bc-e155-4b21-9f70-45abe4b69923"), Type = TextBlockType.Text, Text = $"Unlike most of your kind, who dismiss goblins as embarrassments or expendable annoyances, you have studied the methodology behind their irresponsible and incomprehensible actions. You gain the {ToMarkdownLink<Models.Entities.Feat>("Adopted Ancestry", Feats.Instances.AdoptedAncestry.ID)} general feat and must select goblin as the feat's chosen ancestry. You also gain one 1st-level goblin ancestry feat." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("5e8946af-14d8-47bc-b34c-6ac2642406c2"), Traits.Instances.Hobgoblin.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8e8a47d-1ce6-4d24-af5c-616217b5b4c4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
