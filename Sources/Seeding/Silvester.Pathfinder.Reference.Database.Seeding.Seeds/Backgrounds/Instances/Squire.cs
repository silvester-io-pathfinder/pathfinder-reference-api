using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("e2144d0b-e74c-4c9d-9ab2-e6993e6aabdf"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("8872fa8f-df9a-4871-a482-d081c682416f"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("ffd96d2f-26e5-451e-ae1a-36e96ddf1410"), Stats.Instances.Constitution.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("ba445798-44a7-49eb-9a5c-295f69b4797c"));
            builder.GainSpecificSkillProficiency(Guid.Parse("3acc8021-5940-4d3c-a035-648d3b76960d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);

            builder.AddOr(Guid.Parse("a974c553-696f-4a8b-94b1-4aea19890247"), or =>
            {
                or.GainSpecificLoreProficiency(Guid.Parse("40c45a58-5af7-4c6a-9526-237769e6ccd4"), Proficiencies.Instances.Trained.ID, Lores.Instances.Heraldry.ID);
                or.GainSpecificLoreProficiency(Guid.Parse("dea2888e-c070-464d-9f81-b112c0dd5f12"), Proficiencies.Instances.Trained.ID, Lores.Instances.Warfare.ID);
            });

            builder.GainSpecificFeat(Guid.Parse("d6c7c2b4-50f8-4187-952f-638bb76c7973"), Feats.Instances.ArmorAssist.ID);
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
