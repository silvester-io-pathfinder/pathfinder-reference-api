using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class WitchClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("b947a08a-513a-4103-83cb-cd2719785e74");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Witch Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("52673191-c49e-46dd-a508-334495f3e887"), Type = TextBlockType.Text, Text = "At 2nd level and every even-numbered level thereafter, you gain a witch class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("0dff718a-56ef-4a1a-87d6-8ba7a2054dfb"), Guid.Parse("51bf278a-ae13-4fc1-920a-fd391c6159e7"), Classes.Instances.Witch.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("29a4731e-8904-4ce5-8ef9-42459ae9867d"), Guid.Parse("1f49ac89-ac4b-4740-b1a8-6d625fe69cf0"), Classes.Instances.Witch.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("3f38f189-5864-40ea-9342-e1b8aa7f97a6"), Guid.Parse("197f4b98-f999-4792-ae73-9b8438262ab3"), Classes.Instances.Witch.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("7773951c-f38a-426c-8bbd-20c66d782182"), Guid.Parse("85ac1662-d784-4ed7-9fa4-3124aa2bcc22"), Classes.Instances.Witch.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("2a527f89-d43c-4158-b284-f5211f409d85"), Guid.Parse("706f920f-b2ef-43bd-a87e-ade66052a0da"), Classes.Instances.Witch.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("a39ba2fd-d8a4-4a4b-b11e-e7f52180a000"), Guid.Parse("85d932a5-2436-4234-9f03-795ebf0d90f9"), Classes.Instances.Witch.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("133c8364-3355-40b2-9bcd-eaf52a2df119"), Guid.Parse("aadc029d-a9e3-4e7b-8c4b-d96a3a131655"), Classes.Instances.Witch.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("ca203c35-d94e-4631-a82e-2b0be2205b8b"), Guid.Parse("986f2d6d-26f8-4666-8805-e5a4ca22da77"), Classes.Instances.Witch.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("cd2bb130-772d-4215-8185-1bcf6bdaceed"), Guid.Parse("fea0abfa-43fe-4046-9e3d-b354ebb4988e"), Classes.Instances.Witch.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("283eda2a-a838-4d38-8ce3-0497ed080267"), Guid.Parse("74fb7a7e-3f57-4416-9952-cd117d322698"), Classes.Instances.Witch.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("51c841ae-f57c-4e7a-ba1f-de2199ce5568"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
