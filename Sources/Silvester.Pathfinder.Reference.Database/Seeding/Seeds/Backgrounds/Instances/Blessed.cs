using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Blessed : Template
    {
        public static readonly Guid ID = Guid.Parse("db5416fb-e971-4f38-9ec7-1016535d326c");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Blessed",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("76ffd282-8a5e-48d6-885e-e4ba05c51917"), Type = TextBlockType.Text, Text = "You have been blessed by a divinity. For an unknown reason, and irrespective of your actual beliefs, a deity has granted you a boon to use for good or ill. Your blessing grants wisdom and insight to aid you in your struggles. You may or may not even know the identity of the being who blessed you, and the blessing might come with a cost you discover later on." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("4194d513-b772-4b72-9e7c-1be7713908f2"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("260c2b06-d8f7-49c7-a30d-64dfa0a1f120"), StatId = Stats.Instances.Wisdom.ID },
                    new StatEffectBinding{Id = Guid.Parse("099e7683-71b6-4cbd-b3ca-f2addb49e7a2"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("98ed4ed6-c8b8-403d-81da-40a42b35812b")
            };

            yield return new LoreCategoryEffect
            {
                Id = Guid.Parse("a54d9147-b543-4eae-96cd-948d5521cc29"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreCategoryId = LoreCategories.Instances.Deities.ID,
                Restrictions = "The chosen Lore skill must be associated with the deity who blessed you (such as Shelyn Lore) if you know their identity, or else in a Lore skill of the GM's choise if you don't. Either you can cast guidance as a divine innate spell at will, or you gain a similar blessing determined by the GM."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9fefdc73-5405-4279-a8a0-d1742c32083f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 50
            };
        }
    }
}
