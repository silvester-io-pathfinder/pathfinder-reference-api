using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SongOfTheDeep : Template
    {
        public static readonly Guid ID = Guid.Parse("d74bc722-17cc-476b-993f-b803e9ecc0aa");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Song of the Deep",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1991a7be-b1ea-4061-b6bb-f8ffd3856e9d"), Type = TextBlockType.Text, Text = "During a sea voyage, you washed overboard, ingested sea water, and drowned. Merfolk, kelpies, sea serpents, or another magical denizen of the sea pulled your unconscious body from the briny depths. Having spent so much time underwater, your lungs were filled with salt water. To restore your ability to breathe, they exhaled into your lungs and shared the ability to breathe underwater in the process. You came back with the ability to breathe water, as well as a newfound knowledge of your time beneath the waves." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            });

            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Ocean.ID);
            builder.GainSpecificAbility(Guid.Parse(""), Abilities.Instances.Waterbreathing.ID);
            builder.AddAnd(Guid.Parse(""), and =>
            {
                and.IsOptional(true);
                and.DisableAirBreathing(Guid.Parse(""));
                and.GainAnyAbilityBoost(Guid.Parse(""));
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f73c27d1-9895-442a-9d7f-138bb310173f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 31
            };
        }
    }
}
