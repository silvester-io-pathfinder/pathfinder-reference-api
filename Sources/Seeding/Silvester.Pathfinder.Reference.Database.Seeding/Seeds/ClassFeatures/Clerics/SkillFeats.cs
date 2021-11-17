using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("2aad088d-98ab-412d-9f9f-7c1c5850c18e");

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
            yield return new TextBlock { Id = Guid.Parse("6f9fc7d0-2629-40e0-91ec-773bd558dd06"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("5decddc3-9b30-4f55-903f-1fee152091c7"), Guid.Parse("6991cc65-5cef-4fa7-af54-b43fa6c82374"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("af5d9484-d83a-458f-8b89-f67006961127"), Guid.Parse("ee2a4a7e-653d-49a8-b133-aa90596b3752"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("0607e432-0c78-43b4-932d-a8daba7e3ae0"), Guid.Parse("1dda511a-fa40-4cb8-be86-c0dad2b876e1"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("78e401e2-bf01-4466-8d00-8949254df04a"), Guid.Parse("f2de4f37-d871-425a-8239-bdedbab19ec0"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("81cffd0c-8970-4651-8c42-cb2643285936"), Guid.Parse("f01ee9d4-8fa4-4339-9fae-c1edef7047ba"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("c0069d89-3f2e-4cf4-84d8-a704323f3238"), Guid.Parse("afd71e88-f2e8-4d8f-a2f1-4e8f6c1fe450"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("bd2f94ff-7840-465d-bbee-b136df7d6d0b"), Guid.Parse("d80155cb-2d88-4304-be51-a1833f37a30a"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("395e67d4-389c-4fbd-8875-57d875b3c851"), Guid.Parse("bebae8ba-0def-4441-9505-7b689cfff9d4"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("b7420189-a554-41b6-9ed5-362404899620"), Guid.Parse("1fe875ad-d9db-42e2-89ab-a445795878ab"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("2d7fc0b5-a4fa-466f-ad9e-aa2d9f4cf458"), Guid.Parse("df179823-73b3-495b-bc6f-bfca59aba4ca"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d0e51cb1-143f-4c03-bd44-24cf03b957f6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 120
            };
        }
    }
}
