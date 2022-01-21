using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("9e00c35f-8d19-42fb-aa48-9be1f2245f67"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("b6ae2e28-67fb-43b9-b799-ca27f029e086"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("cc86560d-1bbc-41cb-9316-ec29ccb68c6a"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("55e3bf26-d5f7-414f-ae4b-fc26b6e752d7"));
            builder.GainSpecificSkillProficiency(Guid.Parse("4eabd811-e817-4e09-abb9-e9aeadda92c0"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificFeat(Guid.Parse("0f020d78-bf57-458d-8ca3-49d70fcd65cd"), Feats.Instances.CourtlyGraces.ID);
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
