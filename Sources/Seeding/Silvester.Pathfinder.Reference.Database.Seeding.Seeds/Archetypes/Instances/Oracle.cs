using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Oracle : Template
    {
        public static readonly Guid ID = Guid.Parse("69635c6d-a5e9-412d-ab31-a32339ad0bdd");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Oracle",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.OracleDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("aaf2085c-7c27-4d15-b8ac-984817772323"), Type = TextBlockType.Text, Text = "A mysterious force granted you divine magic and a curse." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bca36a61-9aed-46c0-b578-0a31e49db350"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 152
            };
        }
    }
}
