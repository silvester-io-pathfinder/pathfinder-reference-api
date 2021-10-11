using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Refugee : Template
    {
        public static readonly Guid ID = Guid.Parse("faf783f7-7f80-4b3e-a4e5-d2e6386adc80");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Refugee",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b8444229-4de9-4670-8fd2-3acc09b3a474"), Type = TextBlockType.Text, Text = "You come from a land very distant from the one you now find yourself in, driven by war, plague, or simply in the pursuit of opportunity. Regardless of your origin or the reason you left your home, you find yourself an outsider in this new land. Adventuring is a way to support yourself while offering hope to those who need it most." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("d96b21cc-d447-484f-a69d-88758c3d6559"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("dcd8ab88-ddce-4bb7-99ba-42fe895ebd31"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("28dc642e-cc1e-4af4-bfee-f82b40030b12"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("fbda09dc-c34e-432f-9784-4b033d85d9ff")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("f3d9f1ce-365f-4872-bbfe-875d4ebb1ec5"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("4615864f-239c-4cea-b835-e8b3e77574ec"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Settlements.ID,
                Restrictions = "The chosen Lore skill must be related to the settlement you came from."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("681e0960-1933-49c0-bdcc-b7161abee5eb"),
                FeatId = Feats.General.StreetwiseFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("21680c69-90b8-40ec-bf51-a79e09411945"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 49
            };
        }
    }
}
