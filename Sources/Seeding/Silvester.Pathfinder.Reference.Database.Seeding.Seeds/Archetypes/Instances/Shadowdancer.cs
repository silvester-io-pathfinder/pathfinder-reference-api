using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Shadowdancer : Template
    {
        public static readonly Guid ID = Guid.Parse("2a91dfdb-a76b-4f83-ac10-6ad29b139bfb");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Shadowdancer",
                DedicationFeatId = Feats.Instances.ShadowdancerDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7e198bed-4761-449f-a758-3583e25c23ae"), Type = TextBlockType.Text, Text = "Shadow has always been the cousin of fear. Within the darkness, monsters dwell, plans are hatched, and enemies strike with fang and dagger and dark magic. But some embrace the shadow, gain power from it, and dance within its shifting dark." };
            yield return new TextBlock { Id = Guid.Parse("80bbe9ff-358f-434b-ada8-48b8b2c09866"), Type = TextBlockType.Text, Text = "A true shadowdancer is a creature who flits on the edge of light and darkness. Moving amid the inky blackness, shadowdancers are spies, assassins, infiltrators, and emissaries. Some shadowdancers use their relationship with the dark for good, while others embrace the primordial night, its terror, and its betrayal." };
            yield return new TextBlock { Id = Guid.Parse("76494fe5-3e1f-4832-ad7f-e0f6673dd7ef"), Type = TextBlockType.Text, Text = "Regardless of the reason why someone embraces the shadows, the shadows embrace that person in turn, gradually transforming them into something inky, nebulous, and mysterious." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e2e98f45-d776-4bf7-8518-f4fd97766b3f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 192
            };
        }
    }
}
