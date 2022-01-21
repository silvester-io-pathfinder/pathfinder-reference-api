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
            builder.AddOr(Guid.Parse("3fc4c0d2-f4cd-4c95-b301-db22e62bcca3"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("ef79d4d9-1505-486c-ba22-602c26ee44c5"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("0371ccab-7b7d-412d-b2e0-5dcfb1ba0c08"), Stats.Instances.Wisdom.ID);
            });
            
            builder.GainAnyAbilityBoost(Guid.Parse("4781e8b4-f894-472c-bbf0-0e144a5ba9c4"));

            builder.AddOr(Guid.Parse("ec9e29d2-eed0-47ae-9954-a2c8d3de01b8"), or =>
            {
                or.AddAnd(Guid.Parse("47e76eb4-a452-4e13-972a-d1cb07d1d609"), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse("9f16f927-4774-4ca8-9b0c-99802bd617a4"), Proficiencies.Instances.Trained.ID, Skills.Instances.Arcana.ID);
                    and.GainSpecificFeat(Guid.Parse("8e7951ea-c304-4fb7-b498-3d9bd2469805"), Feats.Instances.Assurance.ID);
                });

                or.AddAnd(Guid.Parse("71854f95-17a8-40f8-a3ef-9875f1560da7"), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse("dd02bbd7-8be1-44dc-b9cc-50f6f0c8346a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
                    and.GainSpecificFeat(Guid.Parse("086af943-f084-4f13-a73c-ecdd33523143"), Feats.Instances.Assurance.ID);
                });

                or.AddAnd(Guid.Parse("813debd7-4782-4ce9-b71a-637da0db55ed"), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse("cd89dbb3-981c-4794-bd83-aa57e150471f"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                    and.GainSpecificFeat(Guid.Parse("e7513511-b4ef-4e73-bfdd-a269f3eeaab1"), Feats.Instances.Assurance.ID);
                });

                or.AddAnd(Guid.Parse("4e61da27-4989-43a4-ae75-37785cce91ac"), and =>
                {
                    and.GainSpecificSkillProficiency(Guid.Parse("97ae3f11-f42c-4c74-9aba-1a531c2b936e"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
                    and.GainSpecificFeat(Guid.Parse("50555e1a-6ee4-4bf9-b4c2-fd1c4ecdfa48"), Feats.Instances.Assurance.ID);
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
