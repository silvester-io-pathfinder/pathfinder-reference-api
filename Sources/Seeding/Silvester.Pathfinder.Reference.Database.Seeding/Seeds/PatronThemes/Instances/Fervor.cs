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
    public class Fervor : Template
    {
        public static readonly Guid ID = Guid.Parse("610ed201-cfa2-41f9-8918-f8945dfb88e4");
        
        protected override PatronTheme GetPatronTheme()
        {
            return new PatronTheme
            {
                Id = ID, 
                Name = "Fervor",
                Description = "Your patron represents a grand ideal or goal, granting you magic to further their mission and bring others to the cause.",
                RarityId = Rarities.Instances.Common.ID,
                PatronSkillId = Skills.Instances.Religion.ID,
                MagicTraditionId = MagicTraditions.Instances.Divine.ID,
            };
        }

        protected override IEnumerable<Guid> GetGrantedSpellOptions()
        {
            yield return Spells.Instances.Command.ID;
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("018d4183-1dd3-498f-ae15-99deaca30b7a"), MagicTraditions.Instances.Divine.ID);
            builder.GainSpecificSkillProficiency(Guid.Parse("ad89221b-5c50-45b8-a797-7c9481d9e6a2"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            builder.GainSpecificSpell(Guid.Parse("83175589-bfb9-4f9e-a197-3458f0aed16a"), Spells.Instances.StrokeTheHeart.ID);
            builder.GainSpecificSpell(Guid.Parse("7dfcedcd-5af5-4523-980f-e7235e0cc38f"), Spells.Instances.Command.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de1f5f0d-37a6-480b-b788-3aa4f08a1fb3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 99
            };
        }
    }
}
