using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Courier : Template
    {
        public static readonly Guid ID = Guid.Parse("82e4edad-a6cc-44bf-9aec-33494940f095");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Courier",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4f97926d-0e42-45ce-a547-a827f0a283ff"), Type = TextBlockType.Text, Text = "In your youth, you earned coin running messages for persons of wealth and influence, darting through crowded cobblestone streets. Your dogged commitment to deliver your message was good training for the life of an adventurer." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("ba0d9b13-cc70-4786-860c-2ed5b863a550"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("438ad8fa-852f-4718-88f8-430a6a2370a2"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("bebdc5d3-704b-4e5a-91a1-210cd08dbeb2"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("7146c055-601d-452c-9f1d-7fd40d353b77"));
            builder.GainSpecificSkillProficiency(Guid.Parse("ec57d670-3559-4eea-878d-7329ec91d612"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("abd7f53e-5b25-4101-a24d-c876ed1b508c"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Settlements.ID, "The chosen Lore skill must be for the city in which you were raised.");
            builder.GainSpecificFeat(Guid.Parse("5236f589-4a70-4de2-818e-66596cc49b91"), Feats.Instances.GleanContents.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c778f189-697f-4d5b-8554-f321ddd95de4"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 48
            };
        }
    }
}
