using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Syncretism : Template
    {
        public static readonly Guid ID = Guid.Parse("430be89d-a309-455d-bb08-8b08a74f4da6");

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
            yield return new TextBlock { Id = Guid.Parse("281bd24b-4bba-46ca-89f1-a2c79e5cc44d"), Type = TextBlockType.Text, Text = $"You have come to see the overlap between two deities' teachings. Choose a second deity. You must meet their alignment requirements, and you are subject to their edicts and anathema. If you are a cloistered cleric, select one of that deity's domains, gaining the benefits of the {ToMarkdownLink<Models.Entities.Feat>("Expanded Domain Initiate", Feats.Instances.ExpandedDomainInitiate.ID)} feat with that domain. If you are a warpriest, you gain the favored weapon of that deity as a second favored weapon, and it gains the benefits of feats and abilities you have that affect your deity's favored weapon, such as from {ToMarkdownLink<Models.Entities.Feat>("Deadly Simplicity", Feats.Instances.DeadlySimplicity.ID)}. If you have a different doctrine than cloistered cleric or warpriest, either apply whichever of the above options is most appropriate for your doctrine, or, at the GM's discretion, add a benefit from the second deity more closely tied to your doctrine." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.FollowAnyReligion(Guid.Parse("735c149c-153f-4ae3-972b-e216930a280a"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c1308567-f70e-4996-a11f-3c9c743f27ec"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
