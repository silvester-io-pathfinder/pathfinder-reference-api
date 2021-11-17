using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class HookclawDigger : Template
    {
        public static readonly Guid ID = Guid.Parse("eb3a27b0-4c04-44d7-ac2e-d0727764b32f");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Hookclaw Digger",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f4903e5b-2328-47e4-911b-3176ae9628d1"), Type = TextBlockType.Text, Text = "You are a digger from the Hookclaw kobold tribe, born beneath the streets of Absalom, with muscles and mind hardened by years spent tunneling through rock and earth and a confidence built upon your pride in your draconic heritage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        {
            builder.HaveSpecificAncestry(Guid.Parse("141e644f-bf22-492e-85a3-f7a9f23ef69d"), Ancestries.Instances.Kobold.ID);
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("b65c2a02-81e0-4f43-baf7-58da4cf832f2"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("c992dd69-707f-4108-a627-b59679b973af"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("497c6ce0-a33c-4b7e-a265-d0b3c338db83"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("dca42071-9cba-4028-9869-78eb589c9ff8"));
            builder.GainSpecificSkillProficiency(Guid.Parse("eb0d1c97-901d-4998-803c-faf024759fad"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("421bfd6e-d938-404c-875c-1efab9234085"), Proficiencies.Instances.Trained.ID, Lores.Instances.Mining.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("42c7389e-8ed9-4234-a8a6-85ec54810b57"), Proficiencies.Instances.Trained.ID, Lores.Instances.Engineering.ID);
            builder.GainSpecificFeat(Guid.Parse("ddb23fd1-d9c4-4c81-a340-5b10c7adfb73"), Feats.Instances.ImproviseTool.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa7b6c98-54c7-466f-b9c6-fd3c4e34e26d"),
                SourceId = Sources.Instances.LittleTroubleInBigAbsalom.ID,
                Page = 0
            };
        }
    }
}
