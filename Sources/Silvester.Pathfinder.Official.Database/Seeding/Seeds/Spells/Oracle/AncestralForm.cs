using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class AncestralForm : Template
    {
        public static readonly Guid ID = Guid.Parse("e37e394e-c9a8-423d-8ad0-34b8f628226e");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ancestral Form",
                Level = 6,
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Oracle.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
                MysteryId = Mysteries.Instances.Ancestors.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ccc09e3b-c6f2-4fde-a925-186ed1f57dd5"), Type = TextBlockType.Text, Text = "You take the form of your ancestral spirits, becoming invisible and quasi-corporeal. You gain resistance 10 to all damage (except force and damage from Strikes with the ghost touch property rune), and this resistance is doubled against non-magical and precision damage. You gain a fly Speed equal to your land Speed; when Flying, moving upward isn’t difficult terrain for you. You can’t move through solid objects, but you can float through tiny gaps. You can’t Cast Spells (but you can Sustain a Spell), activate items, or use actions that have the attack or manipulate trait." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("2d401ab3-90a6-48fe-ba20-ceeb404f91fe"),
                Level = "+2",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("d202900c-f17a-4778-a7b5-c402b8291fcc"), Type = TextBlockType.Text, Text = "The resistance increases by 5." }
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
            yield return Traits.Instances.Cursebound.ID;
            yield return Traits.Instances.Oracle.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("db0b37ac-eb6f-44dc-849c-f8e1e03d1ffa"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 230
            };
        }
    }
}
