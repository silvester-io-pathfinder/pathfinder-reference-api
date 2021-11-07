using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Deadeye : Template
    {
        public static readonly Guid ID = Guid.Parse("f7ee58b3-b38d-4391-ad47-7b5e44106e8d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Deadeye",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3689b8b6-f6fe-4fe0-822a-4735ef31ff3c"), Type = TextBlockType.Text, Text = "You relax your eyes, taking in the smallest movements of objects, stirring of grass and leaves, and other signs of the presence of hidden things, granting you the ability to locate invisible creatures. Until the start of your next turn, you can see invisible creatures and objects as silhouettes defined by the movement of air, slight depressions in the ground, and other tells that less-keen eyes would overlook, which makes them merely concealed from you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d865e754-7ca0-4133-969e-1f87df9a1bb2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
