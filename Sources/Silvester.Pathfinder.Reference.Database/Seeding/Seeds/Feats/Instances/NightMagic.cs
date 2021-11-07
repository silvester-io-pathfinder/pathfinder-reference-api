using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class NightMagic : Template
    {
        public static readonly Guid ID = Guid.Parse("57f451c7-89d2-4189-960c-a66fef7fdb75");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Night Magic",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5e751097-d501-4ec9-b40f-719c791e5639"), Type = TextBlockType.Text, Text = "You can tap into the magic that runs through your blood. You gain (spell: animal form) (wolf only, using the statistics for a canine) and (spell: obscuring mist) as 2nd-level divine innate spells. You can cast each of these spells once per day." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1da41dc1-6960-4234-9bea-6b8dd99cc220"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
