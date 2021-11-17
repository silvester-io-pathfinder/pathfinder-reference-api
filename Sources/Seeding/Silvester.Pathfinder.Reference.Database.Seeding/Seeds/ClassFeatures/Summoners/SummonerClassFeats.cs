using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Summoners
{
    public class SummonerClassFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("123250d9-ebba-4af8-8e0a-9808edbfa016");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 2,
                Name = "Summoner Class Feats", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("605551b9-20ed-4b6f-95f4-9252088e046e"), Type = TextBlockType.Text, Text = "At 2nd level and every even-numbered level thereafter, you gain a summoner class feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyClassFeat(Guid.Parse("9e06a05c-c60d-41a7-b6b4-46c35925a0fb"), Guid.Parse("c425e662-d740-4047-b061-3c6d254a47ee"), Classes.Instances.Summoner.ID, level: 2);
            builder.GainAnyClassFeat(Guid.Parse("260225c8-7e8b-4d09-bbf4-6d9014098f07"), Guid.Parse("0fe4a54b-9558-4576-a91a-201fc9ff473a"), Classes.Instances.Summoner.ID, level: 4);
            builder.GainAnyClassFeat(Guid.Parse("d4b9e8d4-3caa-40a7-8bed-3ae7df133f6a"), Guid.Parse("9670b358-319b-47bc-bb8b-e27f15c02dee"), Classes.Instances.Summoner.ID, level: 6);
            builder.GainAnyClassFeat(Guid.Parse("ae411ebb-72e6-41c5-aa21-d73551b7652b"), Guid.Parse("a9be0dcc-ff01-4f61-8fd4-434b6a4b17ef"), Classes.Instances.Summoner.ID, level: 8);
            builder.GainAnyClassFeat(Guid.Parse("3166c078-4ae3-463b-9910-c8a259d5eb91"), Guid.Parse("b9bc7629-6d9e-4db2-8d23-a64c7a90ee41"), Classes.Instances.Summoner.ID, level: 10);
            builder.GainAnyClassFeat(Guid.Parse("9fd4da17-9e0b-44f6-ba6b-fefad25d9c7e"), Guid.Parse("98ced361-544a-42a0-96d0-dde6db5dfb22"), Classes.Instances.Summoner.ID, level: 12);
            builder.GainAnyClassFeat(Guid.Parse("cec924b0-1562-450c-955b-2306f44847a9"), Guid.Parse("cbdd78a9-c662-4db9-bfca-26d2ebf682a6"), Classes.Instances.Summoner.ID, level: 14);
            builder.GainAnyClassFeat(Guid.Parse("b894fb55-f9d3-48f6-915e-d2ef84aed56f"), Guid.Parse("5158c25d-ee61-4c17-bbe6-3f5ac31eb247"), Classes.Instances.Summoner.ID, level: 16);
            builder.GainAnyClassFeat(Guid.Parse("c7ac8160-ed89-447e-9fb9-f5959c0e7380"), Guid.Parse("f4bd814c-6d44-416b-949b-17f738182a99"), Classes.Instances.Summoner.ID, level: 18);
            builder.GainAnyClassFeat(Guid.Parse("7dc0dffd-f192-4b54-974c-cbab2f8ce165"), Guid.Parse("c60b26a4-ba1d-4be2-81ca-f1158bf95062"), Classes.Instances.Summoner.ID, level: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1a92d5d0-da84-445a-8eb3-53a0b11b94fe"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 206
            };
        }
    }
}
