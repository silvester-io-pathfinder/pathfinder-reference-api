using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Instances;
using Silvester.Pathfinder.Reference.Database.Models.EffectIncrements.Triggers.Instances;


using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Magusi
{
    public class ArcaneSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("45d9d706-1569-4bad-8b18-acc245ac51de");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Arcane Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("1d98f738-b8a9-41b0-a7e8-9791ea6afc3e"), Type = TextBlockType.Text, Text = "You study spells so you can combine them with your attacks or solve problems that strength of arms alone can't handle. You can cast arcane spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells. Because you're a magus, you can draw replacement sigils with the tip of your weapon or your free hand for spells requiring material components, replacing them with somatic components instead of needing a material component pouch." };
            yield return new TextBlock { Id = Guid.Parse("9771fef1-cc16-49cb-b76f-dc3e4c9d6b2b"), Type = TextBlockType.Text, Text = "At 1st level, you can prepare one 1st-level spell and five cantrips each morning from the spells in your spellbook (see below). Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse("adc9eee3-4a69-49e9-a6a6-8669741cdd04"), Type = TextBlockType.Text, Text = "As you increase in level as a magus, your number of spell slots and the highest level of spells you can cast from spell slots increase, shown in Table 2�2: Magus Spells per Day. Because you split your focus between physical training and magical scholarship, you have no more than two spell slots of your highest level and, if you can cast 2nd-level spells or higher, two spell slots of 1 level lower than your highest spell level." };
            yield return new TextBlock { Id = Guid.Parse("96ba93af-b5d8-4663-82a7-cca0ca611757"), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Your spell attack rolls and spell DCs use your Intelligence modifier. Details on calculating these statistics appear in Spell Attack Roll." };

            yield return new TextBlock { Id = Guid.Parse("2dae11a8-1a4b-4651-9701-f6ecff47d323"), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse("e6fbb8b2-94ac-4a3f-9b7c-254eed1e8258"), Type = TextBlockType.Text, Text = "When you get spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they're heightened to certain levels." };

            yield return new TextBlock { Id = Guid.Parse("4190db46-7e3c-4787-8e7f-729ce22ec5e4"), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse("dcd71b13-1c80-47a4-a497-3f9dc8dbb38a"), Type = TextBlockType.Text, Text = "A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is always automatically heightened to half your level rounded up�this is usually equal to the highest level of spell you can cast as a magus. For example, as a 1st-level magus, your cantrips are 1st-level spells, and as a 5th-level magus, your cantrips are 3rd-level spells." };

            yield return new TextBlock { Id = Guid.Parse("26269af8-ce90-4e50-80a1-b086bb4173ee"), Type = TextBlockType.Heading, Text = "Spellbook" };
            yield return new TextBlock { Id = Guid.Parse("a2b5dfed-4593-44d4-b3a3-beb9fad244ef"), Type = TextBlockType.Text, Text = "Every arcane spell has a written version, usually recorded in a spellbook. You start with a spellbook worth 10 sp or less, which you receive for free and must study to prepare your spells each day. The spellbook contains your choice of eight arcane cantrips and four 1st-level arcane spells. You choose these from the common spells on the arcane spell list or from other arcane spells you gain access to. Your spellbook's form and name are up to you. It might be anything from a sturdy book with a secure latch entitled Theses on the Stratagems of Supernatural Warfare to a tattered collection of training pamphlets with your name scrawled on the cover." };
            yield return new TextBlock { Id = Guid.Parse("00662497-c7a7-41b5-9c0e-44078b84e553"), Type = TextBlockType.Text, Text = "Each time you gain a level, you add two more arcane spells to your spellbook, of any level of spell you can cast. You can also use the Arcana skill to add other spells that you find in your adventures (see Learn a Spell). Though you lose some lower spell slots as you increase in level, you keep the spells in your spellbook and can prepare them in your higher-level slots as normal." };
            yield return new TextBlock { Id = Guid.Parse("d03ae5c4-c97a-43ec-b180-075b26da64b1"), Type = TextBlockType.Text, Text = "If you have a spellbook from multiple sources (such as being a magus with the Wizard Dedication feat), you can use the same spellbook for all your spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("d4723054-7933-44cf-9498-44ddea1f4697"), MagicTraditions.Instances.Arcane.ID);
            builder.GainSpellBook(Guid.Parse("4e2a72ca-ed75-4cd1-b9f7-360d7742b010"), cantripAmount: 8, spellAmount: 4, addSpellsPerLevel: 2);

            //Cantrips
            builder.GainSpecificSpellSlot(Guid.Parse("5505fd58-54e3-4578-ad0b-7fa97c33053b"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Spell slots
            builder.GainSpecificSpellSlot(Guid.Parse("c384fce6-526e-4ee2-9df4-735e48e1bc40"), Comparator.EqualTo, requiredLevel: 1, spellSlotLevel: 1, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("f57ee42f-8688-43eb-9989-f326f9836bc2"), Comparator.EqualTo, requiredLevel: 2, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("12f6103c-f8ea-43e4-82e3-cd762dfaf9c0"), Comparator.EqualTo, requiredLevel: 3, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("c87d250f-c7b0-4102-933e-cdcda9a3385b"), Comparator.EqualTo, requiredLevel: 3, spellSlotLevel: 2, amount: 1);
            builder.GainSpecificSpellSlot(Guid.Parse("804d36d5-fbac-40e1-afb8-bd09c43131c7"), Comparator.EqualTo, requiredLevel: 4, spellSlotLevel: 1, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("edb59da3-de2c-44b0-b060-32e251370aae"), Comparator.EqualTo, requiredLevel: 4, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("63befd24-2b57-43bf-9bfd-2e15899b61c9"), Comparator.EqualTo, requiredLevel: 5, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("e7a0bb09-1ca2-42da-a325-29702fc4ecf4"), Comparator.EqualTo, requiredLevel: 5, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("88d8aa61-01e4-43a6-8b3b-6e0f84a2370d"), Comparator.EqualTo, requiredLevel: 6, spellSlotLevel: 2, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("0abf252d-45c7-4f72-ac6c-ab983ac1ab12"), Comparator.EqualTo, requiredLevel: 6, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("96f0eb18-3826-43cb-a4c7-c58c8cd98181"), Comparator.EqualTo, requiredLevel: 7, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("cef95c75-498d-417f-b217-d7bc61a8cf3c"), Comparator.EqualTo, requiredLevel: 7, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("dfc6f638-2b54-46ae-91c2-1c45f84bfa22"), Comparator.EqualTo, requiredLevel: 8, spellSlotLevel: 3, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("9da3491f-8139-4511-bbd9-c2f430d9972d"), Comparator.EqualTo, requiredLevel: 8, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("4a924fd3-5650-47c3-b178-eba8afee4c91"), Comparator.EqualTo, requiredLevel: 9, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("bb33bbbf-38c6-4e69-833b-a748501fa434"), Comparator.EqualTo, requiredLevel: 9, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("3b7e7bd4-b62c-4e03-93a4-6076e3d6078b"), Comparator.EqualTo, requiredLevel: 10, spellSlotLevel: 4, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("9ae7ba15-f6bb-423a-bfe5-65db23dcdcc7"), Comparator.EqualTo, requiredLevel: 10, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("7f46c462-55f9-4007-a855-44b14792d09f"), Comparator.EqualTo, requiredLevel: 11, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("80cc5540-26d9-4d8b-94f9-ef271325c2f1"), Comparator.EqualTo, requiredLevel: 11, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("187b530f-1f01-4c2e-a0bd-a353b6374553"), Comparator.EqualTo, requiredLevel: 12, spellSlotLevel: 5, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("e929aa96-f437-448d-983f-aa98ec270368"), Comparator.EqualTo, requiredLevel: 12, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("66a2fa29-9413-4c8d-9a7c-cf17e6e28b6c"), Comparator.EqualTo, requiredLevel: 13, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("0064ae06-f5d8-48f6-be9e-ecf44a26649f"), Comparator.EqualTo, requiredLevel: 13, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("1555b800-a8a1-41d2-9e61-40f00ed71c10"), Comparator.EqualTo, requiredLevel: 14, spellSlotLevel: 6, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("8e525858-18c0-4bd2-8fa0-cf39be4f7e44"), Comparator.EqualTo, requiredLevel: 14, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("fcc2f76b-b21e-4516-9689-4ac441621a5e"), Comparator.EqualTo, requiredLevel: 15, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("c7530ece-f534-4cc6-93a4-fde079c416e2"), Comparator.EqualTo, requiredLevel: 15, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("4df4c6ec-14ce-40c0-8cbf-482dec3a72f0"), Comparator.EqualTo, requiredLevel: 16, spellSlotLevel: 7, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("127542d8-f7e2-4087-b49d-e61f1ab4185e"), Comparator.EqualTo, requiredLevel: 16, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("d140a891-60bc-43e9-9e4e-6e07249b7835"), Comparator.GreaterThanOrEqualTo, requiredLevel: 17, spellSlotLevel: 8, amount: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("96080d48-9f02-44db-9ffb-01af5af56a1c"), Comparator.GreaterThanOrEqualTo, requiredLevel: 17, spellSlotLevel: 9, amount: 2);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f504148-5244-4680-bce3-e83daf686959"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 36
            };
        }
    }
}
