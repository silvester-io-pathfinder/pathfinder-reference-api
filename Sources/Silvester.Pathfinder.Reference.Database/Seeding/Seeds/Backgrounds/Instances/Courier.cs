using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("f138baa5-28bd-41ff-94a9-7853df6745ef"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("a3523fb5-f203-409a-a14f-0f36e37773f8"), StatId = Stats.Instances.Dexterity.ID },
                    new StatEffectBinding{Id = Guid.Parse("17db942b-46fb-4f26-872c-082dd460e83a"), StatId = Stats.Instances.Intelligence.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("8dc64c22-97d6-4a6d-a467-4f7ee15a321f")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("e8cd4d28-1490-45fc-9254-13f5bdbcf388"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("3ea9799c-ac87-419b-b41f-a1f16efb35be"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Settlements.ID,
                Restrictions = "The chosen Lore skill must be for the city in which you were raised."
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("d5ae01d2-a0dd-4c8f-a2c7-7c51f44ca3fa"),
                FeatId = Feats.General.GleanContentsFeat.ID
            };
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
