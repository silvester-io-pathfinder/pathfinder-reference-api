using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class NeedleOfVengeance : Template
    {
        public static readonly Guid ID = Guid.Parse("cb8f4863-75a1-4e04-a567-502a643c49fd");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Needle of Vengeance",
                Level = 1,
                Range = "30 feet.",
                Targets = "1 enemy.",
                IsDismissable = true,
                Duration = "Sustained up to 1 minute.",
                IsSavingThrowBasic = true,
                SavingThrowStatId = SavingThrowStats.Instances.Will.ID,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                ClassId = Classes.Instances.Witch.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Enchantment.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("cb8f4863-75a1-4e04-a567-502a643c49fd"), Type = TextBlockType.Text, Text = "A long, jagged needle jabs into the target foe’s psyche whenever it tries to attack a specifically forbidden creature. Name yourself or one of your allies. The target takes 2 mental damage any time it uses a hostile action against the named creature." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("cb8f4863-75a1-4e04-a567-502a643c49fd"),
                Level = "+1",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("cb8f4863-75a1-4e04-a567-502a643c49fd"), Type = TextBlockType.Text, Text = "Increase the damage by 2." }
                }
            };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Somatic.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Uncommon.ID;
            yield return Traits.Instances.Enchantment.ID;
            yield return Traits.Instances.Hex.ID;
            yield return Traits.Instances.Mental.ID;
            yield return Traits.Instances.Witch.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cb8f4863-75a1-4e04-a567-502a643c49fd"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 238
            };
        }
    }
}
