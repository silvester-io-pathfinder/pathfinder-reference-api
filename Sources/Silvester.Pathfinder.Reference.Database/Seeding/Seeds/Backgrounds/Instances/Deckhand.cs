using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Deckhand : Template
    {
        public static readonly Guid ID = Guid.Parse("43220e30-e085-40ca-840f-00c6b8f810b1");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Deckhand",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d7add1c3-4aa1-49fd-8491-816866797b0f"), Type = TextBlockType.Text, Text = "The rolling waves of the high seas, the constant sway of the deck underfoot, and the creaking heights of a ship's rigging are as familiar to you as solid ground. You might have worked on a simple fishing boat, a wealthy merchant's galley, a mighty warship'or even a pirate's caravel. Whether your crew retired, your ship sank, or you've turned to adventuring so you can keep all the treasure for yourself, you still retain an excellent sense of balance and quick reflexes." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Dexterity.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Sailing.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.CatFall.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("177d0300-ab51-499b-a5f9-66ff0998c644"),
                SourceId = Sources.Instances.PathfinderBeginnerBoxHerosHandbook.ID,
                Page = 18
            };
        }
    }
}
