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
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Strength.ID);
                or.GainSpecificAbilityBoost(Guid.Parse(""), Stats.Instances.Dexterity.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse(""));
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Lores.Instances.Sailing.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.UnderwaterMarauder.ID);
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
