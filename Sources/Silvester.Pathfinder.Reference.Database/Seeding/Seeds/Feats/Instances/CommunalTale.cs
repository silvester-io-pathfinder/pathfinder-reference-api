using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CommunalTale : Template
    {
        public static readonly Guid ID = Guid.Parse("19093584-3a01-4841-9de1-243967807a42");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Communal Tale",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7bd03b9-a875-4909-8575-1b17af51abf2"), Type = TextBlockType.Text, Text = "Stories are an experience meant to be shared as a group. When you (feat: Spin a Tale), you can designate up to six non-minion allies as the heroes of your story. Each hero, once during the tale, can continue the story in your stead by spending an action to (feat: Spin the Tale|Spin a Tale); if they do, the story continues for another round, as if you had (feat: Spun the Tale|Spin a Tale) at the start of your turn. This could allow the story to continue for up to 6 additional rounds, if all possible allies (feat: Spin a Tale), though you can continue to (feat: Spin a Tale) on your own as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ef00bcac-583b-4bad-988c-a6ebfb95b7d3"), Feats.Instances.FolkloristDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a24977b4-f08c-4bb1-b4a0-e1fb1108ee3a"),
                SourceId = Sources.Instances.StrengthOfThousands.ID,
                Page = -1
            };
        }
    }
}
