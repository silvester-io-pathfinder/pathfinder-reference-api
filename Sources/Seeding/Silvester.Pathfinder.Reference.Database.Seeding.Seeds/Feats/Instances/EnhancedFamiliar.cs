using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnhancedFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("73b11714-6aa1-45a2-9841-e98e6f0c37fa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enhanced Familiar",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("edae13a9-f15e-4c79-885c-e6f44b3b9211"), Type = TextBlockType.Text, Text = $"By applying the best of multiple traditions of magic, you've found a more efficient way for your familiar to store its energy. You can select four familiar or master abilities each day, instead of two." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyFamiliar(Guid.Parse("ec3c8d7d-e02d-44f3-b33b-6376f4581576"));
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e758784b-010a-48b1-a3f3-57ce71400bb1"), Traits.Instances.Druid.ID);
            builder.Add(Guid.Parse("967d9e90-075b-4d7d-9db3-a8f644778868"), Traits.Instances.Magus.ID);
            builder.Add(Guid.Parse("de3dbac2-bbeb-4392-b8eb-e795439163cc"), Traits.Instances.Sorcerer.ID);
            builder.Add(Guid.Parse("795d101f-7bb2-4b9a-9d0d-ac821c6d3736"), Traits.Instances.Witch.ID);
            builder.Add(Guid.Parse("dc292523-257e-41c6-be7b-f1190715dab4"), Traits.Instances.Wizard.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9711ef63-8d06-4509-b83a-194ae010cedc"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
