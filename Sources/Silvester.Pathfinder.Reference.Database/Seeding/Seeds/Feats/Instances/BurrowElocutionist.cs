using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BurrowElocutionist : Template
    {
        public static readonly Guid ID = Guid.Parse("646c71ad-31d4-46d6-87e1-e268a85477c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Burrow Elocutionist",
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
            yield return new TextBlock { Id = Guid.Parse("d56aa7dc-377a-407c-b4fb-e0dd606b5e6b"), Type = TextBlockType.Text, Text = "You recognize the chittering of ground creatures as its own peculiar language. You can ask questions of, receive answers from, and use the Diplomacy skill with animals that have a burrow Speed, such as badgers, ground squirrels, moles, and prairie dogs. The GM determines which animals count for this ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43a967f4-43ff-4987-8f16-2ed2150e6d82"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
