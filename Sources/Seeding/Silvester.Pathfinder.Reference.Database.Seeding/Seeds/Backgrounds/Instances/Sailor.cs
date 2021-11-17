using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Sailor : Template
    {
        public static readonly Guid ID = Guid.Parse("a2df4965-424b-44e6-9993-737c1630645b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Sailor",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f1067b4a-f067-417e-a26a-2514df0b039d"), Type = TextBlockType.Text, Text = "You heard the call of the sea from a young age. Perhaps you signed onto a merchant's vessel, joined the navy, or even fell in with a crew of pirates and scalawags." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("49e988e9-bb41-4e46-b687-8602bbd969af"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("3c39f54e-df1c-4b36-b78b-84e3a83dad8b"), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("8576e28c-ff56-4c44-995c-68bab68e9a3b"), Stats.Instances.Dexterity.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("5cfc3e5a-9d08-4a21-b0ea-94743385371c"));
            builder.GainSpecificSkillProficiency(Guid.Parse("3ef817fa-84b5-4bd1-aab1-c076ff323582"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("d1a1b6d0-02bc-4f58-bbcf-88da342113a2"), Proficiencies.Instances.Trained.ID, Lores.Instances.Sailing.ID);
            builder.GainSpecificFeat(Guid.Parse("f2144366-444c-4e67-9325-fb7cb1896cd0"), Feats.Instances.UnderwaterMarauder.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("573aa7b3-aa70-4223-876a-02f9a68c905c"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 63
            };
        }
    }
}
