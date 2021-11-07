using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AbundantStep : Template
    {
        public static readonly Guid ID = Guid.Parse("7f6be39d-d1a0-4929-b997-ba4841f88c15");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Abundant Step",
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
            yield return new TextBlock { Id = Guid.Parse("7ec1e538-d5f5-4f68-86ca-b66104333cea"), Type = TextBlockType.Text, Text = "You can teleport yourself a short distance. You gain the (spell: abundant step) ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("076d6b4f-e5f6-4832-ada4-560ca5ad817b"), ClassFeatures.Monks.IncredibleMovement.ID);
            builder.HaveAnyKiSpells(Guid.Parse("576d3d2e-1798-434e-9d5b-93d1bcb979d2"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("92d1ee48-f0d4-49c8-b01c-07e2108ec636"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
