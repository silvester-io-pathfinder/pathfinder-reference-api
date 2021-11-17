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

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Druids
{
    public class PrimalSpellcasting : Template
    {
        public static readonly Guid ID = Guid.Parse("220aea5d-e872-4599-8f53-806124646e7b");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Name = "Primal Spellcasting", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8ca1cc1c-6f5b-4a71-838b-9e288dff6b48"), Type = TextBlockType.Heading, Text = "Primal Spellcasting" };
            yield return new TextBlock { Id = Guid.Parse("94e7b466-8440-44f2-8af1-88585a1373df"), Type = TextBlockType.Text, Text = "The power of the wild world flows through you. You can cast primal spells using the Cast a Spell activity, and you can supply material, somatic, and verbal components when casting spells (see Casting Spells). Because you're a druid, you can usually hold a primal focus (such as holly and mistletoe) for spells requiring material components instead of needing to use a material component pouch." };
            yield return new TextBlock { Id = Guid.Parse("80e4e4e7-dcf7-43c0-b50c-58f11f1848d4"), Type = TextBlockType.Text, Text = "At 1st level, you can prepare two 1st-level spells and five cantrips each morning from the common spells on the primal spell list in this book, or from other primal spells to which you gain access. Prepared spells remain available to you until you cast them or until you prepare your spells again. The number of spells you can prepare is called your spell slots." };
            yield return new TextBlock { Id = Guid.Parse("088f8628-f2cc-476e-90b0-2559d873c3a3"), Type = TextBlockType.Text, Text = "As you increase in level as a druid, the number of spells you can prepare each day increases, as does the highest level of spell you can cast, as shown in Table 3�11: Druid Spells per Day." };
            yield return new TextBlock { Id = Guid.Parse("0da0c6be-9a98-4efb-bfba-ca5ee0ac3447"), Type = TextBlockType.Text, Text = "Some of your spells require you to attempt a spell attack roll to see how effective they are, or have your enemies roll against your spell DC (typically by attempting a saving throw). Since your key ability is Wisdom, your spell attack rolls and spell DCs use your Wisdom modifier. Details on calculating these statistics appear in Spell Attack Rolls." };
            yield return new TextBlock { Id = Guid.Parse("47d426dd-5ed8-4dbe-948e-07e70d963cf0"), Type = TextBlockType.Heading, Text = "Heightening Spells" };
            yield return new TextBlock { Id = Guid.Parse("510aa349-52ab-4df9-930e-56120a2dc933"), Type = TextBlockType.Text, Text = "When you gain spell slots of 2nd level and higher, you can fill those slots with stronger versions of lower-level spells. This increases the spell's level, heightening it to match the spell slot. Many spells have specific improvements when they are heightened to certain levels." };
            yield return new TextBlock { Id = Guid.Parse("e31f726e-a79a-4385-bc10-51005071907d"), Type = TextBlockType.Heading, Text = "Cantrips" };
            yield return new TextBlock { Id = Guid.Parse("b74f30e3-324e-4b64-a998-434118879d41"), Type = TextBlockType.Text, Text = "Some of your spells are cantrips. A cantrip is a special type of spell that doesn't use spell slots. You can cast a cantrip at will, any number of times per day. A cantrip is automatically heightened to half your level rounded up�this is usually equal to the highest level of druid spell slot you have. For example, as a 1st-level druid, your cantrips are 1st-level spells, and as a 5th-level druid, your cantrips are 3rd-level spells." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpellCasting(Guid.Parse("9d295f6a-8bb7-4ea1-b358-534cd0f981e0"), MagicTraditions.Instances.Primal.ID);

            //Cantrips.
            builder.GainSpecificSpellSlot(Guid.Parse("b47cac6d-0120-4fa0-940b-a32d728ea371"), amount: 5, spellSlotLevel: 0, isSpendingPreventable: true);

            //Spell slots.
            builder.GainSpecificSpellSlot(Guid.Parse("790fbe70-fa7f-4eab-8552-adcc91b70b9e"), Guid.Parse("1416f1b6-6aec-4fcb-b9e0-12ee43cf0ecb"), requiredLevel: 1,  spellSlotLevel: 1, amount: 2, increaseTo: 3, atLevel: 2);
            builder.GainSpecificSpellSlot(Guid.Parse("67b38b6a-c390-4ce3-b63d-349c77755121"), Guid.Parse("2fa833a1-698a-4d9f-80ee-5b978242f255"), requiredLevel: 3,  spellSlotLevel: 2, amount: 2, increaseTo: 3, atLevel: 4);
            builder.GainSpecificSpellSlot(Guid.Parse("6d410a7c-39d3-41ee-8863-25cab320eba9"), Guid.Parse("d33a9fd9-a592-4030-87a3-b15ed842f8b1"), requiredLevel: 5,  spellSlotLevel: 3, amount: 2, increaseTo: 3, atLevel: 6);
            builder.GainSpecificSpellSlot(Guid.Parse("d169ae94-7e50-48ac-8013-4dbb17a8e9aa"), Guid.Parse("9ee946b7-b451-4ca5-8a15-cc6a512545c4"), requiredLevel: 7,  spellSlotLevel: 4, amount: 2, increaseTo: 3, atLevel: 8);
            builder.GainSpecificSpellSlot(Guid.Parse("32b303e0-63c6-4509-8e8f-bc24fab4c53f"), Guid.Parse("ec818dec-ca45-46eb-b37f-21400e210865"), requiredLevel: 9,  spellSlotLevel: 5, amount: 2, increaseTo: 3, atLevel: 10);
            builder.GainSpecificSpellSlot(Guid.Parse("e9dc64d7-d61d-4ba2-9c50-73b76cb4e705"), Guid.Parse("3451e18b-c996-4e30-a4d4-d7057287c25d"), requiredLevel: 11, spellSlotLevel: 6, amount: 2, increaseTo: 3, atLevel: 12);
            builder.GainSpecificSpellSlot(Guid.Parse("d5b34cfb-3c7b-4a94-aa96-c1441c192f3c"), Guid.Parse("0b583ae7-e1fb-4df4-98ab-20272ab6332b"), requiredLevel: 13, spellSlotLevel: 7, amount: 2, increaseTo: 3, atLevel: 14);
            builder.GainSpecificSpellSlot(Guid.Parse("25067630-2b9c-4c85-974e-0baad8b2b147"), Guid.Parse("a095142e-c58d-4fb1-846a-ea5e21a1442e"), requiredLevel: 15, spellSlotLevel: 8, amount: 2, increaseTo: 3, atLevel: 16);
            builder.GainSpecificSpellSlot(Guid.Parse("34adbe36-9935-498f-9dd5-9f893d237f41"), Guid.Parse("eee66281-fb77-4534-afa2-80378ea1354d"), requiredLevel: 17, spellSlotLevel: 9, amount: 2, increaseTo: 3, atLevel: 18);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("de0fed1a-56cc-4c7f-b922-0850ed56bf38"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 130
            };
        }
    }
}
