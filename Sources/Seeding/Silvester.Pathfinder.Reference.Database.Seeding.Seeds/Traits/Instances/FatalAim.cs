using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Traits.Instances
{
    public class FatalAim : Template
    {
        public static readonly Guid ID = Guid.Parse("4ee76c4d-d167-4ee8-874b-9ddc45be99ff");

        protected override Trait GetTrait()
        {
            return new Trait
            {
                Id = ID,
                Name = "Fatal Aim",
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cbd94cbe-d1eb-4f62-bdd1-689a860ce0b8"), Type = TextBlockType.Text, Text = "It's possible to hold the stock of this weapon under one arm so you can fire it with a single hand as long as the other hand isn't holding a weapon, shield, or anything else you would need to move and position, to ensure the weapon doesn't slip out from under your arm. However, if you use both hands, the weapon can make fatal attacks. When you wield the weapon in two hands, it gains the fatal trait with the listed damage die. Holding the weapon underarm stably enough to fire is significantly more complicated than just releasing one hand from the weapon, so to switch between the two grips, you must do so with an Interact action rather than Releasing or as part of reloading." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("301dfce0-b109-4623-bf47-b0b846686cc8"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 151
            };
        }
    }
}
