using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AncestralLinguistics : Template
    {
        public static readonly Guid ID = Guid.Parse("5fe77f30-3174-4e34-86e4-8ff43d775e45");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ancestral Linguistics",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05261a81-6030-4346-8c80-fe991620a572"), Type = TextBlockType.Text, Text = "Over your extensive lifespan, you’ve studied many languages. During your daily preparations, you can recede into old memories to become fluent in one common language or one other language you have access to. You know this language until you prepare again. Since this knowledge is temporary, you can’t use it as a prerequisite for a permanent character option." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificAge(Guid.Parse("49aaa0be-eded-445a-83be-f4d3d78d3927"), Comparators.GreaterThanOrEqualTo, years: 100);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4801f847-b959-43e8-9d2f-02f1b15a9c76"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
