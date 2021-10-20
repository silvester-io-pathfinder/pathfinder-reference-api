using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DruidicOrders.Instances
{
    public class Wild : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Wild",
                Description = "The savage, uncontrollable call of the natural world infuses you, granting you the ability to change your shape and take on the ferocious form of a wild creature. You are trained in Intimidation. You also gain the Wild Shape druid feat. You gain the wild morph order spell. Becoming fully domesticated by the temptations of civilization is anathema to your order. (This doesn’t prevent you from buying and using processed goods or staying in a city for an adventure, but you can never come to rely on these conveniences or truly call such a place your permanent home.)",
            };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect
            {
                Id = Guid.Parse(""),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                SkillId = Skills.Instances.Intimidation.ID
            };

            yield return new GainSpecificFeatEffect
            {
                Id = Guid.Parse(""),
                FeatId = Feats.Instances.WildShape.ID
            };

            yield return new GainSpecificSpellEffect
            {
                Id = Guid.Parse(""),
                SpellId = Spells.Instances.WildMorph.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 132
            };
        }
    }
}
