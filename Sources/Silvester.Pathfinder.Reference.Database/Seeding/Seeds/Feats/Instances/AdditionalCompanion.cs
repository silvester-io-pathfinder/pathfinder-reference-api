using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AdditionalCompanion : Template
    {
        public static readonly Guid ID = Guid.Parse("c34fb1e7-1e0a-4eea-8408-7ea8102a9cf3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Additional Companion",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat more than once, gaining an additional animal companion each time, to a maximum of four total companions (including the one you gained from Beastmaster Dedication and possibly one you gained from sources other than the beastmaster archetype).",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ba9f2a03-8258-4a88-bd86-34266b9fdb8c"), Type = TextBlockType.Text, Text = "Another animal joins you in your travels. It is a young animal companion that has the (trait: minion) trait. Even though you have multiple animal companions, you can only have one “active companion” at a time. You can use (feat: Call Companion) to switch your active companion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2864f88f-7d13-4dee-8c31-a7b9a52905c4"), Feats.Instances.BeastmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c25480c1-2747-49c6-af27-7ebaec4364c1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
