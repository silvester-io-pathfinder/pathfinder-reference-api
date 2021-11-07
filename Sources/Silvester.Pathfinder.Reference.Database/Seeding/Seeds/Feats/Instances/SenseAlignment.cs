using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SenseAlignment : Template
    {
        public static readonly Guid ID = Guid.Parse("ce8c2582-4fb4-4234-b9a2-00876debb20b");

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
            yield return new TextBlock { Id = Guid.Parse("2ddf24a9-12b2-49fb-bbf5-d5618d08197a"), Type = TextBlockType.Text, Text = "You read the body language of an intelligent creature within 30 feet and pick up on subtle cues to detect its general propensity for good or evil and law or chaos. The GM rolls a secret Perception check, comparing the result against the target&#39;s Deception DC." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ae9d7632-7b8d-41ab-9946-76d3c8a84477"), Feats.Instances.EdgewatchDetectiveDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("12616f38-6e46-4afd-8718-ca7e1336c654"),
                CriticalSuccess = "You ascertain the target&#39;s alignment.",
                Success = "You ascertain the target&#39;s alignment, but only along one axis (your choice of either the good-evil axis or the lawful-chaotic axis).",
                Failure = "You do not learn the target&#39;s alignment.",
                CriticalFailure = "You incorrectly ascertain the target&#39;s alignment, misidentifying their alignment along either one axis or both (GM&#39;s choice).", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("77dde60a-f10b-4cbf-98d9-3a1c36f0cf28"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
