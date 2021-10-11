using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Squire : Template
    {
        public static readonly Guid ID = Guid.Parse("298ff406-b53d-47bd-a03d-49b8278226c5");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Squire",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f8327aa8-ffcc-4409-9bb9-ba4175ffe89e"), Type = TextBlockType.Text, Text = "You trained at the feet of a knight, maintaining their gear and supporting them at tourneys and in battle. Now you search for a challenge that will prove you worthy of full knighthood, or you've spurned pomp and ceremony to test yourself in honest, albeit less formal, combat." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("7f92283a-40bb-4412-b35a-e2d8203bcb25"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("7e113409-378e-41af-9013-a8aef841a416"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("c4bd32de-4dd3-44ad-9f8e-ced8e9f260fe"), StatId = Stats.Instances.Constitution.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("ea92494a-c2b3-4a80-99b0-c6c1859a55c3")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("31a2404c-bcd1-43cb-be73-1ab48e2a2381"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Athletics.ID
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("8ada71ac-5547-48de-8c4c-89475c9e8b45"),
                Choices = new Effect[]
                {
                    new LoreEffect { Id = Guid.Parse("7e9df1d1-9ae4-45b2-86d7-3a4185e1e4b1"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Heraldry.ID },
                    new LoreEffect { Id = Guid.Parse("e2ec828d-4cd6-4cbb-a5b4-69c1cc3b5040"), ProficiencyId = Proficiencies.Instances.Trained.ID, LoreId = Lores.Instances.Warfare.ID }
                }
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("3e305b3d-be2c-4bd6-9bd3-400203e52fc3"),
                FeatId = Feats.General.ArmorAssistFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fcff5ed2-cd10-4677-b55a-7db1c4baf584"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
