using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Noble : Template
    {
        public static readonly Guid ID = Guid.Parse("44a42ca6-d27c-4200-af75-4114a2f4f58d");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Noble",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b005e333-5c6b-4ad2-bfd1-9500704e2181"), Type = TextBlockType.Text, Text = "To the common folk, the life of a noble seems one of idyllic luxury, but growing up as a noble or member of the aspiring gentry, you know the reality: a noble's lot is obligation and intrigue. Whether you seek to escape your duties by adventuring or to better your station, you have traded silks and pageantry for an adventurer's life." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);

            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Genealogy.ID);
                or.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Heraldry.ID);
            });

            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.CourtlyGraces.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("15629c62-c9b3-480b-9a1e-5e18bd8f0dff"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
