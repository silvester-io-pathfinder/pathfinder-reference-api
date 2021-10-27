using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SurgeInvestigator : Template
    {
        public static readonly Guid ID = Guid.Parse("d378e1d8-c28e-4787-8684-29eb6be6fd66");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Surge Investigator",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("87742e15-5ed5-40b6-a242-d58631070dea"), Type = TextBlockType.Text, Text = "From rivers that charm all who come near to forests that speak through dream messages, you have seen and studied many kinds of magical terrain. The world is so rich in magic that it can affect the land itself, and you have traveled extensively to learn the ways of identifying the oddities of magical terrain wherever it arises." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.PervasiveMagic.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));

            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            });

            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.MagicalTerrain.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.TerrainExpertise.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8d6905b1-99e0-46fd-ae18-f8dc237d4455"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 219
            };
        }
    }
}
