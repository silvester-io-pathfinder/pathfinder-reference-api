using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WellspringMageDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("242781a8-40cd-4029-acaf-e458a2ebd461");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Wellspring Mage Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you gain two other feats from the wellspring mage archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7f7046c9-d955-4afd-9e75-b0e625f24b03"), Type = TextBlockType.Text, Text = "There’s no longer a limit on how many temporary spell slots you can gain per day from wellspring magic." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2e75de08-fb57-495c-a068-07fd4318cba6"), Feats.Instances.WellspringMagic.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39cca0d8-f711-4849-a070-f3d22c63f0a3"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
