using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class Blackaxe : Template
    {
        public static readonly Guid ID = Guid.Parse("926863c7-4212-4b4c-9351-72a59548218a");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Blackaxe",
                Usage = "Held in 2 hands.",
                ItemLevel = 25,
                BulkId = Bulks.Instances.TwoBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ca277f35-ec88-454a-8f06-3dc304030a85"), Type = TextBlockType.Text, Text = "This potent weapon used by Treerazer is a +4 greater corrosive major striking obsidian greataxe that grants a +4 item bonus to attack rolls, deals an extra 2d6 damage to plants, and has the properties of adamantine." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("1bab1fef-7fa2-426c-8445-c920a26b4056"),
                Name = "Divination, Scrying",
                Requirements = "You aren't wielding Blackaxe and you are its true owner.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("42791d95-bda6-468f-bfdd-ca6ddc1a38e3"), Type = TextBlockType.Text, Text = "You sense the world around Blackaxe as though you were in its location and can use any of your innate spells through the link as if it were the source of the spell. If another creature is wielding Blackaxe, it must succeed at a DC 50 Will save or be slowed 2 until it relinquishes the weapon." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("0c37b3ea-002f-414e-b674-d37519246087"),
                Name = "Command",
                Requirements = "You aren't wielding Blackaxe and you are its true owner.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("c0755216-c588-47e0-b217-f0bd4f39f3d9"), Type = TextBlockType.Text, Text = "Blackaxe appears in your hands, teleporting instantly from its prior location." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("b300bad6-b1b0-4f67-a343-197d13322b4c"),
                Name = "Command",
                Frequency = "Once per minute.",
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("a8c1aaf6-409c-4b31-b1d5-dec133ee04cc"), Type = TextBlockType.Text, Text = "Make a Strike against a living tree with Blackaxe. If it hits, the tree withers to ash and you heal 250 Hit Points and gain the benefit of restoration (6th) and restore senses." }
                }
            };
        }

        protected override IEnumerable<Guid> GetActionTraits(ArtifactAction action)
        {
            ArtifactAction[] actions = GetActions().ToArray();

            if (action.Equals(actions[0]))
            {
                yield return Traits.Instances.Divination.ID;
                yield return Traits.Instances.Scrying.ID;
            }

            if (action.Equals(actions[1]))
            {
                yield return Traits.Instances.Conjuration.ID;
                yield return Traits.Instances.Teleportation.ID;
            }

            if (action.Equals(actions[2]))
            {
                yield return Traits.Instances.Death.ID;
                yield return Traits.Instances.Healing.ID;
                yield return Traits.Instances.Necromancy.ID;
            }
        }
        
        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Cursed.ID;
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Primal.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("96be0c17-2b16-4a03-95ea-638593688ac2"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 313
            };
        }
    }
}
