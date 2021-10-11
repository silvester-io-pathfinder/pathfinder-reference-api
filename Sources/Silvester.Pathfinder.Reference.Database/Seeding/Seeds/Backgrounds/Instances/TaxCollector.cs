using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("68806108-03c6-4051-a59f-b6904d2a7081"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("e498c531-4421-4ff5-9b27-36b75b712647"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("ab689995-90ee-47cf-ba46-efe7811c5c69"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("85e38e34-9fdb-430f-84ae-86da75bed1ac")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("af8aeb23-519a-4f37-9003-e475ed10ef9f"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Intimidation.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("c2dfe62a-bb09-44eb-bd0d-9fd53380419b"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Settlements.ID,
                Restrictions = "The chosen Lore skill must be related to the settlement that employed you."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("3987bda8-ce56-4a59-8365-20713f269846"),
                FeatId = Feats.General.QuickCoercionFeat.ID
            };
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
