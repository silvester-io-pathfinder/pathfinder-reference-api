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
            builder.AddOr(Guid.Parse("b97d07f0-6159-4843-933d-29b1ded759f2"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("429d9804-d2f3-41cb-9f1f-da50dacc6cc1"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("1a600e88-c0e8-4f3f-82b4-d8c8bbc5dd7a"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("b51fb4e0-ce75-4785-9c59-94f3bdeb2fc0"));
            builder.GainSpecificSkillProficiency(Guid.Parse("378425e7-dc5c-4de4-badc-d2b8006f0023"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);

            builder.AddOr(Guid.Parse("1b14aa7c-68ef-41ac-85b9-4319b42e7239"), or =>
            {
                or.GainSpecificLoreProficiency(Guid.Parse("af9f0dad-f8c5-4082-90db-6534375dd012"), Proficiencies.Instances.Trained.ID, Lores.Instances.Genealogy.ID);
                or.GainSpecificLoreProficiency(Guid.Parse("e0b72b55-2f9c-4900-af59-63b73d58356b"), Proficiencies.Instances.Trained.ID, Lores.Instances.Heraldry.ID);
            });

            builder.GainSpecificFeat(Guid.Parse("236051da-640a-48fc-aafb-163a156a1c41"), Feats.Instances.CourtlyGraces.ID);
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
