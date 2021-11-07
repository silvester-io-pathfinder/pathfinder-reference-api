using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PracticedPaddler : Template
    {
        public static readonly Guid ID = Guid.Parse("18525f40-8309-41b1-afd3-b2e6c8b54bb8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Practiced Paddler",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ed7dfb08-d264-4c24-9a6d-5149f2a15612"), Type = TextBlockType.Text, Text = "You’re skilled at navigating bogs and marshes, even for a paddler shoony. You gain a swim Speed of 15 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("6fa28d64-f3e9-4383-981a-6eb1e6526838"), Heritages.Instances.PaddlerShoony.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("351489f6-59af-480b-8fb6-1584f9281c0f"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
