using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Gunslingers
{
    public class SkillFeats : Template
    {
        public static readonly Guid ID = Guid.Parse("31d71be0-8113-4a2f-a241-409b13edccc9");

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
            yield return new TextBlock { Id = Guid.Parse("fd285ac0-e91d-4134-8dd2-6829b577d988"), Type = TextBlockType.Text, Text = "At 2nd level and every 2 levels thereafter, you gain a skill feat. Skill feats can be found in Chapter 5 of the Core Rulebook and have the skill trait. You must be trained or better in the corresponding skill to select a skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnySkillFeat(Guid.Parse("a8bb820a-edb6-406f-88da-a6be4f4be415"), Guid.Parse("b541ec4f-a3ee-4b18-aad1-8ad329b16037"), requiredLevel: 2);
            builder.GainAnySkillFeat(Guid.Parse("11ec4352-b53d-4779-8634-ebe4b54a6692"), Guid.Parse("47ad6bfc-fd1c-417c-9623-0e7981d235b8"), requiredLevel: 4);
            builder.GainAnySkillFeat(Guid.Parse("06822cdc-5118-469d-ba91-c194de463068"), Guid.Parse("86ba68c4-26ad-4350-9c8b-101925dc45f1"), requiredLevel: 6);
            builder.GainAnySkillFeat(Guid.Parse("8650bf4a-5e5e-42a7-b46d-037fe1e6038b"), Guid.Parse("ebd5554f-1006-4748-89b3-69211ddadabe"), requiredLevel: 8);
            builder.GainAnySkillFeat(Guid.Parse("07de10e3-2eb7-466d-86d8-9354f606232a"), Guid.Parse("6fb805a3-f193-4194-943e-1ef18e2fc9f7"), requiredLevel: 10);
            builder.GainAnySkillFeat(Guid.Parse("e0bfc923-2ab0-4d2d-a5cb-5f13cb0e703b"), Guid.Parse("e459b02e-913a-4c93-aa83-5ab9814414b8"), requiredLevel: 12);
            builder.GainAnySkillFeat(Guid.Parse("572472d1-e281-4c4e-8046-86640897d175"), Guid.Parse("2071c7ab-727f-44aa-8484-9136c18e394a"), requiredLevel: 14);
            builder.GainAnySkillFeat(Guid.Parse("e14d9afe-df68-4c35-be28-f522c5cb97e1"), Guid.Parse("e5351476-a8c0-477e-a96d-9737abccbaba"), requiredLevel: 16);
            builder.GainAnySkillFeat(Guid.Parse("03cfbe40-0ed7-41ad-95b5-fbfd85f42daf"), Guid.Parse("31e329eb-c29d-4e56-ac8e-751824e98e75"), requiredLevel: 18);
            builder.GainAnySkillFeat(Guid.Parse("de890a44-5bb3-4714-b9e5-80e8dad6cfb0"), Guid.Parse("6909a346-b894-4ea1-a3ee-c4287226c949"), requiredLevel: 20);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3b03dba0-a25e-4774-80f5-7f554c9b908b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 106
            };
        }
    }
}
