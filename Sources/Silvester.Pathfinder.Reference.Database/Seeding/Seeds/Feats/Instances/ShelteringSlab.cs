using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShelteringSlab : Template
    {
        public static readonly Guid ID = Guid.Parse("e3d801dd-8758-4e72-8eb6-0a1deb4c1321");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sheltering Slab",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5e38a65b-9e9b-4476-a585-f22888ee9d01"), Type = TextBlockType.Text, Text = "The stone around you is your ally, and you have learned to use it to shore up your weaknesses. As long as you remain on the ground and are adjacent to a vertical stone wall that rises to your height or taller, you aren’t flat-footed against attacks as a result of being flanked. This works even if you are at the outside corner of the wall." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41b86dd2-2e90-4b14-864a-65bd7d88011b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
