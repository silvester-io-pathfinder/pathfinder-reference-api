using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class ChosenOne : Template
    {
        public static readonly Guid ID = Guid.Parse("d377435d-ba0c-40c6-b0cb-deac1c4dcdf4");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Chosen One",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("e8274903-d289-47a5-8e56-5da1db75aa2d"), Type = TextBlockType.Text, Text = "Your birth has fulfilled a prediction, and people close to you are counting on you to do great things. There's intense pressure on you to be up to the task, and the fickle nature of prophecy complicates your path." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("96524d7d-ef57-4846-baff-ada17dec8b12"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("866129b1-a542-4c5d-82ce-a384eb3e261a"), StatId = Stats.Instances.Strength.ID },
                    new StatEffectBinding{Id = Guid.Parse("59da49be-5310-4127-8f34-ee0c9212b246"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("fa2d99b9-bf24-4b28-9421-84e14c7a7fa2")
            };

            yield return new ProphecyEffect
            {
                Id = Guid.Parse("9575b734-c7dc-4510-bce9-1446ea760bca")
            };

            yield return new FreeSkillEffect
            {
                Id = Guid.Parse("17fe6968-c7bb-4ca0-897b-6e7888f2a658"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Restrictions = "The chosen skill must be related to the prophecy."
            };

            yield return new LoreEffect
            {
                Id = Guid.Parse("fc479416-d676-4e34-8bc7-e819d5812d26"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                LoreId = Lores.Instances.FortuneTelling.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("844e15d7-a9ee-4e32-bac0-dc8d8705ca46"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
