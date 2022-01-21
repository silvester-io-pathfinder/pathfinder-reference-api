using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Gambler : Template
    {
        public static readonly Guid ID = Guid.Parse("a47cb440-1b8d-4025-ad21-b23a8d244e46");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Gambler",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ef36815d-013e-4e72-a807-b59b7209cd00"), Type = TextBlockType.Text, Text = "The thrill of the win drew you into games of chance. This might have been a lucrative sideline that paled in comparison to the real risks of adventuring, or you might have fallen on hard times due to your gambling and pursued adventuring as a way out of a spiral." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("83694175-f4dd-4e9e-a240-f1f594515118"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("6516c945-a3a7-4243-a550-f3532ca4ad66"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("4c81f069-3dd1-4a14-a236-61223ff31da5"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("87beac96-ea22-4ff0-9aa6-f1b01dd6dca9"));
            builder.GainSpecificSkillProficiency(Guid.Parse("bcf24333-b147-4a36-8fad-bec2c045029b"), Proficiencies.Instances.Trained.ID, Skills.Instances.Deception.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("fdf3befa-5019-46a4-ab18-4cfc6f0b53bc"), Proficiencies.Instances.Trained.ID, Lores.Instances.Games.ID);
            builder.GainSpecificFeat(Guid.Parse("f6bbbe6e-426a-4217-92c3-0df6eb6db699"), Feats.Instances.LieToMe.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8214780f-8ad9-4657-acb8-9c7963461006"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
