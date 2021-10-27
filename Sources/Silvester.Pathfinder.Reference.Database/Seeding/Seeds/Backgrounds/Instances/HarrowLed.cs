using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class HarrowLed : Template
    {
        public static readonly Guid ID = Guid.Parse("3719c441-3a06-40a1-bdaf-ac7afaf0d8b5");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Harrow-Led",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7629d11b-fcf3-4c37-8496-3717fdc8071d"), Type = TextBlockType.Text, Text = "You were the subject of a harrow reading at a pivotal point in your life, such as on an important birthday, or upon reaching adulthood. The reading was eerily accurate and has been relevant, for good or ill, at more points in your life than you could call mere coincidence." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Aasimar.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainAnyHarrow(Guid.Parse(""));
            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Performance.ID);
                or.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            });

            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Harrow.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.DubiousKnowledge.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ffdb8cb-cb40-4e7c-b3a3-e19d4b51d7d7"),
                SourceId = Sources.Instances.Pathfinder160.ID,
                Page = 66
            };
        }
    }
}
