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
            builder.AddOr(Guid.Parse("92db4284-64d5-4429-bd88-6f1c4f276d0b"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("144b1e11-6f67-4d3a-9ad2-f6dd5f10716b"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("02ec0c54-35e8-4675-a178-5fd9bb622dbb"), Stats.Instances.Dexterity.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("8bb9849b-9767-4fc2-a7d7-48c4b5540317"));
            builder.GainSpecificSkillProficiency(Guid.Parse("571cfa9c-9b01-42ca-a4ca-b4061408beb2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("d10f0ebb-e870-4f1f-9539-55b3c6fabb28"), Proficiencies.Instances.Trained.ID, Lores.Instances.Sailing.ID);
            builder.GainSpecificFeat(Guid.Parse("aa381a83-d6b6-4581-982c-791e42a1c592"), Feats.Instances.CatFall.ID);
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
