using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Oracles
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("364a0ee5-850c-4ac0-94cf-952cf82f1e77");

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
            yield return new TextBlock { Id = Guid.Parse("d0632923-b7a6-4822-899e-5549f6371073"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("85ae5cec-1f2f-4ff1-b97e-4e77b094537b"), Guid.Parse("26ddd69e-ad39-4a5b-942f-798f69b90f87"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("8954e9ce-7573-4f15-885c-de5c710de4cd"), Guid.Parse("76a621a2-0179-4dec-9506-99c5544e0238"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("1ea39260-08a7-432c-a571-6a94dcb80f0a"), Guid.Parse("2856f459-dea4-47fa-b83d-aaf7e08c7543"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("9668cafe-b95a-464e-9081-8d989b7d9f20"), Guid.Parse("d3592db8-1b3c-487a-bafd-a5c33567ed4b"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("27b1af4f-3061-4a24-84d7-349d0088967e"), Guid.Parse("d6bf0089-057f-4186-a63a-49072a23839c"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("291fb0a2-3f6f-4fcc-a2ca-4f049c7d0c52"), Guid.Parse("03207a4f-ffd8-4839-a2bb-9b68fb6db4de"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("80a60bab-05e5-4888-a8e0-ffcc145d2f9d"), Guid.Parse("a9f2876a-a689-4f03-88bf-b572b70e7b2a"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("4ac92841-b907-4acb-8bf8-42b57b6f58eb"), Guid.Parse("f1d44734-33e0-46ef-853a-fad73dd6dafb"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("1516d9c4-e968-4728-b8e4-512848b095da"), Guid.Parse("39708ec4-f938-4c14-aa57-f4235ce0d078"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("5efc88f6-82c2-45ba-9cd1-309523df1949"), Guid.Parse("da0580a7-095b-4445-befa-0affd705ab2d"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0f97bd2e-b8f0-44cf-8d4f-c58026b552f1"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 70
            };
        }
    }
}
