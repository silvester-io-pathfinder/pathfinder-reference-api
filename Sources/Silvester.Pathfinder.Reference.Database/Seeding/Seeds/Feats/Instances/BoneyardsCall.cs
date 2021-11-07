using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BoneyardsCall : Template
    {
        public static readonly Guid ID = Guid.Parse("e34de0d4-1961-48d1-a441-1c6fdf0c88bc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Boneyard's Call",
                Level = 17,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8d03104-3afb-41db-b9b3-42cae3c71979"), Type = TextBlockType.Text, Text = "You have a powerful connection to the Boneyard and its courts, granting you the ability to travel to and from the Boneyard. You gain (spell: plane shift) as a divine innate spell. You can cast it twice per week. This can be used only to travel to the Boneyard or from the Boneyard to the Material Plane. Due to your unique connection to the Boneyard, your body serves as the focus, and you don&#39;t require a tuning fork." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("699ad8fd-707e-4ca1-8901-49d98b8680ee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
