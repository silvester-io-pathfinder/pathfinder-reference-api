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
    public class DesperateFinisher : Template
    {
        public static readonly Guid ID = Guid.Parse("be6c8bc9-ad69-4920-9c50-7acc80efa9de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Desperate Finisher",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You complete the last action on your turn, and your turn has not ended yet.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("818fc7f8-77b9-4aa0-a42f-5519291b5881"), Type = TextBlockType.Text, Text = $"You throw everything into one last press. Use a single action that you know with the {ToMarkdownLink<Models.Entities.Trait>("press", Traits.Instances.Press.ID)} trait as part of Desperate Finisher. You forgo the ability to use reactions until the start of your next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ade493cc-c975-4379-a37b-7fe1f162411d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
