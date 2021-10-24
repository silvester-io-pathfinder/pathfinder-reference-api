using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class MagicalMisfit : Template
    {
        public static readonly Guid ID = Guid.Parse("e71170f4-f29e-46d9-8cc6-2d2246922a6c");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Magical Misfit",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("6b370145-e861-4117-b6e5-7e30ca514446"), Type = TextBlockType.Text, Text = "You don't understand folks who claim that magical talent is some sort of burden or great responsibility; you've always used your magic to cause trouble and to escape the consequences. Whether becoming an adventurer is your attempt to make amends or just a new way to make some mischief, you're excited to see where it takes you, and you still delight in using your skills to get out of trouble." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Underworld.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.TrickMagicItem.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("970a082d-82e9-4097-a414-09485f43269e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 29
            };
        }
    }
}
