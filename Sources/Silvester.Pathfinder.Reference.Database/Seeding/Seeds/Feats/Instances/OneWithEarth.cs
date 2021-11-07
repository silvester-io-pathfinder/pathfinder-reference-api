using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneWithEarth : Template
    {
        public static readonly Guid ID = Guid.Parse("098d0732-c726-4914-be27-74c2da84fddf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One With Earth",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("16706000-d5e3-4057-a7d1-6c722a99c08d"), Type = TextBlockType.Text, Text = "You’ve learned to harness your connection to the earth to travel through it. You gain a burrow Speed of 15 feet." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c33c7dde-c581-4f63-b788-c6b8b73443c4"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
