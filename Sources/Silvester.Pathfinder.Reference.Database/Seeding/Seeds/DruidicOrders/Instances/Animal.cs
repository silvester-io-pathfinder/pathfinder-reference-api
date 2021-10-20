using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders.Instances
{
    public class Animal : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Animal",
                Description = "You have a strong connection to beasts, and you are allied with a beast companion. You are trained in Athletics. You also gain the Animal Companion druid feat. You gain the heal animal order spell. Committing wanton cruelty to animals or killing animals unnecessarily is anathema to your order. (This doesn’t prevent you from defending yourself against animals or killing them cleanly for food.)",
            };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Athletics.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.AnimalCompanion.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.HealAnimal.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 131
            };
        }
    }
}
