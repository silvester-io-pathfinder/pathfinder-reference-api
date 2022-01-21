using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class SorcercerClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("995af801-ba5d-4d3a-9870-dbaf77f19aa7");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Sorcerer Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("09e8af8e-9f7c-41d8-ba05-686146406b5d"), Type = TextBlockType.Text, Text = "At 2nd level and every even-numbered level, you gain a sorcerer class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("0d9db2dd-86a2-46ba-b990-a9ec3f6b6441"), Guid.Parse("2b2c3844-f0fe-499a-b0b8-000fee2b1f9a"), Classes.Instances.Sorcerer.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("e5e442ea-980f-43c4-9658-37f70f2ed64e"), Guid.Parse("a331654c-cc74-4a24-9b29-21f077fffec6"), Classes.Instances.Sorcerer.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("66b5cf06-b74b-4535-b040-0a71a826694e"), Guid.Parse("aa47432b-74b1-4473-829d-3ef86f41296f"), Classes.Instances.Sorcerer.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("4c0a8a12-fb6a-441e-ba22-9e3532735ad6"), Guid.Parse("b9306466-54fa-46ab-a4de-ca084d70da26"), Classes.Instances.Sorcerer.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("b2a33a1e-de54-4f1c-9cb4-eec4b13c2889"), Guid.Parse("64ccc838-23a2-41cd-b8e1-9e0c33535ebf"), Classes.Instances.Sorcerer.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("10c29368-43bc-4cd6-8ce7-3bdc868538f7"), Guid.Parse("82fcdc75-3c2b-4142-8187-e1bae42746f7"), Classes.Instances.Sorcerer.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("498ae367-1253-483d-8b8e-9b3b9ded6eee"), Guid.Parse("d82e9687-5307-4a89-8e5c-6cb134788976"), Classes.Instances.Sorcerer.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("a8d07023-86fb-4a3b-b275-687db1bc1b7a"), Guid.Parse("d1b7f7d1-72f2-4dfa-99c2-009edde4fc86"), Classes.Instances.Sorcerer.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("4b89bcfe-db28-4f9b-b158-3eedc27d9ffa"), Guid.Parse("a1655604-1507-40aa-9e6c-835171a643d6"), Classes.Instances.Sorcerer.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("417d3df1-fb07-443c-a7f6-23e87ec105d9"), Guid.Parse("6b48dcbe-67d0-423b-86f1-92a64ac3bb9a"), Classes.Instances.Sorcerer.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("213b8414-d0a3-41bb-a0a4-ef8198277fdb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 193
            };
        }
    }
}
