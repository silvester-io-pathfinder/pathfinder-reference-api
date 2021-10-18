using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Vigilante : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Vigilante",
                DedicationFeatId = Feats.Instances.VigilanteDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "As a vigilante, you have two faces: a public persona, and a secret identity that lets you hide your extralegal actions from polite society. Your secret identity lets you adventure and carry out clandestine missions while keeping the civilians you care about safe. Whatever your purpose— fighting crime, inciting rebellion, sowing chaos—your vigilante identity makes you both hard to pin down and a mysterious, intriguing subject of gossip." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 196
            };
        }
    }
}
