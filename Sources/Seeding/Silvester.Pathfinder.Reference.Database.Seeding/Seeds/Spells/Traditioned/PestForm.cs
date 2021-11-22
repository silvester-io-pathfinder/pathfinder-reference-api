using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class PestForm : Template
    {
        public static readonly Guid ID = Guid.Parse("3203cdc7-f538-44b4-b0f5-502a6b30134f");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Pest Form",
                Level = 1,
                IsDismissable = true,
                Duration = "10 minutes.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b1ded820-723a-4c52-9cc1-0d1848e6b67a"), Type = TextBlockType.Text, Text = "You transform into the battle form of a Tiny animal, such as a cat, insect, lizard, or rat. You can decide the specific type of animal (such as a rat or praying mantis), but this has no effect on the form's Size or statistics. While in this form, you gain the animal trait. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("3d24d758-0043-4b4d-8106-595d9f5b64d0"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities:" };
            yield return new TextBlock { Id = Guid.Parse("057a2488-2f2c-432f-b92d-231980372ac1"), Type = TextBlockType.Enumeration, Text = "AC = 15 + your level. Ignore your armor's check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("9775396d-bdd9-48bf-82a9-6a326928347f"), Type = TextBlockType.Enumeration, Text = "Speed 10 feet." };
            yield return new TextBlock { Id = Guid.Parse("8d8337ba-17e7-4a1a-b284-00ee075ee314"), Type = TextBlockType.Enumeration, Text = "Weakness 5 to physical damage. If you take physicaldamage in this form, you take 5 additional damage." };
            yield return new TextBlock { Id = Guid.Parse("0e61a117-937d-4044-a13c-648394a42871"), Type = TextBlockType.Enumeration, Text = "Low-light vision and imprecise scent 30 feet." };
            yield return new TextBlock { Id = Guid.Parse("333e7324-22c2-458d-9808-756f33be753c"), Type = TextBlockType.Enumeration, Text = "Acrobatics and Stealth modifiers of +10, unless your own modifier is higher; Athletics modifier –4." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("45569bbb-c894-4894-ac9e-6dfab1be8369"), 
                Level = "4th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("db44fb8c-d220-4b26-8902-ad432ffb0252"), Type = TextBlockType.Text, Text = "You can turn into a flying creature, such as a bird, which grants you a fly Speed of 20 feet." }
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
            yield return Traits.Instances.Polymorph.ID;
            yield return Traits.Instances.Transmutation.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9cfb1892-c462-42e6-b997-79aacd737ad0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 356
            };
        }
    }
}
