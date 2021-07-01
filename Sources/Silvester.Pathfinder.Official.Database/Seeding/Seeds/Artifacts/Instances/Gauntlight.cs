using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Artifacts.Instances
{
    public class Gauntlight : Template
    {
        public static readonly Guid ID = Guid.Parse("b4db8880-410e-4dbb-b645-c3f185eb05fd");

        protected override Artifact GetArtifact()
        {
            return new Artifact
            {
                Id = ID,
                Name = "Gauntlight",
                Destruction = "If Belcorra's ghost is permanently destroyed, Gauntlight loses all of its magical properties and collapses in on itself all the way down to its base, leaving an incredibly deep pit in the Fogfen.",
                ItemLevel = 20,
                BulkId = Bulks.Instances.NegligibleBulk.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8a36d614-6dba-4072-8429-815632f8ee42"), Type = TextBlockType.Text, Text = "Gauntlight is much more than a 115-foot-tall lighthouse rising from the heart of an old ruin in Fogfen—its pale stone walls extend far below the ruins, passing through eight different dungeon levels and finally terminating at the ninth level below the surface, where its deep foundation centers on an ominous chamber where, long ago, Nhimbaloth herself once physically brushed against this world. Once she finished its physical construction, the sorcerer Belcorra Haruvex used this spot as a source of power to infuse the walls, floors, and ceilings of each of Gauntlight's levels with eldritch power. The lens at the apex of the lighthouse would have, in time, been able to focus this lingering eldritch energy into a powerful beam, but Belcorra's plans were cut short before she could replace the mundane lenses with dangerous magical ones." };
            yield return new TextBlock { Id = Guid.Parse("9f0d6f61-9bba-47e5-b23f-fafb872fb9c3"), Type = TextBlockType.Text, Text = "As an artifact, Gauntlight can't be damaged by normal means. Its walls are impenetrable and impervious to any attempt to breach them by anybody except for followers of Nhimbaloth. They block effects that allow temporary passage, such as passwall, and also create a barrier against dimensional travel. The walls attempt to counteract teleportation effects and planar travel into or out of areas within Gauntlight and efforts to summon creatures into the area (using a +37 counteract modifier); this effect does not stop a summoned creature from departing when the summoning ends." };
            yield return new TextBlock { Id = Guid.Parse("3e421240-dab3-4c28-a64c-43b19c62a867"), Type = TextBlockType.Text, Text = "In Gauntlight's current state of diminished functionality, it can be activated only in the two ways below. By swapping in a series of magical lighthouse lenses that focus Nhimbaloth's baleful gaze—lenses so powerful that even Belcorra takes special care with them—the artifact gains significantly greater power, including the ability to reach all the way to Absalom and to activate its effects every minute. These lenses are described in “Eyes of Empty Death,” the third adventure in the Abomination Vaults Adventure Path." };
            yield return new TextBlock { Id = Guid.Parse("369b9774-9f0c-402b-b623-4a4822cfddd8"), Type = TextBlockType.Text, Text = "To activate Gauntlight, a creature must be in the deepest portion of the artifact (this chamber is in the Temple level and is presented in “Eyes of Empty Death”). From this point, a creature can observe the world outside remotely through Gauntlight's lens, including any area Gauntlight's beam can reach." };
        }

        protected override IEnumerable<ArtifactAction> GetActions()
        {
            yield return new ArtifactAction
            {
                Id = Guid.Parse("79d034b0-dd32-4be4-b943-10d34f8e7d50"),
                Name = "Interact",
                Frequency = "Once per month.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("9f6c3d2e-8ab1-492b-bf50-8d209b6424fa"), Type = TextBlockType.Text, Text = "A pale blue beam shines from Gauntlight's lens and illuminates a 30-foot-radius burst centered on any point within 1 mile. The light saturates the region, causing any corpses in the area or within 10 feet of the surface of the illuminated area to animate as level –1 undead (typically as skeleton guards or zombie shamblers). Once animated, the undead remain active until slain. Until then, they remain uncontrolled and are driven only by the desire to slaughter the living. If Gauntlight is fully restored, the undead instead animate as any Common undead of 15th level or less, as the user wishes." }
                }
            };

            yield return new ArtifactAction
            {
                Id = Guid.Parse("5b89399e-0a7a-47e7-841b-b98c38f799cf"),
                Name = "Interact",
                Frequency = "Once per month.",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                Effects = new[]
                {
                    new TextBlock { Id = Guid.Parse("7778b8c7-8514-44df-a33c-1b0128b3219f"), Type = TextBlockType.Text, Text = "A pale blue beam shines from Gauntlight's lens and illuminates a 30-foot-radius burst centered on any point within 1 mile. The user chooses one creature of 4th level or less that is physically located within Gauntlight; this creature is then is teleported to any point within this illumination radius. If Gauntlight is fully restored, any number of creatures within Gauntlight of 15th level or lower can be transported. This is a teleportation effect." }
                }
            };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Unique.ID;
            yield return Traits.Instances.Artifact.ID;
            yield return Traits.Instances.Magical.ID;
            yield return Traits.Instances.Necromancy.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("84a11818-1218-489c-9a5a-e90c3580cff6"),
                SourceId = Sources.Instances.Pathfinder163.ID,
                Page = 77
            };
        }
    }
}
