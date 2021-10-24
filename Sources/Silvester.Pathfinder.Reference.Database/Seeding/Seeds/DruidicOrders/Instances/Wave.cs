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
    public class Wave : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Wave",
                Description = "Water is the source of life, and you've learned to shape how it flows. You're trained in Medicine. You also gain the Shore Step druid feat. You gain the rising surf order spell. Polluting water or allowing those who pollute water sources to go unpunished is anathema to your order (this doesn't force you to take action against potential water pollution or to sacrifice yourself against an obviously superior foe).",
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.AcroMedicinebatics.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ShoreStep.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.RisingSurf.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 198
            };
        }
    }
}
