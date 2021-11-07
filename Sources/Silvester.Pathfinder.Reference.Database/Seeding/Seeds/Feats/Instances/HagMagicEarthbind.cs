using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HagMagicEarthbind : Template
    {
        public static readonly Guid ID = Guid.Parse("fbe02679-437d-4a93-819d-a210d41182c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hag Magic - Earthbind",
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
            yield return new TextBlock { Id = Guid.Parse("dc68d49a-0ace-4a6e-b4c2-162b9f098b11"), Type = TextBlockType.Text, Text = "You can cast (spell: earthbind) once per day as a 4th-level occult innate spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7b383fab-481b-45a1-9e6a-9bef830bfa35"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
