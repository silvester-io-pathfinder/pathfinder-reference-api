using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Syncretism : Template
    {
        public static readonly Guid ID = Guid.Parse("14edb027-65f3-47e3-b644-6c7d45b9efbe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Syncretism",
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
            yield return new TextBlock { Id = Guid.Parse("e62b0516-7fa7-44c9-a59e-7d6b5ff6ab40"), Type = TextBlockType.Text, Text = "You have come to see the overlap between two deities’ teachings. Choose a second deity. You must meet their alignment requirements, and you are subject to their edicts and anathema. If you are a cloistered cleric, select one of that deity’s domains, gaining the benefits of the (feat: Expanded Domain Initiate) feat with that domain. If you are a warpriest, you gain the favored weapon of that deity as a second favored weapon, and it gains the benefits of feats and abilities you have that affect your deity’s favored weapon, such as from (feat: Deadly Simplicity). If you have a different doctrine than cloistered cleric or warpriest, either apply whichever of the above options is most appropriate for your doctrine, or, at the GM’s discretion, add a benefit from the second deity more closely tied to your doctrine." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.FollowAnyReligion(Guid.Parse("1920fd94-1ad7-4f26-943b-b6548ea1e4f3"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ec9d7fbf-1d92-40f0-b3e0-56dd52b9d659"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
