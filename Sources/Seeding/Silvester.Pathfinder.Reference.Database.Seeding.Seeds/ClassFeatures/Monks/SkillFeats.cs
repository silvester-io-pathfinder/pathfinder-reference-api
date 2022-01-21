using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("afef91a5-8948-4620-ae56-8a20cb4dda2b");

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
            yield return new TextBlock { Id = Guid.Parse("290966c4-5758-46dc-97c4-8225e99253f8"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("a8be9730-b967-4ed1-8afe-291732792994"), Guid.Parse("35100081-b7fc-4d86-98f7-98c49c6259d5"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("f0827698-c90b-41cc-9421-4164c27e6a37"), Guid.Parse("b63c7111-bedf-4475-90c2-d7c06dbcf507"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("30b9c8f0-dce5-4dae-801a-c3f8d623c82e"), Guid.Parse("d5aa4bd8-9b4e-47b3-a632-c059db63c31d"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("6f6a6921-b956-4926-a735-a06fcd220dc5"), Guid.Parse("dd53d973-64c9-4ba0-bdb1-c2b75f9f78ca"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("4d31c40d-c2bc-4303-80b2-a52ecf872960"), Guid.Parse("9c28a978-81cd-4f26-80b2-6eb7a7365585"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("eafae86e-1c03-445c-b634-9cd726a3ef0a"), Guid.Parse("275fe9d5-dc54-49d6-b110-9773a4f6dddf"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("150e9f05-82b5-4937-87ac-052e2b5a1b9b"), Guid.Parse("1ce90b17-9639-4ece-b9da-f6d09220ef60"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("1d590485-5bf2-43bd-815f-88eb5bf09611"), Guid.Parse("12339bb0-2b78-4f0c-bd97-0f9bb79d189d"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("9258ce4e-e4d7-4d52-b393-1755e3727d7d"), Guid.Parse("44dbacf3-b655-4ffb-b993-618facddd574"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("a39766dd-0c9f-43cf-8b17-b10273b8e68f"), Guid.Parse("ba9f40a8-4fd6-40e9-8003-53977e8d1822"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be7327ce-d84c-4b28-aa57-524dac7dbf51"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 156
            };
        }
    }
}
