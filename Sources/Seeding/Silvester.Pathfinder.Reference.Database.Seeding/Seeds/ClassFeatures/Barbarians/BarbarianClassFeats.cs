using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class BarbarianClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("48030416-67dc-4872-9324-377a71b91979");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Barbarian Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("3a77694e-b7b0-4d3c-8be4-2f4b942b879d"), Type = TextBlockType.Text, Text = "At 1st level and every even-numbered level thereafter, you gain a barbarian class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("b92a0750-0085-4c7f-a3ad-cd1a06bfc731"), Guid.Parse("cc56a438-6011-4c76-96d9-3acf73aca3c0"), Classes.Instances.Barbarian.ID, level: 1);
            builder.GainAnyClassFeat(Guid.Parse("e42130fa-9534-4dc6-b3fc-22aa2ff5ec3e"), Guid.Parse("00f2088f-94d6-4653-aa32-e112c60a0bb9"), Classes.Instances.Barbarian.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("4899b44f-ad54-45f6-a790-af5a9ca4a07e"), Guid.Parse("ec84e5e5-38c2-49c6-84a7-3fb2eb2e9074"), Classes.Instances.Barbarian.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("e2ba83dd-17e0-4b27-84a0-8a7c25bed73b"), Guid.Parse("cf63dd0c-049b-49e8-a44c-3f612ad33e41"), Classes.Instances.Barbarian.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("9f80d426-deaa-4b79-aa2b-6b13a79a9cf7"), Guid.Parse("26597964-4250-4eb3-b1b6-05784e79152a"), Classes.Instances.Barbarian.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("124d8dd5-9966-4ca3-bd09-1afbfa4e9da9"), Guid.Parse("53cfe456-58a3-4528-8313-5d9044bd7cf0"), Classes.Instances.Barbarian.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("b99ec9b9-3a12-44fd-9a49-72fab4fa680c"), Guid.Parse("b43a9e17-76a4-4243-a9c8-198dd08e1c06"), Classes.Instances.Barbarian.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("90c3af25-2e52-4d07-8541-d4b849807d5a"), Guid.Parse("a0845aab-6594-46d9-9f12-8c8c312966cc"), Classes.Instances.Barbarian.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("13c8ef3b-854e-42c1-b940-f7e12f65598b"), Guid.Parse("03b83217-e2dc-4a8e-813e-862dd04a54d0"), Classes.Instances.Barbarian.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("7e98e659-336a-4e55-93b7-0e3071d1211c"), Guid.Parse("73967e88-b1a3-4933-8ae4-21267fbee534"), Classes.Instances.Barbarian.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("ed834cab-b581-4587-9c2b-83c3de045456"), Guid.Parse("cd35bf87-ec7e-414a-9551-b03ab8ae53ed"), Classes.Instances.Barbarian.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5344753e-bcdf-42ad-a745-436c17196789"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 84
            };
        }
    }
}
