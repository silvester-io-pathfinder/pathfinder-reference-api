using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TumblingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("a5a1919f-8496-4ee2-a3ed-7a46e8c29b45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tumbling Strike",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("46843fd5-d270-4d1a-bf97-8d6b6f2df7af"), Type = TextBlockType.Text, Text = "Attempt an Acrobatics check against the Reflex DC of an enemy adjacent to you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5019e28d-8c55-41ed-8ab3-ce2613681915"), Feats.Instances.AcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e1bc974d-3fc0-4b5f-88f5-44c5805e776e"),
                CriticalSuccess = "You move through the enemy’s space to an unoccupied space on the other side of the enemy from your starting position. This movement doesn’t trigger reactions. You can’t move farther than your Speed, and you must end your movement adjacent to the enemy whose space you moved through. After moving, you make a melee (action: Strike) against the enemy whose space you moved through, and the enemy is flat-footed against that (action: Strike).",
                Success = "As critical success, but the enemy isn’t flat-footed against the (action: Strike).",
                Failure = "You remain in your original space but can still (action: Strike).",
                CriticalFailure = "No effect.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("268e1772-3036-4d1f-9e8f-a81b9d1c4ab7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
