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
    public class MusicalProdigy : Template
    {
        public static readonly Guid ID = Guid.Parse("fd60762c-229a-471d-b8f6-8756a09e7600");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Musical Prodigy",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("06904552-eed4-4e02-8818-cd9647c42ab3"), Type = TextBlockType.Text, Text = "Ever since you were young, you've been almost supernaturally skilled in a particular type of music. The people around you were sure you'd grow up to perform at royal courts or to become a world-famous composer, but you've chosen a life of adventure instead. You might have given up on those dreams to find your own meaning, or you might find that adventuring allows you to experience unfiltered emotions and exploits that you can translate into a wondrous symphony some day." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("c7257031-0f86-4209-aeda-fecaf65c13fd"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("24507b80-7dd8-4619-93de-8161257e75c2"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("1b8c860f-5bce-408b-80a8-e6198ed9b218"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("2bab1304-6e6c-487e-80fa-98a2515684ef"));
            builder.GainSpecificSkillProficiency(Guid.Parse("3eec97c9-61fd-44d7-81bf-02df8f7a3287"), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("fa26de4f-ba4b-4210-a038-1c2edd05eda5"), Proficiencies.Instances.Trained.ID, Lores.Instances.Music.ID);
            builder.GainSpecificFeat(Guid.Parse("846e6b30-92d7-4fee-967d-4601b8bce22a"), Feats.Instances.VirtuosicPerformer.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88881cae-2128-438a-bdd9-1d791e54d813"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
