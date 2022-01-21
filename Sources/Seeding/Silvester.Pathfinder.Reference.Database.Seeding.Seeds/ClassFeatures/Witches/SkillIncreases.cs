using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Witches
{
    public class SkillIncreases : Template
    {
        public static readonly Guid ID = Guid.Parse("207ca63f-a170-4c8d-8387-aa0a48ae0e81");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 3,
                Name = "Skill Increases", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("bfeef992-029f-405e-b929-3ed29ad71fe2"), Type = TextBlockType.Text, Text = "At 3rd level and every 2 levels thereafter, you gain a skill increase. You can use this skill increase to become trained in one skill you're untrained in, or become an expert in one skill in which you are already trained." };
            yield return new TextBlock { Id = Guid.Parse("e7788aeb-e4bc-4059-a2be-2b5c821ae137"), Type = TextBlockType.Text, Text = "At 7th level, you can use skill increases to become a master in a skill in which you're already an expert, and at 15th level, you can use them to become legendary in a skill in which you're already a master." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSkillIncrease(Guid.Parse("b6fa17de-ad0b-40c8-b7d4-13fa3a3e1913"), Guid.Parse("d9429280-3572-4d8b-b3cd-7d9d1172098e"), requiredLevel: 3);
            builder.GainSkillIncrease(Guid.Parse("9140416c-ce89-48db-80d1-85688d173696"), Guid.Parse("58d248e7-d479-417b-81fd-ce38665b9085"), requiredLevel: 5);
            builder.GainSkillIncrease(Guid.Parse("182e3e05-fbe6-4d55-8e29-02275a59b6b0"), Guid.Parse("259430ac-56d7-4170-bb35-28a68caac047"), requiredLevel: 7);
            builder.GainSkillIncrease(Guid.Parse("7c29a703-b7bd-4dc6-8140-4a7be888ba1a"), Guid.Parse("9b336230-ab3b-4a49-8ea8-fb729ed85d6c"), requiredLevel: 9);
            builder.GainSkillIncrease(Guid.Parse("94381867-6fd0-4f8f-9525-0eeb66991d6a"), Guid.Parse("dbc891b0-739c-4648-93c2-fa75ae99f4f3"), requiredLevel: 11);
            builder.GainSkillIncrease(Guid.Parse("ce45d32f-2355-4877-8e2a-c9218dff94dd"), Guid.Parse("bbe18849-755c-44ac-811e-78f59e338e8f"), requiredLevel: 13);
            builder.GainSkillIncrease(Guid.Parse("7cec327a-3052-40b1-8f42-3974a99757b0"), Guid.Parse("ed70bc36-e7c2-4cbb-b9a6-c40d75037612"), requiredLevel: 15);
            builder.GainSkillIncrease(Guid.Parse("9030d696-c273-49bb-ab23-9479dbb2ba40"), Guid.Parse("31174f82-bebe-4c03-a778-c3557548e00c"), requiredLevel: 17);
            builder.GainSkillIncrease(Guid.Parse("b0c44d2f-88de-466a-85ff-736170653000"), Guid.Parse("e75af208-06a2-4bfd-bc57-fbb91bf09fa8"), requiredLevel: 19);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("723c3b00-cfe6-4d54-b15f-9d771fc6acfa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 98
            };
        }
    }
}
