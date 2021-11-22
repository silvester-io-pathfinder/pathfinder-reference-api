using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseAlignment : Template
    {
        public static readonly Guid ID = Guid.Parse("3aff51a9-eca5-424d-a444-1d94b46669fe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sense Alignment",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dd2be4b8-f397-4521-afad-5512815ee6b4"), Type = TextBlockType.Text, Text = "You read the body language of an intelligent creature within 30 feet and pick up on subtle cues to detect its general propensity for good or evil and law or chaos. The GM rolls a secret Perception check, comparing the result against the target's Deception DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e487dc6f-3a2d-433d-8841-5e0bc937e6ae"), Feats.Instances.EdgewatchDetectiveDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("529f882f-7694-4bf9-b89b-648f2951c134"),
                CriticalSuccess = "You ascertain the target's alignment.",
                Success = "You ascertain the target's alignment, but only along one axis (your choice of either the good-evil axis or the lawful-chaotic axis).",
                Failure = "You do not learn the target's alignment.",
                CriticalFailure = "You incorrectly ascertain the target's alignment, misidentifying their alignment along either one axis or both (GM's choice).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("79f86a01-79c9-4710-88be-9055aab258d9"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
