using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Muses.Instances
{
    public class Polymath : Template
    {
        public static readonly Guid ID = Guid.Parse("56dd9316-3f35-47ad-93d0-53b7cb30d5ff");
        
        protected override Muse GetMuse()
        {
            return new Muse
            {
                Id = ID, 
                Name = "Polymath",
                Description = "Your muse is a jack of all trades, flitting between skills and pursuits. If it's is a creature, it might be an eclectic creature like a fey; if a deity, it might be Desna or Calistria. As a bard with a polymath muse, you are interested in a wide array of topics but rarely dedicated to any one, and you rarely make up your mind�you want to try everything. You gain the Versatile Performance feat and add unseen servant to your spell repertoire."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("6792d164-cdbf-4eb8-91c1-33a5810c01b2"), Feats.Instances.VersatilePerformance.ID);
            builder.GainSpecificSpell(Guid.Parse("7b2d4809-1cd2-47ce-9dde-63cfcc504379"), Spells.Instances.UnseenServant.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9a233610-7ad0-45b6-a4d4-3296202ee190"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 97
            };
        }
    }
}
