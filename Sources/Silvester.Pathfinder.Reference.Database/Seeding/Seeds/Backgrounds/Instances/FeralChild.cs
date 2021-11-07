using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class FeralChild : Template
    {
        public static readonly Guid ID = Guid.Parse("cd3c5cda-ccec-4789-9aec-8daf41a2ad9c");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Feral Child",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7fdea2eb-b54c-46d5-9b6e-988ce4090a4e"), Type = TextBlockType.Text, Text = "You spent your youth in the wilderness, living close to or perhaps raised by animals. You have a close, mystical connection with these animals and gained certain abilities from them, though this limited your well-roundedness in mental pursuits." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
            });

            builder.AddAnd(Guid.Parse(""), and => 
            {
                and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Survival.ID);
            });

            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID, SenseAccuracies.Instances.Precise.ID);
                or.GainSpecificSense(Guid.Parse(""), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID)
                    .AddPrerequisites(Guid.Parse(""), prerequisites =>
                    {
                        prerequisites.HaveSpecificSense(Guid.Parse(""), Senses.Instances.LowLightVision.ID);
                    });
            });

            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.Scent.ID, SenseAccuracies.Instances.Imprecise.ID, "30 feet.");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Forager.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e51527d-46ec-4395-99c5-6114da611650"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 50
            };
        }
    }
}
