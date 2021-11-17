using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class Tinker : Template
    {
        public static readonly Guid ID = Guid.Parse("72dbc5dc-2f7b-45ed-bbc5-23c81d0316fa");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Tinker",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("b66cc7b6-06e5-44f4-8944-b75b88ba40fb"), Type = TextBlockType.Text, Text = "Creating all sorts of minor inventions scratches your itch for problem-solving. Your engineering skills take a particularly creative bent, and no one know what you'll come up with next. It might be a genius device with tremendous potential... or it might explode." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("d190ee12-33a6-4b50-b59d-09c1f25693f5"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("c4c43550-ffc5-4ad3-8bbe-fd9afdaedfe2"), Stats.Instances.Dexterity.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("0dfb7059-0d81-4949-b1e1-5f0e21c20777"), Stats.Instances.Intelligence.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("135d542e-588d-4194-8c38-ff3d4b822fd6"));
            builder.GainSpecificSkillProficiency(Guid.Parse("c9008a1e-d8fa-4f94-a688-83f5fb541433"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("7865cc0f-76d6-4d9a-9902-84ec43862bf1"), Proficiencies.Instances.Trained.ID, Lores.Instances.Engineering.ID);
            builder.GainSpecificFeat(Guid.Parse("b4e5fda3-fa2e-4c7c-bd2a-1e3a6cdfea88"), Feats.Instances.SpecialtyCrafting.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59cf5927-a48f-4459-b08a-4bd9f9ae84ee"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 64
            };
        }
    }
}
