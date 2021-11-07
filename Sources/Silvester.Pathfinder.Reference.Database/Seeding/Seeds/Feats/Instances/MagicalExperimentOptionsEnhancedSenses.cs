using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalExperimentOptionsEnhancedSenses : Template
    {
        public static readonly Guid ID = Guid.Parse("2f585c2c-bea3-4fa7-9ddf-8daea6f48c99");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Experiment Options - Enhanced Senses",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3906df62-7c0d-4097-81d8-91a6ed2a879b"), Type = TextBlockType.Text, Text = "You gain low-light vision (or darkvision if you already had low-light vision) and an imprecise sense with a range of 30 feet, such as scent, thoughtsense, tremorsense, or wavesense." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("555ac2dd-130a-48e0-8730-51d22db8a31f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
