using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Deadeye : Template
    {
        public static readonly Guid ID = Guid.Parse("ada0fdf7-c1f8-4e42-93c4-f9d6ac0636ec");

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
            yield return new TextBlock { Id = Guid.Parse("ebdf7f1b-7650-43fb-a248-484a7c916b3a"), Type = TextBlockType.Text, Text = $"You relax your eyes, taking in the smallest movements of objects, stirring of grass and leaves, and other signs of the presence of hidden things, granting you the ability to locate invisible creatures. Until the start of your next turn, you can see invisible creatures and objects as silhouettes defined by the movement of air, slight depressions in the ground, and other tells that less-keen eyes would overlook, which makes them merely concealed from you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c622aa5-9503-4fad-ae03-dda5cbbcdd26"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
