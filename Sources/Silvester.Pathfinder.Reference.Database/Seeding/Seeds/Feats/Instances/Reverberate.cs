using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Reverberate : Template
    {
        public static readonly Guid ID = Guid.Parse("8c205bf6-0b8b-4d25-95d2-c4dbcaf4d5bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reverberate",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You would take sonic damage from a spell.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ef4b7d6a-8f75-412c-8d4c-8a6dcc8c96ba"), Type = TextBlockType.Text, Text = "You can manipulate the acoustics around you to deflect sonic damage back at its source. Attempt a Performance check against the spell DC of the creature that cast the triggering spell." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("62c6a67d-b644-4f4d-be8d-168b8a697405"),
                CriticalSuccess = "You reduce the triggering damage by an amount up to four times your level. The caster takes sonic damage equal to the amount of damage you reduced in this way.",
                Success = "As critical success, but you reduce the triggering damage by an amount up to twice your level.",
                
                CriticalFailure = "You misdirect the sonic waves at yourself, taking twice the triggering damage.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c55268f-5899-49fe-b567-749dd8f2210a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
