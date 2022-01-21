using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Archetypes.Instances
{
    public class Wizard : Template
    {
        public static readonly Guid ID = Guid.Parse("da123422-db97-428a-9d1f-394c00da640e");
        
        protected override Archetype GetArchetype()
        {
            return new Archetype
            {
                Id = ID, 
                Name = "Wizard",
                IsMulticlassArchetype = true,
                DedicationFeatId = Feats.Instances.WizardDedication.ID 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d535185a-7492-420c-babd-21c18a69a99a"), Type = TextBlockType.Text, Text = "You have dabbled in the arcane arts and, through discipline and academic study, learned how to cast a few spells." };
        }

        protected override IEnumerable<TextBlock> GetMulticlassDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4ed856ed-59dd-4ace-8c75-517da514c127"), Type = TextBlockType.Text, Text = "The wizard archetype grants versatile prepared spells, perfect for characters looking to add some extra utility." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("95475484-dddd-45ad-ba4d-b717708c437f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 231
            };
        }
    }
}
