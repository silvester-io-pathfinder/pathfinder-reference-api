using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HulkingSize : Template
    {
        public static readonly Guid ID = Guid.Parse("62ffbe43-9a7a-4fb3-ac2e-7660fe4017f2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hulking Size",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("641021ab-d2d2-47cb-935f-642d4bbfaa80"), Type = TextBlockType.Text, Text = "Your eidolon grows substantially. Your eidolon becomes Large, instead of its previous size, and its reach increases to 10 feet. This doesn’t change any of its other statistics." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8f701d94-f5bc-4608-96f9-f20e4769912f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
