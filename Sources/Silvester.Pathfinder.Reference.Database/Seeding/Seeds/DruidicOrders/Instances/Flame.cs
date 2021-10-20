using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders.Instances
{
    public class Flame : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Flame",
                Description = "You feel a kinship with flames and can use them for succor and destruction. You're trained in Acrobatics. You also gain the Fire Lung druid feat. You gain the wildfire order spell. Allowing unnatural fires to spread or preventing natural fires from occurring in a way that harms the environment are anathema to your order (this doesn't prevent you from using fire destructively or force you to combat a controlled or natural fire).",
            };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Acrobatics.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.FireLung.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.Wildfire.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 198
            };
        }
    }
}
