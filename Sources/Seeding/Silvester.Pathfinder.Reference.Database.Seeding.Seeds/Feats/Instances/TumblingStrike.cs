using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TumblingStrike : Template
    {
        public static readonly Guid ID = Guid.Parse("9ba2a0fe-4dc3-492b-a233-5d7e1b467656");

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
            yield return new TextBlock { Id = Guid.Parse("7684d87b-7313-47d7-ad44-8191c678c380"), Type = TextBlockType.Text, Text = $"Attempt an Acrobatics check against the Reflex DC of an enemy adjacent to you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4001e6d6-3065-41fb-bceb-1d9ba51a5218"), Feats.Instances.AcrobatDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Flourish.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Move.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("7d0755d5-0c67-4a95-b3c8-5e590ab8e4ea"),
                CriticalSuccess = "You move through the enemy's space to an unoccupied space on the other side of the enemy from your starting position. This movement doesn't trigger reactions. You can't move farther than your Speed, and you must end your movement adjacent to the enemy whose space you moved through. After moving, you make a melee (action: Strike) against the enemy whose space you moved through, and the enemy is flat-footed against that (action: Strike).",
                Success = "As critical success, but the enemy isn't flat-footed against the (action: Strike).",
                Failure = "You remain in your original space but can still (action: Strike).",
                CriticalFailure = "No effect.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0bb00f9-4cfa-4846-a4ac-7235a274064d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
