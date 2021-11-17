using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Inventors
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("93702f30-0bd2-475c-ae92-634a51f25355");

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
            yield return new TextBlock { Id = Guid.Parse("b3bddac4-20e6-47d3-a79e-b04f506c4754"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("db84b177-4847-4d81-a394-c0dfaecc56f4"), Guid.Parse("b43e627e-8dee-4345-b1d5-d342d4c61f61"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("2570af3b-2016-466c-ab6d-14481efde4ca"), Guid.Parse("31a7ca36-98ca-4ab0-966a-dd170332d198"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("5f0be385-4e98-4a99-b6e3-0ada77a580ea"), Guid.Parse("2c1f3591-dd98-4567-a764-61c880e7c052"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("490115dc-01f7-41ab-8d53-db57da11dc48"), Guid.Parse("13e640db-1f61-4d94-ae32-57b2aae37f21"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("c37cafef-0c85-4b95-8016-4315773e8e42"), Guid.Parse("cb3e2b15-83e2-455f-903a-8c73a922557d"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("a9d49167-19e0-49c2-8484-007483c29482"), Guid.Parse("a9a03e47-c4ab-439d-b291-8370f6983afd"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("2f310a62-3362-41e9-9e01-c4f95d89aa62"), Guid.Parse("aa4c841b-e98b-4992-8f7e-d08ab9dc0f98"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("8fb9793f-3c09-4724-b306-8b803870e270"), Guid.Parse("17c108d7-66e3-4aa1-bd2b-db04f29d1472"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("17e46b80-1bd0-4f53-a157-d74fc00f1b3f"), Guid.Parse("dbd41367-2f07-4ddf-95b6-7192a70ab290"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("89ae327d-6571-4b99-be55-7dda3b8e9aa5"), Guid.Parse("29c55ddc-ced8-4c58-9e93-3b68ffb4c11d"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84b66166-b4cc-4fed-a13c-de256fdcf06a"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 20
            };
        }
    }
}
