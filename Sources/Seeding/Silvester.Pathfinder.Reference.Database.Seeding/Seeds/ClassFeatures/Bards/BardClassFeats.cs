using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Bards
{
    public class BardClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("1a571100-be08-482c-91fd-aed4bd77e0e9");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Bard Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a443dc50-12d5-4545-a457-8563b3ca07e2"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a bard class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("5c93de84-722c-4fa6-abca-0acbe412eabb"), Guid.Parse("1de9e8cc-4e00-4ab9-89b1-bcd09b9a65d8"), Classes.Instances.Bard.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("caf2301f-4a19-49e1-ab4f-1f7c38102791"), Guid.Parse("7a5dc517-5633-4125-b7dd-77037c02aac9"), Classes.Instances.Bard.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("0a102429-a200-473b-b473-c9ba274ec929"), Guid.Parse("3bad7575-c1cf-4c48-a15c-6a0a2243afa3"), Classes.Instances.Bard.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("18b1f68a-1af6-4652-8d5f-27bb24ba4b00"), Guid.Parse("45c9bf77-594d-4fb1-b8fa-34b88c01fc49"), Classes.Instances.Bard.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("3b48b0d6-8f7e-47cb-b0f3-f449c30c1a19"), Guid.Parse("93f7d00e-7c52-477b-9083-add5ac428f76"), Classes.Instances.Bard.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("2a5b83ec-b55a-4d3c-9270-af340e289f15"), Guid.Parse("19d101e4-a7f8-423d-a584-2696541997fc"), Classes.Instances.Bard.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("95eeeaec-696e-476a-999e-3075789baaaa"), Guid.Parse("9eb8c1b2-1115-40f3-b3ec-a585c23231ad"), Classes.Instances.Bard.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("5610c05f-7f95-4e4c-bc60-458e51b4b175"), Guid.Parse("95514b7a-381d-4f88-90e3-d7194f3596c7"), Classes.Instances.Bard.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("c2af199a-c797-4677-9643-2704bf0069d8"), Guid.Parse("e1469e70-924b-458f-b7f9-1b7b7c2ada64"), Classes.Instances.Bard.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("6d6fdad1-e505-4040-8848-49d88c2a1bfb"), Guid.Parse("9f49f472-5f12-4d1b-a6c1-c749ebe13af9"), Classes.Instances.Bard.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b93b9796-a366-498f-9d5d-14e36f8e058a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 98
            };
        }
    }
}
