using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Barrister : Template
    {
        public static readonly Guid ID = Guid.Parse("0d797e80-7909-4763-b5a9-6a3210198a14");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Barrister",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8c5eed0a-95e8-43e2-bbbd-a36634652b80"), Type = TextBlockType.Text, Text = "Piles of legal manuals, stern teachers, and experience in the courtroom have instructed you in legal matters. You're capable of mounting a prosecution or defense in court, and you tend to keep abreast of local laws, as you never can tell when you might need to know them on short notice." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("1a8ed000-006d-4806-8551-8fe6c2a7d132"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("2d541ba9-e353-4f40-ab04-06b7a213638d"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("d0043364-6de2-43a7-9366-d660bdfa14d6"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("1c9a9757-1c6c-422a-a685-0294d7107bba"));
            builder.GainSpecificSkillProficiency(Guid.Parse("4ff25fc1-ea2f-4c76-b503-cac77af1569d"), Proficiencies.Instances.Trained.ID, Skills.Instances.Diplomacy.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("26ef8695-532a-47d8-9d99-505f62361dd7"), Proficiencies.Instances.Trained.ID, Lores.Instances.Legal.ID);
            builder.GainSpecificFeat(Guid.Parse("69bc72c4-1d8c-4ce3-89aa-52338b8fcb0f"), Feats.Instances.GroupImpression.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("328a6a3e-72bc-4fd6-9eb2-086604cb0344"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
