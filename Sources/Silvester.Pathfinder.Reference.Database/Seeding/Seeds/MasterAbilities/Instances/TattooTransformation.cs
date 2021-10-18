using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.MasterAbilities.Instances
{
    public class TattooTransformation : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override MasterAbility GetMasterAbility()
        {
            return new MasterAbility
            {
                Id = ID, 
                Name = "Tattoo Transformation", 
                Description = "Your familiar can transform into a tattoo you carry on your flesh. When transformed into a tattoo, the familiar looks like a colorful and stylized version of itself and can't act except to turn back into a familiar. It isn't affected by area effects and must be targeted separately to affect it, which requires knowledge that it's a creature. This means you and your allies can heal or assist the familiar while most enemies stay unaware of its true nature. Creatures must attempt a DC 20 Perception check to Seek to realize a tattoo is actually a familiar (which few foes will try). Your familiar can still communicate its feelings empathically. Transforming into a tattoo or back to familiar form is a 1-minute activity that has the concentrate trait."
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GrandBazaar.ID,
                Page = 34
            };
        }
    }
}
