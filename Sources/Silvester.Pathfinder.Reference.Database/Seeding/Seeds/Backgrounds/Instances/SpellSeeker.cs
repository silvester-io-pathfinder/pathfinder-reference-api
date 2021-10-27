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
    public class SpellSeeker : Template
    {
        public static readonly Guid ID = Guid.Parse("0e3e1af7-786c-483a-bc5e-db847edbeb78");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Spell Seeker",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8a619252-46be-42d7-ab0f-8b9043adea3d"), Type = TextBlockType.Text, Text = "Conventional magic can only hold your attention for so long. Instead, you've devoted yourself to understanding truly esoteric spells, which invariably draws you to explore the world and all its eldritch traditions." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });
            
            builder.GainAnyAbilityBoost(Guid.Parse(""));
            
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            });

            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Library.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.RecognizeSpell.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40314b6d-bf68-4adb-a7af-5f3289d205e0"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 6
            };
        }
    }
}
