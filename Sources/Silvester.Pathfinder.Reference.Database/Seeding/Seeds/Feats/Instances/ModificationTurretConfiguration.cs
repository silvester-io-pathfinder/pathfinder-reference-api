using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationTurretConfiguration : Template
    {
        public static readonly Guid ID = Guid.Parse("70beda21-3cff-4530-b76e-1538ae8484d6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Turret Configuration",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("49046fd3-4cc7-46b9-ab14-8bff63b5d411"), Type = TextBlockType.Text, Text = "Your innovation can transform from a mobile construct to a stationary turret. Your construct companion can transform as a single action, which has the (trait: manipulate) trait, turning into a turret in its space (or transforming back from a turret into its normal configuration). While it’s a turret, your innovation is immobilized, but the damage die from its projectile launcher increases to 1d6 and the range increment increases to 60 feet. You must have the (feat: projectile launcher | Modification - Projectile Launcher) modification to select this modification." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("600b4ada-543c-411a-b8f6-5d8d8f6e9623"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
