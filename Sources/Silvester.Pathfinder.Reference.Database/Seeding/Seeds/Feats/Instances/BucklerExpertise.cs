using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BucklerExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("5e42029a-508f-4dec-90a6-7a8caa704871");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Buckler Expertise",
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
            yield return new TextBlock { Id = Guid.Parse("c5e84aa3-7960-4026-afb9-ad633de60e45"), Type = TextBlockType.Text, Text = "You’ve learned a flexible way to position your buckler to provide more protection. When you (action: Raise a Shield) to gain a circumstance bonus to AC from a (item: buckler), increase the bonus from +1 to +2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("165db3f1-730a-4733-81a7-979c54f80bdf"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
