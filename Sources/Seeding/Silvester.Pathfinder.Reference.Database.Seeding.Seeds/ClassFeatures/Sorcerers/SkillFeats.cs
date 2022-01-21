using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Sorcerers
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("e730728b-6a0d-45f5-b7ab-a840626b3e26");

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
            yield return new TextBlock { Id = Guid.Parse("51e7f68e-e82d-43dc-9c48-649b4569941c"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("11c89de9-cd75-4646-9004-5daa36e235fa"), Guid.Parse("acb085e6-3624-49e5-bdc2-b5cb8caf58aa"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("892a04fc-adfa-4476-bcb2-db3aa5f503c4"), Guid.Parse("fd40fcc8-1ff7-4769-bee5-742dca5eeb10"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("6e269940-8279-463b-a16d-3f04943a9fe9"), Guid.Parse("bee21fbd-6993-45cb-b7ae-c88497b6617c"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("3baa3b53-3cc7-4ad3-b3cf-29de6965d486"), Guid.Parse("5389d1ae-2a03-49de-a0c4-c3b84b30f7b2"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("a6372912-fc67-468b-bcfe-598065f4d537"), Guid.Parse("639c4149-93a4-434b-9dd8-7c28f22937ab"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("aeb20a84-8909-4540-8fd5-a00060920c8f"), Guid.Parse("c5995eed-b5ad-42b5-9839-e614b7ec0877"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("4ef8e185-63e0-44ee-9617-ddd00326df88"), Guid.Parse("22904ab2-1a7d-42b5-be70-37c8e0b32f8e"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("73d019c7-5727-4433-b59a-3dfff2494284"), Guid.Parse("461282e2-85e3-4b9b-9928-64f692f0d475"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("3da6e05e-08b4-47b3-bf60-dffd3ca9ae2b"), Guid.Parse("5335fb46-887e-4b11-9a71-686bb7bf032a"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("301273c8-0764-4a4f-930b-747c983b7ae5"), Guid.Parse("53014976-82a7-4c44-bad0-6885a889134e"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ebab2a85-0d33-42f6-8958-b6ab5ddc0976"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 193
            };
        }
    }
}
