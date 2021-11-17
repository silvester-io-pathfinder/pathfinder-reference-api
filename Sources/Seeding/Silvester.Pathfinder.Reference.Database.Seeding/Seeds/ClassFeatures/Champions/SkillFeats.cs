using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Champions
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("f8e249bc-580f-4bab-8c5e-01d21ec84ecb");

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
            yield return new TextBlock { Id = Guid.Parse("8bdd8267-248b-41a6-9170-64f1795a30c6"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("941b2086-b354-40d0-90cf-b439e90d1076"), Guid.Parse("d81e3338-89b0-4769-b125-0eff5cc1128d"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("1d72107e-86db-44c0-9bd1-8e5a6e10f4ac"), Guid.Parse("dc0db07b-a16d-45c8-ab81-011a2badb9a7"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("d1e23218-4189-4a01-a5c8-d743675fcb87"), Guid.Parse("30e0e869-62b1-4d93-8721-fbd1e1284ffd"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("f6ffdf80-8ae9-4ca2-b0e7-a8a8607c0bb0"), Guid.Parse("c24039a2-1628-48e6-9aae-63cef1eb8883"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("78eee00c-3e13-4f5a-b341-9aa2695c008c"), Guid.Parse("66250d71-a5b2-43b2-ac4e-0afd5ab6646e"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("34fe23d9-8b7e-46df-b323-8b828e4733aa"), Guid.Parse("d50e7bd0-f62b-40e3-b4a7-801ef99ffa45"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("132575bb-332b-472b-b008-8dc73783cda1"), Guid.Parse("1cdebf52-5026-406b-9094-55cca348d072"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("3985cd5f-df02-446e-9610-558745f03956"), Guid.Parse("7791fcdd-f9b1-4d43-9677-9b07664e074a"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("eab2ae61-4335-463a-b42a-e9e03ac9e5f0"), Guid.Parse("08dcf2e8-f21e-46e0-8116-3676c0575a1c"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("ca028df5-6091-4c7d-a6f2-01feea3bb540"), Guid.Parse("b10bcca4-54af-49e6-9d04-22713a4fb07b"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("337e3c1b-81eb-469d-b75d-1c69675c8b94"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
