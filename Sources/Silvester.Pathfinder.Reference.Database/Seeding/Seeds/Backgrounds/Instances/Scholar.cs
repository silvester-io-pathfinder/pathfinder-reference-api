using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Scholar : Template
    {
        public static readonly Guid ID = Guid.Parse("fb442e73-4d3c-4e7a-87e2-c135da6c5024");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Scholar",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5445779f-6c29-458a-9bce-2582ca7e87e2"), Type = TextBlockType.Text, Text = "You have a knack for learning, and sequestered yourself from the outside world to learn all you could. You read about so many wondrous places and things in your books, and always dreamed about one day seeing the real things. Eventually, that curiosity led you to leave your studies and become an adventurer." };
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
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Assurance.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Assurance.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Assurance.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
                    and.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Assurance.ID);
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c5f506a-2d83-43fd-952d-fae77f034915"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
