using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("566d7fce-5cef-4e1c-85d6-69806cb8a3b0"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("24ce839c-aa68-4111-ab80-ec8cc7db71d0"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("54cd05c9-6cc6-4b3a-a120-387c8e5d53e6"), StatId = Stats.Instances.Dexterity.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("97d4eea2-e1ce-42cd-924f-a32f1cbb4617")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("0a00fa2c-6bb4-4a43-9b23-8be9b64ec194"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Acrobatics.ID
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("4a4133d9-7b56-4374-a696-1bb2410cfd2e"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Sailing.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("4edf4999-194a-4e56-84ce-245229ca4b00"),
                FeatId = Feats.General.CatFallFeat.ID
            };
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
