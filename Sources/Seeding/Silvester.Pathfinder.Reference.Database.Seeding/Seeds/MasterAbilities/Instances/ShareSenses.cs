using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class ShareSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("d3c226b2-fe5c-470c-b241-e3c8f1529a42");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Share Senses", 
                Description = "Once every 10 minutes, you can use a single action with the concentrate trait to project your senses into your familiar. When you do, you lose all sensory information from your own body, but can sense through your familiar's body for up to 1 minute. You can Dismiss this effect."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5ac401b-ca68-4d36-a271-8061b3c4a837"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 147
            };
        }
    }
}
