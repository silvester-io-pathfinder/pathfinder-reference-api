using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Triangulate : Template
    {
        public static readonly Guid ID = Guid.Parse("3bf2346d-890c-411c-b739-50100dc9b200");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Triangulate",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("397e8cf7-7ded-47e7-9757-ab675d8b0ea3"), Type = TextBlockType.Text, Text = $"Your spotter's quick signals help you make even difficult shots seem simple. As long as both you and your spotter can see the target of your attacks, you don't take a penalty for attacking within your weapon's second range increment. The penalty you take for firing into further range increments is –3 for the third range increment, with an additional –2 penalty for each additional increment beyond the third (–5 for the fourth range increment, –7 for the fifth, and –9 for the sixth)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("3cafbc59-87ab-481f-9bac-0e1f234afd64"), Feats.Instances.SnipingDuoDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d66d9e43-116c-416f-baac-1cf263565314"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
