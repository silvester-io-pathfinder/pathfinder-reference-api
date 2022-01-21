using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders.Instances
{
    public class Animal : Template
    {
        public static readonly Guid ID = Guid.Parse("3a43068e-9230-452f-83f2-854cbec66bb5");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Animal",
                Description = "You have a strong connection to beasts, and you are allied with a beast companion. You are trained in Athletics. You also gain the Animal Companion druid feat. You gain the heal animal order spell. Committing wanton cruelty to animals or killing animals unnecessarily is anathema to your order. (This doesn�t prevent you from defending yourself against animals or killing them cleanly for food.)",
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("2610d1c4-4d40-46e6-a5be-ab9e4df83658"), Proficiencies.Instances.Trained.ID, Skills.Instances.Perception.ID);
            builder.GainSpecificFeat(Guid.Parse("6c5ef513-b742-483e-a477-e6007d3dc72e"), Feats.Instances.AnimalCompanion.ID);
            builder.GainSpecificSpell(Guid.Parse("51dd86a1-9347-4f3f-a79e-28358a4ad182"), Spells.Instances.HealAnimal.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9b0ba9b7-3297-4ac1-8198-8ece2c700952"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 131
            };
        }
    }
}
