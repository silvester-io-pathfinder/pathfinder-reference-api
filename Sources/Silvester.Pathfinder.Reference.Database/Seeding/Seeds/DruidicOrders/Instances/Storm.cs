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
    public class Storm : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Storm",
                Description = "You carry the fury of the storm within you, channeling it to terrifying effect and riding the winds through the sky. You are trained in Acrobatics. You also gain the Storm Born druid feat. You gain the tempest surge order spell, and you increase the number of Focus Points in your focus pool by 1. Polluting the air or allowing those who cause major air pollution or climate shifts to go unpunished is anathema to your order. (This doesn’t force you to take action against merely potential harm to the environment or to sacrifice yourself against an obviously superior foe.)",
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse(""), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.StormBorn.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TempestSurge.ID);
            builder.GainFocusPoolPoint(Guid.Parse(""));
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
