using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class AntiMagical : Template
    {
        public static readonly Guid ID = Guid.Parse("ca70ec76-9123-4a40-b1db-05b4ad069815");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Anti-Magical",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7f66d889-9439-462f-b9b4-7869812e17c9"), Type = TextBlockType.Text, Text = "Magic has never worked quite right around you. Perhaps you have become a magic-user in spite of that, or perhaps you use your unique ability to fight magic-users." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainAnyLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, "The Lore skill you choose can't be about a magical subject (as determined by the GM if it's unclear).");
            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.AntiMagical.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89db3e88-d359-4ddd-835c-24d9da58607c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
