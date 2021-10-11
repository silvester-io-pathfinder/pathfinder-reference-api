using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class SpellSeeker : Template
    {
        public static readonly Guid ID = Guid.Parse("0e3e1af7-786c-483a-bc5e-db847edbeb78");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Spell Seeker",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8a619252-46be-42d7-ab0f-8b9043adea3d"), Type = TextBlockType.Text, Text = "Conventional magic can only hold your attention for so long. Instead, you've devoted yourself to understanding truly esoteric spells, which invariably draws you to explore the world and all its eldritch traditions." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("f6f3b122-68e8-4fd1-8395-3972434a11bb"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("406942f9-957c-47c3-8646-fa19a0b0a89a"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("ff029b0e-c9ca-40a1-9c73-be539a0eabb5"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("537aaecc-a1c3-4708-b55f-6686c149d64e")
            };

            yield return new ChoiceEffect
            {
                Id = Guid.Parse("a5d7ea57-92e2-4237-aeae-1cf418718d40"),
                Choices = new Effect[]
                {
                    new RestrictedSkillEffect { Id = Guid.Parse("cc43146e-2930-43fa-8337-98059806a2aa"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Arcana.ID },
                    new RestrictedSkillEffect { Id = Guid.Parse("ba5c245a-4f14-4ec1-ab9f-64d9e28e1d7a"), ProficiencyId = Proficiencies.Instances.Trained.ID, SkillId = Skills.Instances.Occultism.ID }
                }
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("e42fb7e3-9174-4075-8855-71db40265e86"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.Library.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("03b267df-f16d-483c-b3b9-2ead202b5656"),
                FeatId = Feats.General.RecognizeSpellFeat.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("40314b6d-bf68-4adb-a7af-5f3289d205e0"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 6
            };
        }
    }
}
