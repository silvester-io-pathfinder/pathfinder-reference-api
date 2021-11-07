using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MurderersCircle : Template
    {
        public static readonly Guid ID = Guid.Parse("ef200400-c3b9-42ab-800f-776c344ded9e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Murderer's Circle",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c6a81789-b32d-4d4f-8a51-60af7a8c028c"), Type = TextBlockType.Text, Text = "You (action: Strike) a target within reach and then (action: Step) to any other open space adjacent to that target. Your target is then flat-footed against your next (action: Strike) this turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("75211de3-c847-4e78-bf2b-e7eee450bee6"), Feats.Instances.ProvocatorDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("90b8e9da-0f37-4488-8353-28e806f82f21"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
