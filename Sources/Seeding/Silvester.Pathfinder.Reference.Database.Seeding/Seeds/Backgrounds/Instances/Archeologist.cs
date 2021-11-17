using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Archeologist : Template
    {
        public static readonly Guid ID = Guid.Parse("ae217709-be61-47a8-b835-e2da36eb4556");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Archeologist",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1e0c5636-a810-4446-adab-a97594123e4e"), Type = TextBlockType.Text, Text = "You've excavated enough sites to know that ancient civilizations aren't lost; they're merely buried and waiting for the right scholar to unearth them and tell their story. You might have worked as a laborer or local guide before learning formal archaeological techniques." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("ab95117f-8025-4ed6-9a8d-7132a56885c2"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("e05cd259-b1fc-4c63-92f9-a9d21acad6dd"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("871ca9b5-6b99-4cdc-9edd-64bed4d344bd"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("14ef083f-9854-4a3c-820d-78bea4c9b0e8"));
            builder.GainSpecificSkillProficiency(Guid.Parse("2ff8bbc9-f74c-46f9-8225-1afc85bcdc2c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("8b1bce92-83d8-46c9-ad3b-85074466a1de"), Proficiencies.Instances.Trained.ID, Lores.Instances.Architecture.ID);
            builder.GainSpecificFeat(Guid.Parse("1d3e937b-c514-4d99-9fe7-3162a61b7806"), Feats.Instances.AdditionalLore.ID, "Must be related to an ancient culture or the history of a culture you've studied (such as Azlanti Lore or Osirian History Lore).");
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("22721aed-8015-45b1-8bb2-c914c7c24f44"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 6
            };
        }
    }
}
