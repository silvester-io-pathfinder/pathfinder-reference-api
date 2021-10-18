using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificAbilityBoostEffect
            {
                Id = Guid.Parse("9a39495a-85cb-4df3-9de0-364a25f02723"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("cbe0a379-6ab8-4fb6-b095-b29406a00ab1"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("f8a720aa-69f1-42ba-9e6f-cc19960f29dc"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new GainAnyAbilityBoostEffect
            {
                Id = Guid.Parse("fe050428-cbf5-43f1-a32c-a18cd1806269")
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("4a9b5c67-f478-4fb2-a93d-7d88e8b03348"),
                FeatId = Feats.General.DiehardFeat.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse("05b86921-f0ed-4301-82e8-1c67b2e298af"),
                FeatId = Feats.General.AdditionalLoreFeat.ID,
                Restrictions = "Must relate to Boneyard Lore."
            };
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
