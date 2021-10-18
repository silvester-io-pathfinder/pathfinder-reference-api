using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Bandit : Template
    {
        public static readonly Guid ID = Guid.Parse("42f87045-dbef-47b3-b756-50a00346b924");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Bandit",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("395880ae-850b-4c16-91cb-394ed10bdb7c"), Type = TextBlockType.Text, Text = "Your past includes no small amount of rural banditry, robbing travelers on the road and scraping by. Whether your robbery was sanctioned by a local noble or you did so of your own accord, you eventually got caught up in the adventuring life. Now, adventure is your stock and trade, and years of camping and skirmishing have only helped." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("15bb098c-0823-40cf-b1d6-c52ebc7d0c51"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("d19c8249-1fdf-477b-93ee-dc47eae198bd"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("e1e1d70b-2042-490d-b5c9-c5c0d6964219"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("96fb59fc-5f60-46ca-b548-2866a69fdda4")
            };

            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse("2909f61e-5ad8-48c5-8f7c-74dd938ece41"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Intimidation.ID
            };

            yield return new GainSpecificLoreCategoryProficiencyEffect
            {
                Id = Guid.Parse("cb36cae4-d147-485b-8688-c50695c423e1"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Terrains.ID,
                Restrictions = "The chosen lore skill must be related to a terrain you've worked in (such as Deser Lore or Plains Lore)."
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("1e45a705-cf03-4967-8baa-5081c5bd65b7"),
                FeatId = Feats.General.GroupCoercionFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a26c282-f8a9-4d89-9771-e437d2001bf9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
