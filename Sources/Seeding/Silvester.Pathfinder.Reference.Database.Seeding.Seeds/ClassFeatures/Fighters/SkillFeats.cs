using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Fighters
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("740cb72c-1897-4ce8-bfb6-382d365b38bb");

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
            yield return new TextBlock { Id = Guid.Parse("ad023368-7aaa-4aed-bf28-8e89e2de07dc"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("5848c715-8f78-4305-8a47-c013e4fae8c0"), Guid.Parse("6719084b-5b09-4835-860c-e43e872759d9"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("472dd9e4-b4c9-4029-921c-b6758180bf09"), Guid.Parse("27025816-9314-4316-8987-03531e8f7cfa"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("58990992-4322-410a-999b-be1111f8934a"), Guid.Parse("669e0b9c-3c53-48d0-9563-1fe0555ae77a"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("a77b85f3-4cff-4fe0-8582-6a824ef929a1"), Guid.Parse("4071078e-c7c0-4fea-83f7-1591da88fb76"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("ac32313a-7b56-4440-a3e8-de3d26721eca"), Guid.Parse("29da6a77-f8c7-487f-a861-c163f5c13d54"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("6ba573c3-4a08-4138-8f58-1c5c0930abab"), Guid.Parse("b62c1f89-9026-4653-8427-062ac3e14ba4"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("280629a2-9789-4845-a918-cf32eee6130e"), Guid.Parse("89c75cd2-6917-42a9-be48-e453508d484f"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("6ba7b59f-52f4-4d78-a743-2d721c280a10"), Guid.Parse("61a75c6c-cf40-4097-b55a-592e44b9f1fa"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("c4d4b954-3d1a-446e-9530-6a25f973ba53"), Guid.Parse("f455efaf-a690-4290-98f2-2d76e4597dab"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("d713bd58-310d-49b3-9bd6-74cfc676caab"), Guid.Parse("485dc71f-9759-412a-89bf-bae7584f0f04"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("594a87f3-e358-4cd9-96d9-5aa85bf50fd3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 142
            };
        }
    }
}
