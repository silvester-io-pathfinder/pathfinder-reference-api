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
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Muse GetMuse()
        {
            return new Muse
            {
                Id = ID, 
                Name = "Polymath",
                Description = "Your muse is a jack of all trades, flitting between skills and pursuits. If it's is a creature, it might be an eclectic creature like a fey; if a deity, it might be Desna or Calistria. As a bard with a polymath muse, you are interested in a wide array of topics but rarely dedicated to any one, and you rarely make up your mind—you want to try everything. You gain the Versatile Performance feat and add unseen servant to your spell repertoire."
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.VersatilePerformance.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.UnseenServant.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 97
            };
        }
    }
}
