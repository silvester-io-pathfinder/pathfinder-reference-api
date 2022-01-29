using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Champion : Template
    {
        public static readonly Guid ID = Guid.Parse("e8a051be-fa71-45d0-a714-762ab7db8a8d");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Champion",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.ChampionDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2cec6ccf-ddf3-4fa0-bbd3-29c6f364b104"), Type = TextBlockType.Text, Text = "You have sworn a solemn oath to your deity, who has granted you champion powers to aid you in your cause." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2b8bd264-bd5b-4598-b25c-fec2eccad68b"), Type = TextBlockType.Text, Text = "The champion archetype greatly improves defenses, particularly armor. It's a great way for a character to gain armor proficiency or a powerful defensive reaction." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ed14b80-f51c-44c0-87aa-123d8baa2b80"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 223
            };
        }
    }
}
