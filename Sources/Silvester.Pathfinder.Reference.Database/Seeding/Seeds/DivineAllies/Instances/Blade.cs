using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineAllies.Instances
{
    public class Blade : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override DivineAlly GetDivineAlly()
        {
            return new DivineAlly
            {
                Id = ID, 
                Name = "Blade",
                Description = "A spirit of battle dwells within your armaments. Select one weapon or handwraps of mighty blows when you make your daily preparations. In your hands, the item gains the effect of a property rune and you also gain the weapon's critical specialization effect. For a champion following the tenets of good, choose disrupting, ghost touch, returning, or shifting. For a champion following the tenets of evil, choose fearsome, returning, or shifting."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 108
            };
        }
    }
}
