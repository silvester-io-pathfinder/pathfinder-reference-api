using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("42ed54e4-369d-4063-8f14-bcbf0c8cca18");

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
            yield return new TextBlock { Id = Guid.Parse("d100569c-3303-4299-b09e-dbfff62bbd88"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("2582f610-f161-4df6-8167-b94ae2289e16"), Guid.Parse("0e828776-7fa7-4cee-9ee0-46a46eb383d6"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("6a1470d4-7bfd-4759-b863-25530f0ec072"), Guid.Parse("1b5b7303-555c-409c-8576-9b1a13c8f7a3"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("b1e9c6ce-9371-4266-a0aa-28afc164ff4c"), Guid.Parse("3fac8cdd-f929-47e4-a44d-14a8ea7517ec"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("523a0792-3e17-4886-9b49-0942b691cf51"), Guid.Parse("32933862-5eb3-4796-aa3e-8b3067a91f58"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("b7676c89-40ba-4880-82b1-915972f34ecf"), Guid.Parse("065b1b3e-6a4a-4232-b4b2-e422e1ee7a34"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("64e39ef4-a17b-457f-8ed7-3c5f438b644d"), Guid.Parse("8b6a2a5e-cc67-494a-8cbf-2e4d7eb15894"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("4f530d08-aaa9-45e3-87cd-544e4ab8e443"), Guid.Parse("30ab2786-24b5-4671-89a6-7e1ab5ee80dc"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("63eef497-7a58-4f14-881a-820aaf6e00e2"), Guid.Parse("36800112-df2d-4600-a48c-9d178ac2df83"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("01993d10-a339-4546-9362-34bc7ae4047a"), Guid.Parse("f73550d6-d507-472d-8ef9-8d5da39b363d"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("01ad26cd-9a21-4b36-94c6-72bf52818873"), Guid.Parse("008a0497-6f4f-49be-a4c7-528dc7c68a83"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d9a0317-3a90-4221-863b-4382a2fd7766"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 40
            };
        }
    }
}
