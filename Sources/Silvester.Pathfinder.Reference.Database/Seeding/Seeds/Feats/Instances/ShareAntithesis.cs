using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShareAntithesis : Template
    {
        public static readonly Guid ID = Guid.Parse("85e6c0b2-945c-43e3-88de-d32ee8e8b3c1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Share Antithesis",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("90a28ff0-e5c4-414d-9215-ebcf7d0473a4"), Type = TextBlockType.Text, Text = "You apply esoterica to an adjacent ally’s weapons and body. That ally’s (action: Strikes|Strike) apply the weakness of the subject of your esoterica the same way your (action: Strikes|Strike) do. This benefit ends when (feat: Esoteric Antithesis) ends or you Share Antithesis again. You can’t share a custom weakness you created with (feat: Esoteric Antithesis), only a weakness the creature has normally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7a2b5e6d-52b9-407a-918c-12f329c3aeca"), Feats.Instances.EsotericAntithesis.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d2bed85a-04ea-412b-ac8e-c81515d37d38"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
