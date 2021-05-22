using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class NaturesEnmity : Template
    {
        public static readonly Guid ID = Guid.Parse("68c02829-5dff-4f8c-9c7a-048f14c522be");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Nature's Enmity",
                Level = 9,
                Range = "120 feet.",
                Area = "500-foot burst.",
                Duration = "10 minutes.",
                Targets = "Up to 5 creatures.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dc0838d7-976b-43f7-822a-9b3a95d4c885"), Type = TextBlockType.Text, Text = "Animals and plants in the area turn against the targets. Each target suffers from the following effects as long as it remains in the area." };
            yield return new TextBlock { Id = Guid.Parse("9573dec5-c138-461f-a8f9-a72bcfad32a6"), Type = TextBlockType.Enumeration, Text = "Vegetation springs up from every surface, giving each target a –10-foot circumstance penalty to its Speed any time it’s adjacent to the plants." };
            yield return new TextBlock { Id = Guid.Parse("31c4954a-ebec-4019-a9bb-a1256f3f9353"), Type = TextBlockType.Enumeration, Text = "Aggressive animals attack unpredictably. At the start of its turn, each target rolls a DC 8 flat check. On a failure, it’s attacked by swarming creatures that deal 2d10 slashing damage. The target attempts a basic Reflex save, and it is flat-footed for 1 round on any outcome other than a critical success." };
            yield return new TextBlock { Id = Guid.Parse("44cf8de2-083c-4a79-89f9-d1af40bedf48"), Type = TextBlockType.Enumeration, Text = "The target loses any connection to nature or natural creatures. The target has to succeed at a DC 5 flat check when casting any primal spell or the spell fails. Furthermore, animal or plant creatures become hostile to it, even one with a strong bond to the target, such as an animal companion." };
            yield return new TextBlock { Id = Guid.Parse("466f27f1-870d-4683-a1b3-f5ef776c520b"), Type = TextBlockType.Text, Text = "The GM might decide that you can’t subject some creatures, such as an emissary of a nature deity, to the ire of nature." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Enchantment.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("23ad6fcc-6d77-4f99-ae12-eea24635a644"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 354
            };
        }
    }
}
