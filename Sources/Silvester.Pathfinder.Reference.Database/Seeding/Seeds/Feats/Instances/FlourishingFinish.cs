using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FlourishingFinish : Template
    {
        public static readonly Guid ID = Guid.Parse("07b0469f-70e0-4d27-af19-b265877927fc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Flourishing Finish",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("acf8fc23-afb7-4582-b071-fb526550087e"), Type = TextBlockType.Text, Text = "Attempt a Performance check, comparing the result to the Will DC of each foe within 30 feet who can see you. Regardless of the result, each target is immune to your Flourishing Finish for 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a62c744d-67f5-4cdb-9fd4-006e560ba21e"), Feats.Instances.ProvocatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("e9f7e529-f38f-46c4-bc51-d44b516bce4c"),
                CriticalSuccess = "The target is frightened 2.",
                Success = "The target is frightened 1.",
                
                 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e64995e-ac59-42a6-95aa-56348f1b3df0"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
