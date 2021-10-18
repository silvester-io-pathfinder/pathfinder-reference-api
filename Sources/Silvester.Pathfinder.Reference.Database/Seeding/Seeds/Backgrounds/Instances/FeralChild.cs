using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("ef8874a9-100f-4c2c-8bf0-7ad1bffea87d"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("6de13a10-6c40-430a-94d8-278a66d83e70"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("da35b177-fa98-4d7f-99a4-ecb89581dee5"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("b6cdf69f-6092-47dd-ae7b-b3311e743f17"), StatId = Stats.Instances.Constitution.ID }
                }
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("6e075fc6-bffe-4072-b61d-4204cce69a61"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Nature.ID
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("cf8f6b9b-8bf1-412f-85ab-498c0916601c"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Survival.ID
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("f56fdf9b-790e-4639-bc5b-048f333fa03b"),
                Restrictions = "The darkvision effect can only be chosen if you already have low-light vision.",
                Choices = new Effect[]
                {
                    new GainSpecificSenseEffect { Id = Guid.Parse("421b9e67-02c7-48c0-abb2-e84b626251f2"), SenseId = Senses.Instances.LowLightVision.ID, },
                    new GainSpecificSenseEffect { Id = Guid.Parse("09a56e27-0420-42ed-9722-0aad7d098f72"), SenseId = Senses.Instances.Darkvision.ID}
                }
            };

            yield return new GainSpecificSenseEffect
            {
                Id = Guid.Parse("5c467b81-6ea5-436f-bf4d-5090821798d7"),
                SenseId = Senses.Instances.Scent.ID,
                Range = "30 feet."
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("b31ace99-be35-45d8-a1dc-ef298dbffc4f"),
                FeatId = Feats.General.ForagerFeat.ID
            };
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
