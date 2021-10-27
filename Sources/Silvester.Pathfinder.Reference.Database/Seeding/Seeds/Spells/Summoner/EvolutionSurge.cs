using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class EvolutionSurge : Template
    {
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You flood your eidolon with power, creating a temporary evolution in your eidolon's capabilities. Choose one of the following effects:" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon gains low-light vision and darkvision." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon gains scent as an imprecise sense up to 30 feet." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon can breathe underwater and gains a swim Speed equal to its land Speed or 30 feet, whichever is less. Alternatively, if your eidolon is normally aquatic, it can breathe air and gains a land Speed equal to its swim Speed or 30 feet, whichever is less. Either way, it gains the amphibious trait." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon gains a +20-foot status bonus to its Speed." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "3rd",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Add the following options to the list of effects you can choose:" },
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon becomes Large, instead of its previous size. This increases your eidolon's reach to 10 feet but doesn't change any other statistics for your eidolon. Because of the special link you share, you can ride your eidolon without getting in each other's way. If another creature tries to ride your eidolon, both you and the riding creature each regain only 2 actions at the start of your turns each round, as normal." },
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon gains a climb Speed equal to its land Speed." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse(""),
                Level = "5th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Add the options from the 3rd-level version and the following options to the list of effects you can choose:" },
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon becomes Huge, instead of its previous size. This has the same effects as the 3rd-level option to become Large, except your eidolon's reach increases to 15 feet." },
                    new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Your eidolon gains a fly Speed equal to its Speed." }
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 144
            };
        }
    }
}
