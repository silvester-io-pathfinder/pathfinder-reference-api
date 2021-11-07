using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PolearmTricks : Template
    {
        public static readonly Guid ID = Guid.Parse("b3c28735-9c82-4631-8909-de19e248cb0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Polearm Tricks",
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
            yield return new TextBlock { Id = Guid.Parse("ac85ec1f-b1e6-4d63-9c70-045245ede1d5"), Type = TextBlockType.Text, Text = "Your connection to rune magic has revealed tricks to make polearms deadlier in your hands. You gain the critical specialization effects of polearms." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e28529ab-81f8-4789-aadc-e5a2afddd52c"), Feats.Instances.RunelordDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2c6c0ade-5c92-4912-a041-4b0caa6792ed"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
