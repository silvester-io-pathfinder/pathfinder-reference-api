using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HoppingStride : Template
    {
        public static readonly Guid ID = Guid.Parse("f837f245-4c6e-4dd7-9d31-310bc8f2f97a");

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
            yield return new TextBlock { Id = Guid.Parse("ec2b325b-2aba-4aba-942c-ea57fa1c9a32"), Type = TextBlockType.Text, Text = "You’ve internalized the hopping gait of your vampiric forebear. (action: Stride) up to a distance equal to your Speed – 10 feet. During this (action: Stride), instead of moving through each space normally, you hop over every other square between your starting space and your ending space. These hops aren’t high enough to jump over a creature or other significant obstacle in your way, but they avoid difficult terrain, hazardous terrain, pressure plates, or hazards on the ground or up to a foot above it in the spaces you hopped over." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6d1acfbf-4d18-4122-9277-38f6e55c3513"), Feats.Instances.RuShi.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("48d502b9-ca3b-42d6-b2ca-1abbc7e0c3eb"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
