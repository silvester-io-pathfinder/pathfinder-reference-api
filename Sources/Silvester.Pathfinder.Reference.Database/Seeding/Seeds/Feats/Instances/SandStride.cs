using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SandStride : Template
    {
        public static readonly Guid ID = Guid.Parse("3817c245-1d51-46bb-b194-f311721869f3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sand Stride",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c8429d7c-7526-4d0a-ace9-2522b025925f"), Type = TextBlockType.Text, Text = "The camel (action: Strides | Stride) twice with a +5-foot circumstance bonus to Speed, ignoring difficult terrain caused by rubble, sand, and uneven ground made of earth and stone." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1aa46d68-5df4-4e45-8cfa-bd3c1ac76d12"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
