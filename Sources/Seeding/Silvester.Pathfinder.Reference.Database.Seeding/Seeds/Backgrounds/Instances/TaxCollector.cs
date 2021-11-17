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
    public class TaxCollector : Template
    {
        public static readonly Guid ID = Guid.Parse("7d52abb0-66b2-4dae-80ba-a7711c1def96");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Tax Collector",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("81bb57fe-73db-4670-ba25-3f949b054c91"), Type = TextBlockType.Text, Text = "Reviled but required, you were sent when taxes were due. Performing your job might have required travel and persuasion, or perhaps you were responsible for collecting taxes on trade. Either way, it sometimes meant dirty hands, and adventuring seemed the next logical step to you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("d9d8ff51-1f33-477a-8b34-7c6ae984eb63"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("c0e5e495-31e6-4e0a-9911-15ea3716c76d"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("581c19bb-11c5-46de-a026-97e82a0f689d"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("5857f7d4-f13b-4080-80e6-f3578a0fd8aa"));
            builder.GainSpecificSkillProficiency(Guid.Parse("d6764cf0-096a-4adb-8bc7-836dadeca9dc"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("bc2dd3ea-85aa-4286-986f-69542505cb2e"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Settlements.ID, "The chosen Lore skill must be related to the settlement that employed you.");
            builder.GainSpecificFeat(Guid.Parse("4bb9fd6e-90f6-48ec-9648-135a9efc1a1e"), Feats.Instances.QuickCoercion.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96f835fe-1e66-442f-9d8a-bbbad1553ba5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
