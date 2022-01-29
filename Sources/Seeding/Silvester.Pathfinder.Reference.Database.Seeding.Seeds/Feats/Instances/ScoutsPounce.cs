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
    public class ScoutsPounce : Template
    {
        public static readonly Guid ID = Guid.Parse("daccf5d6-baff-4581-8a73-5370bc07f863");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scout's Pounce",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3af1a97b-fd4f-4195-8dcf-5e130fd2de48"), Type = TextBlockType.Text, Text = $"You leap from the shadows to strike your foes. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to your Speed, then {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} twice. If you were hidden or unnoticed by the target of these {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)}, your foe is flat-footed against both attacks. Your multiple attack penalty applies normally for both attacks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4077759e-6704-474d-bb49-51b10f922771"), Feats.Instances.ScoutDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fe522d3f-ee73-4fcb-84f3-2e4bf6ea8eac"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
