using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Dismantle : Template
    {
        public static readonly Guid ID = Guid.Parse("36127701-f08d-4ab3-8dd7-d7530a1b782c");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Dismantle",
                Level = 2,
                Range = "Touch.",
                IsDismissable = true,
                Duration = "1 minute.",
                Targets = "1 non-magical object in your possession of 1 bulk or less.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("23dc6bf3-9768-4946-8346-6d4f558bab07"), Type = TextBlockType.Text, Text = "You touch an object, and it immediately disassembles itself into its component pieces. The spell fails if the target lacks component pieces (such as a statue carved from one block of stone), and using it on a dangerous object like a snare or trap typically triggers it. The object gains the broken condition, and the component pieces become small enough to be hidden under normal clothing and armor. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("b72031b9-01a9-474f-84a1-ed81bdbf7826"), Type = TextBlockType.Text, Text = "When the spell ends, the object reassembles itself into its original form, appearing in your hand or hands if you have them free, or on the ground in front of you otherwise. Once reassembled, the object loses the broken condition and its Hit Points return to the value the object had when you Cast the Spell." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("1bdc506d-2d4b-411c-ba32-dab56d3be1c0"),
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("6069822c-d8db-4b86-9f97-93c42c076540"), Type = TextBlockType.Text, Text = "The spell lasts for 10 minutes." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("aea2af4d-b434-4973-aa5f-d544130badaa"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c2969ccc-af17-46f0-ada8-df00c2600767"), Type = TextBlockType.Text, Text = "The spell lasts until your next daily preparations." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Arcane.ID;
            yield return MagicTraditions.Instances.Primal.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b8fdc225-8df5-406c-bcef-6b34a72b17a5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 218
            };
        }
    }
}
