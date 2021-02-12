using Silvester.Pathfinder.Official.Database.Models;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds
{
    public class SkillSeeder : IEntitySeeder<Skill>
    {
        public IEnumerable<Skill> GetSeedEntities()
        {
            yield return new Skill { Id = Guid.Parse("13d2e35c-3829-4bab-85c1-de00ff96248a"), Name = "Acrobatics", HasArmorCheckPenalty = true, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("21b2cca1-66cd-48d1-a91b-085521659548") };
            yield return new Skill { Id = Guid.Parse("6f23369f-e91f-4472-a254-648ba3ed1850"), Name = "Arcana", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = true, StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd") };
            yield return new Skill { Id = Guid.Parse("8b35c13a-46fd-4018-bb18-11c0f156f708"), Name = "Athletics", HasArmorCheckPenalty = true, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("3e44bfc5-4aeb-4b46-9bdd-d4da39d40137") };
            yield return new Skill { Id = Guid.Parse("bef3fdab-348a-4024-9095-1ab69ded3fed"), Name = "Crafting", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = true, StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd") };
            yield return new Skill { Id = Guid.Parse("2f33e759-98f4-4a19-a955-e2133197de04"), Name = "Deception", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("f4206177-80d3-4c9c-8f79-357a608897fa") };
            yield return new Skill { Id = Guid.Parse("ab6c56d1-8f95-45db-b4a1-6bae20e30c47"), Name = "Diplomacy", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("f4206177-80d3-4c9c-8f79-357a608897fa") };
            yield return new Skill { Id = Guid.Parse("a14f7dbb-8a76-4b6e-8e67-6adb4f1b39b2"), Name = "Intimidation", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("f4206177-80d3-4c9c-8f79-357a608897fa") };
            yield return new Skill { Id = Guid.Parse("b64e4795-0efe-4cf5-82e3-f4219c041137"), Name = "Medicine", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = true, StatModifierId = Guid.Parse("e9e25044-7005-48c7-81bc-372c8a9f829a") };
            yield return new Skill { Id = Guid.Parse("3707c645-9e77-4eb7-bf63-f4d65f471f25"), Name = "Nature", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = true, StatModifierId = Guid.Parse("e9e25044-7005-48c7-81bc-372c8a9f829a") };
            yield return new Skill { Id = Guid.Parse("feb60159-48a5-4164-b2e2-54b1f0a52a26"), Name = "Occultism", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = true, StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd") };
            yield return new Skill { Id = Guid.Parse("b41f214e-5d45-46fe-8495-263c3d117a86"), Name = "Performance", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("f4206177-80d3-4c9c-8f79-357a608897fa") };
            yield return new Skill { Id = Guid.Parse("6a672190-7918-4fbd-a2d7-2d69f9d2a794"), Name = "Religion", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = true, StatModifierId = Guid.Parse("e9e25044-7005-48c7-81bc-372c8a9f829a") };
            yield return new Skill { Id = Guid.Parse("641be10d-b069-45e9-b890-7f1254cd042c"), Name = "Society", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = true, StatModifierId = Guid.Parse("37406a59-0dd9-4766-8713-33b13b7740fd") };
            yield return new Skill { Id = Guid.Parse("252ee579-951c-414e-bb69-7d2dfc324280"), Name = "Stealth", HasArmorCheckPenalty = true, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("21b2cca1-66cd-48d1-a91b-085521659548") };
            yield return new Skill { Id = Guid.Parse("d8fd543c-7284-451d-8882-583970e9d917"), Name = "Survival", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("e9e25044-7005-48c7-81bc-372c8a9f829a") };
            yield return new Skill { Id = Guid.Parse("ca854fef-a519-472f-badd-f677cd8871fc"), Name = "Thievery", HasArmorCheckPenalty = true, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("21b2cca1-66cd-48d1-a91b-085521659548") };
            yield return new Skill { Id = Guid.Parse("eeb5a099-361f-41ab-aafd-7672f47bf9c3"), Name = "Perception", HasArmorCheckPenalty = false, HasRecallKnowledgeAction = false, StatModifierId = Guid.Parse("e9e25044-7005-48c7-81bc-372c8a9f829a") };
        }
    }
}
