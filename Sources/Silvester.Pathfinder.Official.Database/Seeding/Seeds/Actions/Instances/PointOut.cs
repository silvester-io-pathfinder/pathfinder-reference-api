using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Classes;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.RaceSizes;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Actions.Instances
{
    public class PointOut : AbstractActionTemplate
    {
        public static readonly Guid ID = Guid.Parse("187ebb2b-c829-4d40-81dd-414a48ea766e");

        protected override Models.Action GetAction(ActionSeeder seeder)
        {
            return new Models.Action
            {
                Id = ID,
                Name = "Point Out",
                Requirements = "A creature is undetected by one or more of your allies but isn’t undetected by you.",
                ActionTypeId = seeder.GetActionType("One Action"),
            };
        }

        protected override IEnumerable<TextBlock> GetDetails(ActionSeeder seeder)
        {
            yield return new TextBlock { Id = Guid.Parse("e9c5de9d-eef6-46d4-ae1b-0dee8958af0c"), Text = "You indicate a creature that you can see to one or more allies, gesturing in a direction and describing the distance verbally. That creature is hidden to your allies, rather than undetected (page 466). This works only for allies who can see you and are in a position where they could potentially detect the target. If your allies can’t hear or understand you, they must succeed at a Perception check against the creature’s Stealth DC or they misunderstand and believe the target is in a different location." };
        }

        protected override IEnumerable<Trait> GetTraits(ActionSeeder seeder)
        {
            yield return seeder.GetTrait("Auditory");
            yield return seeder.GetTrait("Manipulate");
            yield return seeder.GetTrait("Visual");
        }
    }
}
