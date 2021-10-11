using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class GenieBlessed : Template
    {
        public static readonly Guid ID = Guid.Parse("2db31e00-46e2-40ce-90c9-d4dfcea59cd9");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Genie-Blessed",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("74dedb9a-fb19-4a39-874d-46e40db59e96"), Type = TextBlockType.Text, Text = "You've sought out a powerful genie and requested their blessing, hoping to increase your fortune. Your wish was vague, but fortune and the genie favored you with a more powerful effect than an ordinary wish, granting you bits of wish-twisted luck throughout the rest of your life. Meanwhile, other genies of the same kind recognize you as one blessed by one of their most powerful nobles, and might treat you with greater respect or envy." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("b676b479-f8c4-4d90-bfcc-fd536036adc1"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("78130684-85eb-4f85-a027-4b4a9c2d557e"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("062cf293-1074-460c-b1ae-2607cb176513")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("c474b4a5-fd16-467e-8ae0-dfd6ff4616ee"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Diplomacy.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("d0bf8d0c-0c99-40e3-8a08-3aeafbcfd2ed"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Genie.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("775c2a4f-9246-4d26-991c-56b4a5d11141"),
                FeatId = Feats.Special.WishForLuckFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d16ce6bd-3767-4a84-ae05-53ae805d5c28"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
