using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrcWarmaskTheGods : Template
    {
        public static readonly Guid ID = Guid.Parse("df827cb3-12d9-4ca1-b688-c931c8647c19");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orc Warmask - The Gods",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("48d65c5e-1b27-405c-b106-d3d06cc20c99"), Type = TextBlockType.Text, Text = "The source of your (item: warmask | warmask the gods)’s power is from the gods. You become trained in Religion and your mask&#39;s magical tradition is (trait: divine)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4c9ca0a5-5baa-4d66-b0d8-ae21ac4d857d"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
