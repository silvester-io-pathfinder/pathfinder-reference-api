using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefensiveCoordination : Template
    {
        public static readonly Guid ID = Guid.Parse("540bb270-f8ae-4e3a-a892-10d49e878766");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defensive Coordination",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cef96f71-c2ea-4b6d-864a-c39581b59e09"), Type = TextBlockType.Text, Text = "Like the storied heroes who persist in the face of overwhelming odds, you and your allies will hold the line. If your next action is to cast the (spell: inspire defense) composition cantrip, you can (action: Raise a Shield), and one ally who gains a status bonus from the spell can immediately use a reaction to (action: Raise a Shield)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("85d910c4-35fb-4967-a7fd-027f053200e1"), Muses.Instances.Warrior.ID);
            builder.HaveSpecificFeat(Guid.Parse("8f6d1291-6d15-4cd0-8054-51d7819d88da"), Feats.Instances.InspireDefense.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2704af83-8559-468f-97ef-e75ad82a1d00"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
