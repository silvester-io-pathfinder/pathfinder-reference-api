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
    public class Acolyte : Template
    {
        public static readonly Guid ID = Guid.Parse("639750b4-63ef-43ec-a71a-194bb32dc02a");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Acolyte",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a6ae0f59-79d8-4a49-a088-add1850849fa"), Type = TextBlockType.Text, Text = "You spent your early days in a religious monastery or cloister. You may have traveled out into the world to spread the message of your religion or because you cast away the teachings of your faith, but deep down you'll always carry within you the lessons you learned." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("f85744a1-f414-4262-93b1-956471decef4"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("5c8f3cda-c2b2-4611-a5c5-d2610c0e246f"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("514b8056-2431-4346-aeaa-253644bb7fea"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("597e78b6-7471-46ad-a20d-44b8a1bb6970"));
            builder.GainSpecificSkillProficiency(Guid.Parse("dc45ef14-62cc-4c33-b1ea-c301718fa08c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("ee7d034b-83dc-411d-9fc5-e22d51c7d838"), Proficiencies.Instances.Trained.ID, Lores.Instances.Scribing.ID);
            builder.GainSpecificFeat(Guid.Parse("dcef3269-8b18-41a6-9762-7aabb5e1fa89"), Feats.Instances.StudentOfTheCanon.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f5df6e6-f849-4360-8cf9-7d0baa0999cf"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 60
            };
        }
    }
}
