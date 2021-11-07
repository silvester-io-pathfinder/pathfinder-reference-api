using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PackHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("ec6a0183-17ad-4786-93dd-96a2645e1674");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pack Hunter",
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
            yield return new TextBlock { Id = Guid.Parse("615fe3c2-ca88-473c-9275-5c822fa8dd8d"), Type = TextBlockType.Text, Text = "You were taught how to hunt as part of a pack. You gain a +2 circumstance bonus to checks to (action: Aid), and your allies gain a +2 circumstance bonus to checks to (action: Aid) you." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("61638f15-b1fd-4159-a616-686d52e8915c"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
