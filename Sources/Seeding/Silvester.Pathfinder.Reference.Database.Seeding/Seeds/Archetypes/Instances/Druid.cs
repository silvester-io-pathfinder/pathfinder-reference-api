using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Druid : Template
    {
        public static readonly Guid ID = Guid.Parse("ee390cb5-e1d2-476c-a87d-954293a02719");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Druid",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.DruidDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("81afa49c-acf3-4b57-961b-2ab059942acf"), Type = TextBlockType.Text, Text = "You have entered a druidic circle and learned a few of the order�s secrets, granting you primal power." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("9cb50335-b76a-449d-b389-874f1561194e"), Type = TextBlockType.Text, Text = "The druid archetype can provide a bit of healing or elemental damage and can increase your utility in a natural environment with spells like speak with animals and meld into stone." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("185350e1-8352-4cd2-b537-cbcdfbf4f36f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 225
            };
        }
    }
}
