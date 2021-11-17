using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Swashbucklers
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("7dfb3929-501b-4694-80a5-cda3e146fa14");

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
            yield return new TextBlock { Id = Guid.Parse("eaec08b5-bfa2-4b9a-ae51-f8e7092b41e0"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("685b3161-6fc1-43e8-9de4-a909dfa42558"), Guid.Parse("fc92973e-3ff5-4838-bc93-3e60f54be982"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("858d66ac-3ede-4bf0-ae14-8e8cbd86ae3a"), Guid.Parse("6812d994-8428-45c2-80cd-ea847154b62c"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("d44b8deb-f053-470f-879b-f13080b3e5ee"), Guid.Parse("ad3f808f-28b8-46e2-adc5-4f6fef65e177"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("910b71cb-7b76-4465-8a26-5f93dfc9e6a4"), Guid.Parse("049491c3-337f-4765-9d2c-c945658944d5"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("090eb76f-2755-4e9a-97d6-f2dbdc6f6b77"), Guid.Parse("8c84e825-af67-4d1f-b069-e3c5ef2d2f60"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("7b3db4fd-6dfb-4aee-87c6-b92999e1f51f"), Guid.Parse("b50b0843-5be2-4e81-bb06-ff9e3aed5621"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("4b8e58b2-0228-4c2e-8aca-67d41ad8fd5b"), Guid.Parse("cd9e56fe-dd44-4975-a210-f5c3c466797a"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("852cd835-de0d-49c5-b0e7-509ae7f5bbc1"), Guid.Parse("a98772fa-1f9d-4241-923f-ba9fd9c69fd7"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("d57150b7-8780-42dd-a8d1-96cb5751da34"), Guid.Parse("d278c40e-82cc-44b5-bee7-258071c18fe2"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("cce62ac7-0681-4aa0-9158-6cf56000f1e3"), Guid.Parse("5ca5edc4-ba8a-4579-a6bd-3b996eb92678"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("425150ab-8115-466d-bf94-63328b6a8a46"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 85
            };
        }
    }
}
