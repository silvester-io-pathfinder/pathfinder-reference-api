using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterScrollCache : Template
    {
        public static readonly Guid ID = Guid.Parse("f3d7123a-495b-407f-bd45-6289e8b6fd09");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master Scroll Cache",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f8094d5-eb3d-4c26-80f9-aef9947cf404"), Type = TextBlockType.Text, Text = "Your scroll collection is incredible, brimming with eldritch power, and you can prepare far more of them than an ordinary scroll trickster. In addition to your daily scrolls from the (feat: Basic | Basic Scroll Cache) and (feat: Expert Scroll Caches | Expert Scroll Cache), add a single scroll with a 6th-level spell. At 20th level, add a scroll with a 7th-level spell." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d8bb31e3-f0df-407b-9d4f-2b196a3f5075"), Feats.Instances.ExpertScrollCache.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7c5e317e-a03d-4b62-8b5f-1ecfdf8bdc78"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
