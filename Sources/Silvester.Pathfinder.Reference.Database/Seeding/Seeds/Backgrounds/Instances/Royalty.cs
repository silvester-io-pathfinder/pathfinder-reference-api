using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Royalty : Template
    {
        public static readonly Guid ID = Guid.Parse("a217be67-0579-40e3-b72f-4f3c9eb6b162");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Royalty",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fc5f8ebb-49af-4b48-ac03-ba0f13de9413"), Type = TextBlockType.Text, Text = "You are a prominent member of a royal family. You have taken up the life of an adventurer'perhaps you're a deposed queen hoping to regain her throne, a prince seeking a more exciting life, or a princess on a secret mission." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("0ee3ba14-6bbc-46f2-9eeb-6462b729fbd1"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("21b9ff78-9c27-46f6-a3b6-656105ede793"), StatId = Stats.Instances.Intelligence.ID },
                    new StatEffectBinding{Id = Guid.Parse("aa6c7597-b6db-411b-8b09-ac4dc6267916"), StatId = Stats.Instances.Charisma.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("398029b0-c479-476a-9dcf-8764a5a862ce")
            };

            yield return new RestrictedSkillEffect
            {
                Id = Guid.Parse("11c6e20b-a288-4b48-870e-d8d5de994c8a"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Society.ID
            };

            yield return new FeatEffect
            {
                Id = Guid.Parse("59127237-ead1-4ac6-b859-f01838b3610e"),
                FeatId = Feats.General.CourtlyGracesFeat.ID
            };

            yield return new InfluenceEffect
            {
                Id = Guid.Parse("debd6ace-69f7-4f31-a7b6-32b8f0f8b4ca")
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc01c083-219e-40d9-a63c-6e1e175720ce"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 51
            };
        }
    }
}
