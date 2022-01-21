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
    public class Emissary : Template
    {
        public static readonly Guid ID = Guid.Parse("420cdbc4-ccc7-498f-bb97-a2fe212d6305");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Emissary",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("de760da8-c333-47a9-bac1-a3ddf57a7a4e"), Type = TextBlockType.Text, Text = "As a diplomat or messenger, you traveled to lands far and wide. Communicating with new people and forming alliances were your stock and trade." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("3bae8e1d-98de-4e80-a3b3-3ed5c065de46"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("faff3975-177e-40aa-a3b7-0524fb912566"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("1407e5a6-d255-4119-ba55-55c0c378b5fe"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("4b5921a0-b42b-43e4-afc4-af9e0bd5aa24"));
            builder.GainSpecificSkillProficiency(Guid.Parse("70ae4f44-257e-423a-8688-72d6aec3a5bf"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreCategoryProficiency(Guid.Parse("b75e5e03-5d61-40bb-b33b-2102006b1395"), Proficiencies.Instances.Trained.ID, LoreCategories.Instances.Settlements.ID, "The chosen Lore skill must be related to one city you've visited often.");
            builder.GainSpecificFeat(Guid.Parse("e8685804-64b8-4879-860d-9884d5a60c5b"), Feats.Instances.Multilingual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("231e63a2-ae4a-4765-a488-fa3c3971e495"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 61
            };
        }
    }
}
