using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Acrobatic : Template
    {
        public static readonly Guid ID = Guid.Parse("b0df583c-486b-49c1-8fc2-08f934ce69ef");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Acrobatic",
                DedicationFeatId = Feats.Instances.AcrobatDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("c8eb737e-85a3-4000-b45c-1e7614fc13df"), Type = TextBlockType.Text, Text = "Acrobat You have trained your body to perform incredible, seemingly superhuman feats of grace. You move in ways that leave your opponents caught off guard and fumbling for a response, turning every fight into performance art." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d790b984-6147-452c-b188-130df104fdbc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 155
            };
        }
    }
}
