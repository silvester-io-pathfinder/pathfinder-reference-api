using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PlayModes.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Herbalist : Template
    {
        public static readonly Guid ID = Guid.Parse("34b36070-ff49-4d02-924e-67d7459e5007");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Herbalist",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("a4c2b312-60d0-461e-911d-9118d0deba87"), Type = TextBlockType.Text, Text = "As a formally trained apothecary or a rural practitioner of folk medicine, you learned the healing properties of various herbs. You're adept at collecting the right natural cures in all sorts of environments and preparing them properly." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("71505aef-1079-4f8f-958d-9f99bb5803e4"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("6733c17a-6afe-44c1-82a7-19b73c3610a6"), Stats.Instances.Constitution.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("2f3c97aa-02c5-4a9a-9440-ebe23d6aa62e"), Stats.Instances.Wisdom.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("09ac47f1-984f-412f-9649-439c83cd8863"));
            builder.GainSpecificSkillProficiency(Guid.Parse("f8235fe7-d3d4-4208-bb14-0bf1513c3101"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("7a51502c-db15-482b-99b9-d833570f0f89"), Proficiencies.Instances.Trained.ID, Lores.Instances.Herbalism.ID);
            builder.GainSpecificFeat(Guid.Parse("7fc4356c-7fd1-4d73-8c79-d0fb7bb42b6f"), Feats.Instances.NaturalMedicine.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f209f713-7e88-40a4-90ce-6b279884784a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 62
            };
        }
    }
}
