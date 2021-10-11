using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Emissary : Template
    {
        public static readonly Guid ID = Guid.Parse("420cdbc4-ccc7-498f-bb97-a2fe212d6305");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Emissary",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("de760da8-c333-47a9-bac1-a3ddf57a7a4e"), Type = TextBlockType.Text, Text = "As a diplomat or messenger, you traveled to lands far and wide. Communicating with new people and forming alliances were your stock and trade." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("c2b85c0f-2168-4ecb-a33a-9ec0a3f98233"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("eaad8697-1d2c-4071-bc10-bc2c298e03b5"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("09fe8a43-595a-4d20-ae82-dbc10d7a3a4f"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("57d9b58f-e48e-4884-a726-c9d6e6409d26")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("7137c28b-077c-4a60-a2da-c082ac2b1804"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("485907fa-1cbb-4d22-8b41-d6afb96d35c2"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Settlements.ID,
                Restrictions = "The chosen Lore skill must be related to one city you've visited often."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("8018ba9f-546d-4e9c-bbea-cfa102a95ba6"),
                FeatId = Feats.General.MultilingualFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("231e63a2-ae4a-4765-a488-fa3c3971e495"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
