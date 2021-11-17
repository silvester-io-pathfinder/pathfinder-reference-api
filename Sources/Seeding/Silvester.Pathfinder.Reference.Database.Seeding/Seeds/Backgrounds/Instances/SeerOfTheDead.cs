using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SeerOfTheDead : Template
    {
        public static readonly Guid ID = Guid.Parse("d73a214a-0bd3-450c-8ec2-870bda06006d");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Seer of the Dead",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ad1cb62f-8012-49c7-8da6-e5dd86d8db26"), Type = TextBlockType.Text, Text = "You have long been gifted with the ability to see and speak with the departed. This could have manifested at your birth or when a chance encounter linked you inextricably to the spirits of the dead. Their constant presence might feel like a curse, or it might provide you with welcome companionship." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("37910255-a3c2-4bd1-8f18-210167aebdec"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("4e9965de-3b6b-4683-a08e-b2fef68cf980"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("bc73ef2b-45c6-4e17-b9bd-e26268277f70"), Stats.Instances.Wisdom.ID);
            });

            builder.GainSpecificSkillProficiency(Guid.Parse("4e1d3a97-7318-458a-84e0-21f17a6e5098"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("f1bba58d-a09a-4e9d-bd6b-5f8bee18a4aa"), Proficiencies.Instances.Trained.ID, Lores.Instances.Undead.ID);
            builder.GainSpecificSense(Guid.Parse("dad1a152-accf-499c-b16e-a73d79386240"), Senses.Instances.SpiritSense.ID, SenseAccuracies.Instances.Vague.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2ef83c6d-4d90-4d1b-8ad2-bbd3639fc43d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 31
            };
        }
    }
}
