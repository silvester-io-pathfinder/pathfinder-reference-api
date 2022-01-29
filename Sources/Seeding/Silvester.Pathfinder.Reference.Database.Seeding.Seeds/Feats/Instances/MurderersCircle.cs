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
    public class MurderersCircle : Template
    {
        public static readonly Guid ID = Guid.Parse("a133648e-d132-4dc9-9289-d500f81b8115");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Murderer's Circle",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("35d451b6-687c-42b9-99ab-fd20677b9f58"), Type = TextBlockType.Text, Text = $"You {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} a target within reach and then {ToMarkdownLink<Models.Entities.Action>("Step", Actions.Instances.Step.ID)} to any other open space adjacent to that target. Your target is then flat-footed against your next {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} this turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("21c71fed-d028-4987-88d7-0cd5020b607c"), Feats.Instances.ProvocatorDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("703fe728-3420-4a5e-8359-01b175b00af5"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4a429756-8d6c-4f44-90fa-6ffb0b0950cc"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
