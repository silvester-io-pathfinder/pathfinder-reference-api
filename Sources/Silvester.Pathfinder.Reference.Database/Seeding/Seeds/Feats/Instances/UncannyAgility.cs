using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UncannyAgility : Template
    {
        public static readonly Guid ID = Guid.Parse("75ee933d-fe0e-4c31-b53f-8201da7ebbf1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Uncanny Agility",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a52b09f4-f145-4913-b54d-88834432d2fd"), Type = TextBlockType.Text, Text = "You have near-supernatural poise that lets you move swiftly across the most unsteady surfaces. You gain the (feat: Steady Balance) skill feat. You can (action: Step) into difficult terrain caused by uneven ground, such as a rocky field or hilly incline." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5ccbbb6-4d1e-464e-95a6-2771697a9b05"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
