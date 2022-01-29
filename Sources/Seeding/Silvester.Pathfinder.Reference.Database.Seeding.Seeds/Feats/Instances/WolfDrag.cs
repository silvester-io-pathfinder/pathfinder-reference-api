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
    public class WolfDrag : Template
    {
        public static readonly Guid ID = Guid.Parse("3eaf8c35-39a2-4fd2-aef2-97a2584f313c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wolf Drag",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c67d36cb-1035-411f-871d-947bf073b50e"), Type = TextBlockType.Text, Text = $"You rip your enemy off their feet. Make a wolf jaw {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}. Your wolf jaw gains the {ToMarkdownLink<Models.Entities.Trait>("fatal", Traits.Instances.Fatal.ID)} d12 trait for this {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, and if the attack succeeds, you knock the target prone." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7ad35f8e-f966-41c7-9d49-a8cd7a3090d5"), Feats.Instances.WolfStance.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("10917508-64cf-4ab5-b12f-6453e1441af8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
