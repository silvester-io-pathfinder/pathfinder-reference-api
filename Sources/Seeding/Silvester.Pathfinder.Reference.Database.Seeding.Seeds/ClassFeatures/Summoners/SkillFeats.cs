using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("cb94d427-489e-4591-9ef5-bedef4f76795");

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
            yield return new TextBlock { Id = Guid.Parse("edf04702-63aa-49ac-bf3c-966457f86fcf"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("6cfccf36-9879-4077-b3e9-57f06812b0cd"), Guid.Parse("bc1ad11c-c194-49ce-b4a6-a6b043476079"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("99d4d65d-aa82-4eb6-b900-ab6aeb70506b"), Guid.Parse("af51619d-8d99-4460-9d35-d012df1f426b"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("5959fce4-7e9e-4b6b-91f3-1d16181e7c7b"), Guid.Parse("c898d012-0282-447e-ac14-fe80bfb1ca6d"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("aac7da0a-be07-4a39-b6d8-4529fca34498"), Guid.Parse("4fc0cb61-e8b1-47d1-860b-a258039a1d9e"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("787b78d1-566f-44da-b895-8001d362c3ed"), Guid.Parse("40d4d6f6-353c-43f9-a4b5-7dadf050248b"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("1761e634-cd2b-4bbc-8b9c-560e6b8f372b"), Guid.Parse("48b94c17-572a-4878-a458-9480300d9572"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("dffee5ea-03ed-4ac7-9d6e-56bad2eae4f7"), Guid.Parse("b83b6daf-2747-4938-a34a-12981b575bbc"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("6c843c19-fc14-4223-a4a0-6047c75b63dc"), Guid.Parse("9e968162-2007-46a6-9bd3-bec114533699"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("b5f60b9d-a98f-4ef2-9899-1f7146ca8be8"), Guid.Parse("6e1e731e-bcbe-4ec1-81bc-0cf4a75cd675"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("229b31a5-3269-438e-a9aa-3d2e7f153ede"), Guid.Parse("c60ce3c7-f226-44fa-83d4-4b9a5748cd54"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a2a60b7-c815-4ab8-84de-96fcec15ef37"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 56
            };
        }
    }
}
