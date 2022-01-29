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
    public class NocturnalSense : Template
    {
        public static readonly Guid ID = Guid.Parse("7495a685-3db4-49dc-aacd-18b27bc82d17");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Nocturnal Sense",
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
            yield return new TextBlock { Id = Guid.Parse("2a1b763e-cc09-437f-816f-5bc45dc9bb2e"), Type = TextBlockType.Text, Text = $"Your senses gain even greater clarity. While raging, you gain darkvision if you don't already have it, and the range of your imprecise scent increases to 60 feet." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("172e0495-f975-4319-8e7c-002f4c859d12"), or => 
            {
                or.AddOr(Guid.Parse("76854c3b-8ffa-4e7f-a6a4-6abd915ad6d2"), or => 
                {
                    or.HaveSpecificFeat(Guid.Parse("1f7a3c2f-9d05-498c-9657-83ee36947657"), Feats.Instances.AcuteScent.ID);
                    or.HaveSpecificSense(Guid.Parse("30319784-cf7e-4ba9-8175-fb9944e9d233"), Senses.Instances.Scent.ID);
                    or.HaveSpecificSense(Guid.Parse("d11f4e29-f340-4bb1-b539-6983a11816a8"), Senses.Instances.Scent.ID);
                });
                or.HaveSpecificSense(Guid.Parse("d9af1604-b72d-4f6d-9a7b-66cdf58f91b9"), Senses.Instances.LowLightVision.ID);
            });
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c9301d83-0560-4893-84ae-32e6f2f9530a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
