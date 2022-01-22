using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HoppingStride : Template
    {
        public static readonly Guid ID = Guid.Parse("4565e455-722c-4762-b1ed-c4750f1f4c1d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hopping Stride",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("adfa432c-5abe-4ba3-86eb-5ade7bb625c8"), Type = TextBlockType.Text, Text = $"You've internalized the hopping gait of your vampiric forebear. {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)} up to a distance equal to your Speed – 10 feet. During this {ToMarkdownLink<Models.Entities.Action>("Stride", Actions.Instances.Stride.ID)}, instead of moving through each space normally, you hop over every other square between your starting space and your ending space. These hops aren't high enough to jump over a creature or other significant obstacle in your way, but they avoid difficult terrain, hazardous terrain, pressure plates, or hazards on the ground or up to a foot above it in the spaces you hopped over." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("95176cd8-42c5-4162-b73f-47151db93bed"), Feats.Instances.RuShi.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ec87896-b00b-4a00-a6e8-6599a8fdabd8"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
