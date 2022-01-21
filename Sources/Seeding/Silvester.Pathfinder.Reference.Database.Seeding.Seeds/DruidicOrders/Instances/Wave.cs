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
        public static readonly Guid ID = Guid.Parse("3bb3438d-45eb-442a-aea0-ec8fc67c4a33");
        
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
            builder.GainSpecificSkillProficiency(Guid.Parse("c5ac5777-fa90-43dc-9f8e-eef79ee23c00"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
            builder.GainSpecificFeat(Guid.Parse("2a261d2d-abff-4ea1-a642-316910aa8ea2"), Feats.Instances.ShoreStep.ID);
            builder.GainSpecificSpell(Guid.Parse("6d304b0b-956d-4c43-b95e-2a2f68cdc0a8"), Spells.Instances.RisingSurf.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("81668213-dc87-4ab7-bcc8-773683267e73"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 198
            };
        }
    }
}
