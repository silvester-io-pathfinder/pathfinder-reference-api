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
        public static readonly Guid ID = Guid.Parse("587ed86c-a4e6-4c3a-a0a2-152e5bb6d76e");
        
        protected override DruidicOrder GetDruidicOrder()
        {
            return new DruidicOrder
            {
                Id = ID, 
                Name = "Storm",
                Description = "You carry the fury of the storm within you, channeling it to terrifying effect and riding the winds through the sky. You are trained in Acrobatics. You also gain the Storm Born druid feat. You gain the tempest surge order spell, and you increase the number of Focus Points in your focus pool by 1. Polluting the air or allowing those who cause major air pollution or climate shifts to go unpunished is anathema to your order. (This doesn�t force you to take action against merely potential harm to the environment or to sacrifice yourself against an obviously superior foe.)",
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSkillProficiency(Guid.Parse("fc3dacff-4822-434a-9117-772d96946812"), Proficiencies.Instances.Trained.ID, Skills.Instances.Acrobatics.ID);
            builder.GainSpecificFeat(Guid.Parse("876307b1-fc9f-4650-959e-dea4e9d0ccc3"), Feats.Instances.StormBorn.ID);
            builder.GainSpecificSpell(Guid.Parse("475cf50a-79e2-48b8-95b1-1c8f065860fc"), Spells.Instances.TempestSurge.ID);
            builder.GainFocusPoolPoint(Guid.Parse("6b4bc1b6-54ba-45f1-b365-22bcf9151bd3"));
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("56cee677-9c9c-4523-8884-e8f073c2856b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 132
            };
        }
    }
}
