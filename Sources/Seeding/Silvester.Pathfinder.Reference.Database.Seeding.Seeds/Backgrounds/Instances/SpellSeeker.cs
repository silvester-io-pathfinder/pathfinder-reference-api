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
            builder.AddOr(Guid.Parse("4084b9b3-306f-4bc4-88df-ee940fdf0e37"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("160bf2aa-5a56-4506-9a7a-b96228c6ce79"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("9a8e53a4-d784-49e8-bcb3-3c318bd247e1"), Stats.Instances.Wisdom.ID);
            });
            
            builder.GainAnyAbilityBoost(Guid.Parse("fe204c03-1152-4b15-b32f-b2c7d9518d0c"));
            
            builder.AddOr(Guid.Parse("bf1f5098-77b7-463e-bcb8-186c46ab46a1"), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse("d243113d-1279-4d62-9332-90fced3dc53e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                or.GainSpecificSkillProficiency(Guid.Parse("476f8a17-4441-4443-a796-48d018ae00ac"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
            });

            builder.GainSpecificLoreProficiency(Guid.Parse("0cd56de0-7f67-408c-bf76-62756fcc5d05"), Proficiencies.Instances.Trained.ID, Lores.Instances.Library.ID);
            builder.GainSpecificFeat(Guid.Parse("731ea555-7017-48ae-ab09-dc853019044a"), Feats.Instances.RecognizeSpell.ID);
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
