using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Spells.Sorcerer.Instances
{
    public class ElementalMotion : Template
    {
        public static readonly Guid ID = Guid.Parse("480fa2b9-938d-4877-9f61-86d049b61233");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Elemental Motion",
                Level = 3,
                Duration = "1 minute.",
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                ClassId = Classes.Instances.Sorcerer.ID,
                SpellTypeId = SpellTypes.Instances.Focus.ID,
                MagicSchoolId = MagicSchools.Instances.Evocation.ID
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("feb6ca01-9f29-4b6a-8737-5131a55bcce8"), Type = TextBlockType.Text, Text = "You call upon your element to propel you, improving your Speed depending on your element. This spell has your element’s trait." };
            yield return new TextBlock { Id = Guid.Parse("c03e0350-dc8e-4eba-8650-a3e96a70e474"), Type = TextBlockType.Enumeration, Text = "Air - You gain a fly Speed equal to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("2088ca38-c9ec-441d-9a4f-33cf6ff4a448"), Type = TextBlockType.Enumeration, Text = "Earth - You gain a burrow Speed of 10 feet." };
            yield return new TextBlock { Id = Guid.Parse("15f5126b-6a91-4296-9048-2dccf58020c8"), Type = TextBlockType.Enumeration, Text = "Fire - You gain a fly Speed equal to your Speed." };
            yield return new TextBlock { Id = Guid.Parse("8749b21d-9c8f-443f-860d-f27e99bdbad8"), Type = TextBlockType.Enumeration, Text = "Water - You gain a swim Speed equal to your Speed and can breathe underwater." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("00a94ed6-cf51-4a38-89ff-1156b1d116ed"),
                Level = "6th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("47bd6d46-a21f-4c7a-8682-1109f91b81ff"), Type = TextBlockType.Text, Text = "You also gain a +10-foot status bonus to your Speeds." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("7f0d2cc9-8277-409b-9afe-2575182ac6dd"),
                Level = "9th",
                Details =
                {
                    new TextBlock { Id = Guid.Parse("05ce1fc8-6dc6-42a6-ae9d-304dc41c0f53"), Type = TextBlockType.Text, Text = "The status bonus increases to +20 feet." }
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
            yield return Traits.Instances.Evocation.ID;
            yield return Traits.Instances.Sorcerer.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dde107a9-cfa6-4ca1-b08d-2b33881c1c0b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 404
            };
        }
    }
}
