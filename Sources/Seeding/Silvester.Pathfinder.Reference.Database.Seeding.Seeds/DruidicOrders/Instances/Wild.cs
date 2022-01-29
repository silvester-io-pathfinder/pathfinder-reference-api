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
    public class Wild : Template
    {
        public static readonly Guid ID = Guid.Parse("149a8339-952b-4c4b-884c-c17f806839e3");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Wild",
                Description = "The savage, uncontrollable call of the natural world infuses you, granting you the ability to change your shape and take on the ferocious form of a wild creature. You are trained in Intimidation. You also gain the Wild Shape druid feat. You gain the wild morph order spell. Becoming fully domesticated by the temptations of civilization is anathema to your order. (This doesn't prevent you from buying and using processed goods or staying in a city for an adventure, but you can never come to rely on these conveniences or truly call such a place your permanent home.)",
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("d3e4875a-65c4-4bf8-b21d-5b3d19c0db47"), Proficiencies.Instances.Trained.ID, Skills.Instances.Intimidation.ID);
            builder.GainSpecificFeat(Guid.Parse("232fe76d-2819-41ee-8ec7-83dad4e0db75"), Feats.Instances.WildShape.ID);
            builder.GainSpecificSpell(Guid.Parse("70d76048-0130-4050-8e98-e40b1e85d6ad"), Spells.Instances.WildMorph.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e15b2c6b-d579-40c3-8d75-82de34d1f001"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 132
            };
        }
    }
}
