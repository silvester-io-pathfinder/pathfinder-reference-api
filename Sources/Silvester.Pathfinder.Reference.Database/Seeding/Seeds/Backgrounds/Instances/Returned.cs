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
    public class Returned : Template
    {
        public static readonly Guid ID = Guid.Parse("dae8e0f6-75cc-4251-9c42-f6928399ff9a");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Returned",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4b9ac3e5-925d-4060-bd4d-a5f673c3e41e"), Type = TextBlockType.Text, Text = "You died and miraculously returned with knowledge of the realms beyond death and a stronger link to life. Some dead and undead souls might feel a strange, instinctual kinship with you." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.Diehard.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.AdditionalLore.ID, "Must relate to Boneyard Lore.");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00ad0304-372d-4a93-9263-f450aab8d248"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 51
            };
        }
    }
}
