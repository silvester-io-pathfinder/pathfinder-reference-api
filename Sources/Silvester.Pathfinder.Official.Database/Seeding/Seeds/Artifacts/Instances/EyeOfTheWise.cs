using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class EyeOfTheWise : Template
    {
        public static readonly Guid ID = Guid.Parse("68d3579e-e06f-49d1-90d6-d414cb6b38cc");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Eye of the Wise",
                Usage = "Held in 1 hand.",
                ItemLevel = 11,
                BulkId = Bulks.Instances.LightBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("dcc038e9-e37a-4dde-8500-315430bd9228"), Type = TextBlockType.Text, Text = "This fist-sized, 12-rayed black star sapphire is sacred to Yuelral, the elven goddess of magic and jewels, and most accounts of its creation attribute its crafting to a circle of her worshippers. In addition to the abilities listed below, the gem functions as a portal key for Jewelgate at Alseta's Ring." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("2d1bc28d-1b4e-408d-8070-ed1e5be6f3ce"),
                Name = "Interact",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("f30a0a33-3689-48ab-8ad3-c3eb38949d53"), Type = TextBlockType.Text, Text = "You touch the Eye of the Wise to a gem worth at least 10 gp, whereupon the Eye of the Wise assumes the appearance of the touched gemstone. While this connection is active, the carriers of the Eye of the Wise and of the other gemstone can communicate telepathically with one another over any distance, as long as both are on the same plane. This connection is broken if the other gemstone is damaged, if the Eye of the Wise becomes attuned to another gemstone, or if the bearer of the Eye of the Wise Dismisses the activation." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("9867095f-815a-487e-953a-e564ca0e34d7"),
                Name = "Interact",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("cd759e79-e988-4d07-8f55-16e08196f23b"), Type = TextBlockType.Text, Text = "You hold the Eye of the Wise up to your own eye and peer through it. The Eye of the Wise grows transparent and grants you a +2 item bonus to attempts to Decipher Writing, Disable a Device, Identify Magic, Pick a Lock, Seek, or Sense Motive. You can Sustain this activation as long as you hold the gem in place." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Divination.ID;
            yield return Traits.Instances.Invested.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("502d5295-e966-4580-866e-b218155302ad"),
                SourceId = Sources.Instances.Pathfinder147.ID,
                Page = 72
            };
        }
    }
}
