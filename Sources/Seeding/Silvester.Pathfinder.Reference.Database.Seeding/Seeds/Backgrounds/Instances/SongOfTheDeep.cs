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
            builder.AddOr(Guid.Parse("3180af0f-6234-4f22-9b2c-f0214add99c4"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("d5669b9e-ebf7-48f0-a8a4-d79cff54a9bb"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("e64895d7-426a-4daa-8c4f-b35daf180bdf"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("56fad0cb-6aae-448f-8f18-2d0eb8896320"), Stats.Instances.Charisma.ID);
            });

            builder.GainSpecificSkillProficiency(Guid.Parse("61228d4c-8e38-4597-90d8-128e574f2e00"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("0e83744c-02f7-4b4d-be74-e91c25ec71fe"), Proficiencies.Instances.Trained.ID, Lores.Instances.Ocean.ID);
            builder.GainSpecificAbility(Guid.Parse("d096431c-fecf-4073-b187-e23282a5a7cf"), Abilities.Instances.Waterbreathing.ID);

            builder.AddOr(Guid.Parse("87acc074-4ffc-49d8-b091-98589190d6f6"), or => 
            {
                or.Noop(Guid.Parse("a5c26577-aad0-473b-916f-bebb54a96582"));
                or.AddAnd(Guid.Parse("c99ebfe7-5641-4623-9378-a63fe94959ec"), and =>
                {
                
                    and.DisableAirBreathing(Guid.Parse("e1a5cb5b-250d-4e0c-a519-7d03afb1ebed"));
                    and.GainAnyAbilityBoost(Guid.Parse("072308f4-513d-4cfa-95ac-a2ba6278a515"));
                });
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
