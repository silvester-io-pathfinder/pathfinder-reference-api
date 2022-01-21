using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Barbarians
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("d82a4684-b2f9-4856-a929-a9963d5af339");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2, 
                Name = "Skill Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("afd849c6-9502-4e19-a4f3-49e43422c24a"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("6510651a-3fe2-4980-9d07-7b0e58312f35"), Guid.Parse("9500b0de-3147-4a74-82ef-db58cc5b7e36"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("372921fe-289c-484d-8127-aa145caaf036"), Guid.Parse("078fe47d-521d-4d56-9a15-6e21c6167a19"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("2c5a75e7-397a-49e5-a4ba-b17ab1981460"), Guid.Parse("199c693a-e8b5-42f7-9fc6-c57e31cb6a6d"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("0e3c5ced-78d0-419e-ad83-6480f6b9ca08"), Guid.Parse("fe425354-45e9-458b-96d2-cc0acd27f451"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("79a3c279-79f0-4469-8049-bc85b4142e1c"), Guid.Parse("94f8b1fc-6ae8-4806-a0d7-48545b89b7a2"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("6353454d-3e46-45e9-a501-994688dd3955"), Guid.Parse("46f3298b-2d5e-49b8-8972-9a93d48d8cd1"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("b5f9a120-ed53-48ab-a696-d4a6d212ced0"), Guid.Parse("d88ba7a4-638b-4dea-ae2b-51425c2ad52d"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("17bfe84a-1651-4e9e-b8d5-2c40c693991c"), Guid.Parse("610b39b2-9e58-4da2-a620-f54b9a55a8bc"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("9cf8ac1c-2952-4e20-ba92-dc00b18c9b0d"), Guid.Parse("04e3849c-b877-4f5c-a69b-4fd4362ce8ef"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("cfd620ac-9546-4f51-ab19-50c8eaa919d7"), Guid.Parse("17c76f6a-af3a-4cb0-9454-ab9248486c5b"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("adbd769b-a5f9-4a96-8c6b-19d62ce7fc85"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 84
            };
        }
    }
}
