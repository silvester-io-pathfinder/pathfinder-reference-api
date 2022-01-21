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
    public class Winter : Template
    {
        public static readonly Guid ID = Guid.Parse("4f550801-c47f-4915-a0a6-3ddb3c5de710");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Winter",
                Description = "Your patron reflects the frozen reaches of the world, bitterly cruel to those who underestimate that power.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Nature.ID,
                MagicTraditionId = MagicTraditions.Instances.Primal.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.GustOfWind.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("ae585ed7-b423-422b-abdf-12ba440620c3"), MagicTraditions.Instances.Primal.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("e4e8c897-a1bb-4513-bc0e-2ffd1a99dd08"), Proficiencies.Instances.Trained.ID, Skills.Instances.Nature.ID);
            builder.GainSpecificSpell(Guid.Parse("39ebf659-6325-402c-9df0-9da7034a19e1"), Spells.Instances.ClingingIce.ID);
            builder.GainSpecificSpell(Guid.Parse("0265adcb-908e-4e54-8e9f-dc87ba497ca7"), Spells.Instances.GustOfWind.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ee488880-9e45-4c35-9cfc-ac33f2224b39"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
