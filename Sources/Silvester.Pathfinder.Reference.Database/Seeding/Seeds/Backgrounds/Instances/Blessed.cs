using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Deities.ID, "The chosen Lore skill must be associated with the deity who blessed you (such as Shelyn Lore) if you know their identity, or else in a Lore skill of the GM's choise if you don't. Either you can cast guidance as a divine innate spell at will, or you gain a similar blessing determined by the GM.");
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
