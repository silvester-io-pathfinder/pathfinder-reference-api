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
    public class Translator : Template
    {
        public static readonly Guid ID = Guid.Parse("28e4cebf-f091-48d1-982f-5e25f154655b");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Translator",
                RarityId = Rarities.Instances.Common.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("5e84ab99-bcf9-4b52-ac9d-783f38685840"), Type = TextBlockType.Text, Text = "In your youth, you learned to transcribe books and translate scrolls to preserve knowledge or perhaps to aid wealthy merchants and politicians. Whether you set out to make your own fortune or are drawn to decipher the strangest codes, your linguistic training will guide your discoveries." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("f53105fc-6b38-41ca-8969-278cf6cad158"), or =>
            {
                or.GainSpecificAbilityBoost(Guid.Parse("a1fdc3d8-0a3e-4872-b9a6-d67aab176cdd"), Stats.Instances.Intelligence.ID);
                or.GainSpecificAbilityBoost(Guid.Parse("e68f217a-e0cf-4d94-b23a-e16c4e926445"), Stats.Instances.Charisma.ID);
            });

            builder.GainAnyAbilityBoost(Guid.Parse("ad7f17f7-b439-4fac-9bdb-045f90b2448b"));
            builder.GainSpecificSkillProficiency(Guid.Parse("e3abacab-b5bd-4f4b-9a62-6fd7138a35eb"), Proficiencies.Instances.Trained.ID, Skills.Instances.Society.ID);
            builder.GainSpecificLoreProficiency(Guid.Parse("dfd6a764-c787-4e29-939e-325c7b88c957"), Proficiencies.Instances.Trained.ID, Lores.Instances.Scribing.ID);
            builder.GainSpecificFeat(Guid.Parse("6e305b08-7614-4516-8207-66cb92e85dd5"), Feats.Instances.Multilingual.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0fa367ec-2b5f-45dc-933b-cb7ebe83542b"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = 6
            };
        }
    }
}
