using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.PatronThemes.Instances
{
    public class Wild : Template
    {
        public static readonly Guid ID = Guid.Parse("7b0a6eaa-8d13-4789-91a8-cec0fdb3a5bf");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Wild",
                Description = "The wild places of the world feel the touch of your patron.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Nature.ID,
                MagicTraditionId = MagicTraditions.Instances.Primal.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.SummonAnimal.ID;
            yield return Spells.Instances.SummonPlantOrFungus.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("5f0b3c1a-a662-46cf-a548-8d2e8c897fff"), MagicTraditions.Instances.Primal.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("cf65efac-fdf1-4835-89b7-5629509bb247"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificSpell(Guid.Parse("5e0756e3-c944-424d-8409-d0398b6bedaf"), Spells.Instances.WildingWord.ID);

            builder.AddOr(Guid.Parse("0181c7ab-edce-41ed-bc1d-5d9f0b802fed"), or => 
            {
                or.GainSpecificSpell(Guid.Parse("cd381d74-e956-4fe0-bafe-f19d4f0b1719"), Spells.Instances.SummonAnimal.ID);
                or.GainSpecificSpell(Guid.Parse("771f0aa1-c293-4a00-82fa-923d5dacd7d3"), Spells.Instances.SummonPlantOrFungus.ID);
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e6feaf85-db6d-4034-a2e2-3ac558f718e0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
