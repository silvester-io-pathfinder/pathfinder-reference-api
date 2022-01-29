using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Sorcerer : Template
    {
        public static readonly Guid ID = Guid.Parse("cbd72b7d-1c40-41c7-ad25-f4bf132430a2");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Sorcerer",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.SorcererDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("fb04d229-92d3-44c1-97b6-caa75513fb1d"), Type = TextBlockType.Text, Text = "You coax the magic power in your blood to manifest, accessing magic others don't expect you to have." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("29308fc0-b47d-4520-8cc2-e4bb2ddd5316"), Type = TextBlockType.Text, Text = "The sorcerer archetype is a method for anyone to pick up commonly useful spells, such as invisibility and haste." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d58b97b6-ee85-449c-a8ae-d39ef8efe568"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 230
            };
        }
    }
}
