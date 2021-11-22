using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class SummonDeificHerald : Template
    {
        public static readonly Guid ID = Guid.Parse("494035fc-c16a-4d38-b68d-de4cd793c687");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Summon Deific Herald",
                Level = 8,
                Range = "100 feet.",
                Requirements = "You have a deity.", 
                Duration = "Until the end of your next turn.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                MagicSchoolId = MagicSchools.Instances.Conjuration.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4fe18419-d1c0-4513-acbe-2027b220da2a"), Type = TextBlockType.Text, Text = "Your faith is strong enough to briefly summon a direct representative of your deity, such as the deity�s herald. The herald occupies the space of a Huge creature and has a Speed of 60 feet. The effects of this spell depend on your deity�s alignment." };
            yield return new TextBlock { Id = Guid.Parse("6aa1d38e-ab8c-4543-a723-1771e977681c"), Type = TextBlockType.Enumeration, Text = "Lawful Good - Arrive (enchantment, good, lawful) Aura of Retribution While within 100 feet of the herald, you and your allies gain the champion�s Retributive Strike reaction (Core Rulebook 107); Depart Holy Smite The herald casts 5th-level divine wrath (choosing good) in a 100-foot emanation." };
            yield return new TextBlock { Id = Guid.Parse("22e0ceaa-1200-46c5-84b7-b71fc4676781"), Type = TextBlockType.Enumeration, Text = "Neutral Good - Arrive (enchantment, good) Aura of Redemption While within 100 feet of the herald, you and your allies gain the champion�s Glimpse of Redemption reaction (Core Rulebook 107); Depart Merciful Healing The herald casts the 3-action version of 5th-level heal with a radius of 100 feet. This spell targets only you and your allies." };
            yield return new TextBlock { Id = Guid.Parse("f23be755-f432-4ffa-b49d-dd0ff5374002"), Type = TextBlockType.Enumeration, Text = "Chaotic Good - Arrive (chaotic, enchantment, good) Aura of Liberation While within 100 feet of the herald, you and your allies gain the champion�s Liberating Step reaction (Core Rulebook 107); Depart Radiating Freedom The herald affects you and all your allies within 100 feet with freedom of movement. The duration is reduced to 3 rounds." };
            yield return new TextBlock { Id = Guid.Parse("49063dd4-e393-4ac0-8dd7-8f215628d842"), Type = TextBlockType.Enumeration, Text = "Lawful Neutral - Arrive (abjuration, lawful) Defy Chaos You and each ally within 100 feet of the herald gain resistance 20 against chaotic damage while the herald is present; Depart Order�s Wrath The herald casts 5th-level divine wrath (choosing lawful) in a 100-foot emanation." };
            yield return new TextBlock { Id = Guid.Parse("8d4ae83d-ec2d-43fa-9894-97b41ba58f57"), Type = TextBlockType.Enumeration, Text = "Neutral - Arrive (transmutation) Quickening Ripple You and each ally within 100 feet of the herald are quickened while the herald is present, and can use the additional action to Step, Stride, or Strike; Depart Sapping Beam The herald casts 6th-level enervation (Advanced Player�s Guide 218) in a 100?foot line." };
            yield return new TextBlock { Id = Guid.Parse("ddf7488e-442a-4e4a-9a59-e7f256206b11"), Type = TextBlockType.Enumeration, Text = "Chaotic Neutral - Arrive (abjuration, chaotic) Defy Law You and each ally within 100 feet of the herald gain resistance 20 against lawful damage while the herald is present; Depart Chaos Hammer The herald casts 5th-level divine wrath (choosing chaotic) in a 100-foot emanation." };
            yield return new TextBlock { Id = Guid.Parse("990e95f5-8818-4022-b75a-21d275a31b2f"), Type = TextBlockType.Enumeration, Text = "Lawful Evil - Arrive Aura of Iron While within 100 feet of the herald, you and your allies gain the champion�s Iron Command reaction (Advanced Player�s Guide 117); Depart Unholy Blight The herald casts 5th-level divine wrath (choosing evil) in a 100?foot emanation." };
            yield return new TextBlock { Id = Guid.Parse("b96242e2-5735-4e64-b569-8954d51adaa8"), Type = TextBlockType.Enumeration, Text = "Neutral Evil - Arrive Aura of Selfishness While within 100 feet of the herald, you and your allies gain the champion�s Selfish Shield reaction (Advanced Player�s Guide 117); Depart Infinite Despair The herald casts 5th-level crushing despair in a 100-foot cone." };
            yield return new TextBlock { Id = Guid.Parse("a2a67ed1-9add-4f55-bbfc-d6e75199b46b"), Type = TextBlockType.Enumeration, Text = "Chaotic Evil - Arrive Aura of Vengeance While within 100 feet of the herald, you and your allies gain the champion�s Destructive Vengeance reaction (Advanced Player�s Guide 117); Depart Weapon Hurricane The herald casts 5th-level weapon storm in a 100-foot cone, using d12 for the die size." };
        }

        public override IEnumerable<Guid> GetSpellComponents()
        {
            yield return SpellComponents.Instances.Material.ID;
            yield return SpellComponents.Instances.Somatic.ID;
            yield return SpellComponents.Instances.Verbal.ID;
        }

        public override IEnumerable<Guid> GetMagicTraditions()
        {
            yield return MagicTraditions.Instances.Divine.ID;
        }

        public override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Conjuration.ID;
            yield return Traits.Instances.Incarnate.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49725dd7-2811-4c35-94aa-d75ed053302c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 131
            };
        }
    }
}
