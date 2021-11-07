using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TagTeam : Template
    {
        public static readonly Guid ID = Guid.Parse("d2c2c100-8738-4488-bb96-358cdd2a5c1c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tag Team",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You or your spotter misses with a Strike against a creature, and the creature is within the other's melee reach or first range increment.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("969f8865-0973-4cd6-86e1-d23f8f8944ca"), Type = TextBlockType.Text, Text = "Your skilled teamwork with your spotter enables you both to assist one another when you falter, using either other’s failures as opportunities to strike. If you used Tag Team after your spotter missed the triggering (action: Strike), make a ranged (action: Strike) against the same target with a –2 penalty. If you used this reaction after you missed the triggering (action: Strike), your spotter can use their reaction to make a melee or ranged (action: Strike) against the same target. (action: Strikes|Strike) granted by this feat don’t count toward your or your spotter’s multiple attack penalty and your or your spotter’s multiple attack penalty doesn’t apply to the granted (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("324d2e45-5060-4a89-a747-2da24ed9c41a"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("93e02f36-967a-448c-8db5-19cbabb316a2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
