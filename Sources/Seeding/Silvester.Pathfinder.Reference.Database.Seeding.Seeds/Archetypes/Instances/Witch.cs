using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Witch : Template
    {
        public static readonly Guid ID = Guid.Parse("7659ed27-1d6c-4761-b165-e7f34accb894");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Witch",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.WitchDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("777d3959-1f97-4763-a011-4e488bde1eb1"), Type = TextBlockType.Text, Text = "You have heard the whispers of a distant patron, who sent an emissary to teach you powerful magic." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ad5b99cb-5585-4cf5-9738-061d6656299e"), Type = TextBlockType.Text, Text = "The witch archetype grants versatile prepared spells, perfect for characters looking to add some extra utility." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c97263f5-e599-49f9-942e-70a8d73bb4a9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 154
            };
        }
    }
}
