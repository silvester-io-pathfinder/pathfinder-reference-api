using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Rangers
{
    public class RangerClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("1d26aa00-a953-4a0f-94d2-603d5254ee83");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Ranger Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("eeda06d9-7a9c-49d9-a9f3-819673fb0c15"), Type = TextBlockType.Text, Text = "At 2nd level and every even-numbered level thereafter, you gain a ranger class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("3c1b26d6-cf21-4a99-9036-37a8e36f53ac"), Guid.Parse("0a969e6c-18d3-47ce-a88d-51208da9722c"), Classes.Instances.Ranger.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("116b3c62-a84c-420f-aa97-3f628e864017"), Guid.Parse("a9ac3749-fd72-4e00-aec3-71e6f41c813d"), Classes.Instances.Ranger.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("5cbdf218-9a0e-4aa0-8274-39b0dfd4c2df"), Guid.Parse("cb885fc0-fcfe-4e4d-94f0-f22e3686bc6f"), Classes.Instances.Ranger.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("c0c1a0f7-aee7-4b31-b35b-3ff61d253cfa"), Guid.Parse("037603a8-42e8-4deb-b57f-74a9584f22c0"), Classes.Instances.Ranger.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("712b7644-3ec2-4c29-a766-4807040ff654"), Guid.Parse("9160137a-db16-4b85-8470-6fd27b41891e"), Classes.Instances.Ranger.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("356b5b1f-f878-483b-8115-62987b30b3a3"), Guid.Parse("7ea091af-742e-4eac-9079-59688f167c23"), Classes.Instances.Ranger.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("a49366b7-7eda-4f5e-838d-3542958a36c3"), Guid.Parse("57eec63b-c1d4-42e8-8f3d-6526ad48b9b8"), Classes.Instances.Ranger.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("6491dcba-d148-4cc4-9af5-bfc57165c879"), Guid.Parse("a00a4aa3-9130-49e7-b618-c741616ac0f8"), Classes.Instances.Ranger.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("48e7bf03-d7ce-4f24-9369-e101caf6c45d"), Guid.Parse("fc8b1f72-3811-45d8-9f24-d94279b7bfff"), Classes.Instances.Ranger.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("e3666ee9-ec3e-4993-8e60-b407aa728421"), Guid.Parse("4e4eccc0-66d3-4f27-89b6-168de4672613"), Classes.Instances.Ranger.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e8ce2142-4888-4bdb-acb3-7777439a74e2"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 168
            };
        }
    }
}
