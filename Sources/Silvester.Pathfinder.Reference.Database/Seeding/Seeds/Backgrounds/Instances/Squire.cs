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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);

            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Heraldry.ID);
                or.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Warfare.ID);
            });

            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ArmorAssist.ID);
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
