using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConstructShell : Template
    {
        public static readonly Guid ID = Guid.Parse("55559196-00ab-4297-8b45-7c0e1ab5afb5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Construct Shell",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("89222596-e86d-4a82-9bd3-f3016f123062"), Type = TextBlockType.Text, Text = "You’ve adjusted your construct innovation so that when you ride it, special plates, hollows, or similar form partial barriers around you to add additional protection. You have lesser cover from all attacks when mounted on your construct innovation, not just from attacks where the construct would be in the way. Additionally, if your construct uses an emanation while you’re riding on it, such as (action: Explode), you can choose not to be affected by the emanation." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("6609b06e-4d60-4cf8-99ea-7fca17d4b31a"), Innovations.Instances.Construct.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21ffafea-8a5a-4f57-952b-de72a4524af3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
