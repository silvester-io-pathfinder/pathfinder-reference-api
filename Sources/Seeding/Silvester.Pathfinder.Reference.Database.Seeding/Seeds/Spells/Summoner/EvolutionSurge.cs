using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EvolutionSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("28f30cf0-d71c-41b1-ae7f-90084a9ce8ed");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Evolution Surge",
                Level = 1,
                Range = "100 feet.",
                Targets = "Your eidolon.",
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Summoner.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("60c46ee1-5f2d-47f0-86ac-5689854b6f3e"), Type = TextBlockType.Text, Text = "You flood your eidolon with power, creating a temporary evolution in your eidolon's capabilities. Choose one of the following effects:" };
            yield return new TextBlock { Id = Guid.Parse("6c6ef4e6-1dda-4f38-ab2e-0e04fcee8677"), Type = TextBlockType.Enumeration, Text = "Your eidolon gains low-light vision and darkvision." };
            yield return new TextBlock { Id = Guid.Parse("49af1bb2-0b16-4554-96ae-f2bb81296d31"), Type = TextBlockType.Enumeration, Text = "Your eidolon gains scent as an imprecise sense up to 30 feet." };
            yield return new TextBlock { Id = Guid.Parse("c54fbf90-c1ba-4651-8d48-39b3dc17276e"), Type = TextBlockType.Enumeration, Text = "Your eidolon can breathe underwater and gains a swim Speed equal to its land Speed or 30 feet, whichever is less. Alternatively, if your eidolon is normally aquatic, it can breathe air and gains a land Speed equal to its swim Speed or 30 feet, whichever is less. Either way, it gains the amphibious trait." };
            yield return new TextBlock { Id = Guid.Parse("531f1530-42a8-4ac5-88c7-622ccea7ef57"), Type = TextBlockType.Enumeration, Text = "Your eidolon gains a +20-foot status bonus to its Speed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("50dea972-846c-4027-80b7-917250934562"),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("ed656a55-cc34-45e7-8ccf-3a775fef1e87"), Type = TextBlockType.Text, Text = "Add the following options to the list of effects you can choose:" },
                    new TextBlock { Id = Guid.Parse("4792a5ef-527c-424d-8edd-a998bbcc9259"), Type = TextBlockType.Enumeration, Text = "Your eidolon becomes Large, instead of its previous size. This increases your eidolon's reach to 10 feet but doesn't change any other statistics for your eidolon. Because of the special link you share, you can ride your eidolon without getting in each other's way. If another creature tries to ride your eidolon, both you and the riding creature each regain only 2 actions at the start of your turns each round, as normal." },
                    new TextBlock { Id = Guid.Parse("c5e5649b-6c62-464f-8b95-e7172e5e3b51"), Type = TextBlockType.Enumeration, Text = "Your eidolon gains a climb Speed equal to its land Speed." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("216dc1c1-b710-4844-a65b-054c828967b9"),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cb63e184-3cda-406e-9f36-ae2cb6678daf"), Type = TextBlockType.Text, Text = "Add the options from the 3rd-level version and the following options to the list of effects you can choose:" },
                    new TextBlock { Id = Guid.Parse("9402cb40-d4f5-4a70-affa-c3c0b79a2f2d"), Type = TextBlockType.Enumeration, Text = "Your eidolon becomes Huge, instead of its previous size. This has the same effects as the 3rd-level option to become Large, except your eidolon's reach increases to 15 feet." },
                    new TextBlock { Id = Guid.Parse("50c05d23-fef0-46a3-9e32-0053fc6760be"), Type = TextBlockType.Enumeration, Text = "Your eidolon gains a fly Speed equal to its Speed." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Morph.ID;
            yield return Traits.Instances.Summoner.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c741ba3f-1991-47a9-92d5-a4fae97330fd"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 144
            };
        }
    }
}
