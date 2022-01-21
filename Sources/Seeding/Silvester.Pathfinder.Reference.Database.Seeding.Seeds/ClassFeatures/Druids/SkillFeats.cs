using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("d47be46c-6934-47cb-b431-50f000871390");

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
            yield return new TextBlock { Id = Guid.Parse("6d4581cb-cdb0-488c-910a-09244c64a348"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("a2cb31dd-5773-41eb-9d76-39c7499fd026"), Guid.Parse("e7a0d963-401c-4bc1-bd97-a07f67c5ab5d"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("3db1e5b9-646d-46c5-bc3b-95671e82dec5"), Guid.Parse("a34fa9ff-fda7-41b1-b979-9a54a16cf333"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("e18e7ad0-92f3-4af2-ac64-355a398ab549"), Guid.Parse("5a221b7e-3381-46ab-ae9b-18d612507121"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("d2206ede-b16a-4b98-8695-b92ee16562f0"), Guid.Parse("40c625d1-aa66-4657-8cba-e5933de8bb99"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("d94adae0-309e-4f65-932b-a23de4c34a3d"), Guid.Parse("9be02d50-5321-4835-801d-d8459b9f8f69"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("cae1c0ad-e5ab-456d-9d45-bcce98153f21"), Guid.Parse("769365b2-a485-462f-adf2-0b46c1cf49ff"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("d39c9282-df57-4972-88ee-18a6f91b623d"), Guid.Parse("541c7bc8-3d6f-43f4-a688-9a7faa83a733"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("af046bf1-48e1-407a-90b5-c59fd36a9a01"), Guid.Parse("c7d03707-bab6-4202-8a42-48742f0d5138"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("0d8c7b97-4bbb-4e76-8a7b-0514cf372406"), Guid.Parse("574486d9-fc9b-4abd-b1e2-fed5f6abc50d"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("4f3becdd-f684-41cc-b493-80870273e4cd"), Guid.Parse("cf18c1b7-0ded-4aac-8054-fa0de6028eda"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0060ba68-0f34-4f8e-a5d6-90161c25dbd3"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 132
            };
        }
    }
}
