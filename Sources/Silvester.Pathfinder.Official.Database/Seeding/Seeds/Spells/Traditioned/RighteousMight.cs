using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Instances
{
    public class RighteousMight : Template
    {
        public static readonly Guid ID = Guid.Parse("98daab63-ed2d-48d4-addf-680826d12a68");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Righteous Might",
                Level = 6,
                IsDismissable = true,
                Duration = "1 minute.",
                Requirements = "You have a deity.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("70d8e973-f45f-45c8-9883-9d5e5d0affc7"), Type = TextBlockType.Text, Text = "You focus all your divine energy and transform yourself into a Medium battle form, similar to your normal form but armed with powerful divine armaments granted by your deity. While in this form, you gain the statistics and abilities listed below. You have hands in this battle form and can use manipulate actions. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("710ff1eb-039f-4782-98b3-ad25eaccbf70"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities:" };
            yield return new TextBlock { Id = Guid.Parse("678b0001-9be3-475d-bf37-03760753d142"), Type = TextBlockType.Enumeration, Text = "AC = 20 + your level. Ignore your armor’s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("2770955e-4bac-4950-ba42-0408341d10c5"), Type = TextBlockType.Enumeration, Text = "10 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("bb74dfeb-7629-43a3-82cb-1eccddbcb42b"), Type = TextBlockType.Enumeration, Text = "Speed 40 feet." };
            yield return new TextBlock { Id = Guid.Parse("90afa4d1-a7c0-4ae9-9f6b-ff1af4789d5c"), Type = TextBlockType.Enumeration, Text = "Resistance 3 against physical damage." };
            yield return new TextBlock { Id = Guid.Parse("ab5a6f3d-8168-4dce-bc55-f2e4ecd07451"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("c1d7959e-22f9-453f-98c9-849906db47af"), Type = TextBlockType.Enumeration, Text = "A special attack with a righteous armament version of your favored weapon, which is the only attack you can use. Your attack modifier with the special weapon is +21, and your damage bonus is +8 (or +6 for a ranged attack). If your attack modifier with your deity’s favored weapon is higher, you can use it instead. You deal three of your weapon’s normal damage dice, or three damage dice of one size larger if your weapon is a simple weapon with a d4 or d6 damage die. The weapon has one of the following properties that matches your deity’s alignment: anarchic, axiomatic, holy, unholy. If your deity is true neutral, you instead deal an extra 1d6 precision damage." };
            yield return new TextBlock { Id = Guid.Parse("a498c048-67ef-428a-8d28-f3779bb7bb6d"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +23, unless your own modifier is higher." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("98deffab-2d19-4edd-9ee3-26d674285f45"), 
                Level = "8th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("c374231c-850b-4ec6-8528-a58c773a2a4c"), Type = TextBlockType.Text, Text = "Your battle form is Large, and your attacks have 10-foot reach, or 15-foot reach if your deity’s favored weapon has reach. You must have enough space to expand into or the spell is lost. You instead gain AC = 21 + your level, 15 temporary HP, resistance 4 against physical damage, attack modifier +28, damage bonus +15 (+12 for a ranged attack), and Athletics +29." }
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
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1005a137-0391-4f20-9b8e-f1b89b04c62e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 366
            };
        }
    }
}
