using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class OozeForm : Template
    {
        public static readonly Guid ID = Guid.Parse("2db081e5-dfba-4040-9d7b-52e0602478cf");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Ooze Form",
                Level = 119,
                Duration = "1 minute.",
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe12612a-e2c7-46c8-9070-97d8e21ce817"), Type = TextBlockType.Text, Text = "You invoke all things that seep and ooze, your body dissolving into a thick slurry and then reconstituting itself into a Medium ooze battle form. When you first cast this spell, choose black pudding, gelatinous cube, gray ooze, or ochre jelly. While in this form, you gain the ooze trait. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("b888b965-6fe0-41c8-b0fa-f7172ade3ba4"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse("dc325bf8-3688-4b3d-95a5-38f96c5992a9"), Type = TextBlockType.Enumeration, Text = "AC = 7 + your level. Ignore your armor�s check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("62fff48a-b048-42b2-a364-f9f6401cb9b2"), Type = TextBlockType.Enumeration, Text = "20 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("1d099831-6fce-4851-9d74-8ee71fb1e671"), Type = TextBlockType.Enumeration, Text = "You are immune to critical hits, precision damage, and visual effects." };
            yield return new TextBlock { Id = Guid.Parse("59ce9cc5-a175-4045-ac61-7440b54f8fa8"), Type = TextBlockType.Enumeration, Text = "Resistance 5 to acid, piercing, and slashing damage." };
            yield return new TextBlock { Id = Guid.Parse("a27375ea-3ac1-472c-98c5-3276db4408b4"), Type = TextBlockType.Enumeration, Text = "No vision and motion sense 30 feet. You can sense nearby motion through vibration and air movement as a precise sense." };
            yield return new TextBlock { Id = Guid.Parse("cc89744d-3b5b-4430-8ef5-bbd974d31582"), Type = TextBlockType.Enumeration, Text = "One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. You�re trained with them. Your attack modifier is +14, and you use the listed damage. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("48fbdc68-80f3-4930-b3fd-c36811692e44"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +14, unless your own is higher." };
            yield return new TextBlock { Id = Guid.Parse("ee3b3d48-1ef7-45e1-bcf0-982ddacb0ee0"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the ooze:" };
            yield return new TextBlock { Id = Guid.Parse("3a6332b9-b45f-4c2b-a9c5-a1c09892e9a9"), Type = TextBlockType.Enumeration, Text = "Black Pudding - Speed 15 feet, climb 15 feet; Melee [one-action] pseudopod, Damage 2d6+5 bludgeoning and 1d8 acid." };
            yield return new TextBlock { Id = Guid.Parse("a853bbb7-d7d7-4f3e-9a36-87033d60c29f"), Type = TextBlockType.Enumeration, Text = "Gelatinous Cube - Speed 15 feet; Melee [one-action] cube face, Damage 1d6+5 acid; a creature hit by your cube face Strike must succeed at a Fortitude save against your spell DC or be stunned 1 (or paralyzed for 1 round on a critical failure); this save has the incapacitation trait." };
            yield return new TextBlock { Id = Guid.Parse("f2a7eb5b-695d-4d79-b1e2-63c83400e429"), Type = TextBlockType.Enumeration, Text = "Gray Ooze - Speed 15 feet, climb 15 feet, swim 15 feet; Melee [one-action] pseudopod, Damage 1d6+5 bludgeoning and 1d6 acid, and you can spend an action after a hit to Grab the target." };
            yield return new TextBlock { Id = Guid.Parse("2f393a2d-0fad-4cdb-9a99-10ebe1da5427"), Type = TextBlockType.Enumeration, Text = "Ochre Jelly - Speed 15 feet, climb 10 feet; resistance 5 to electricity; Melee [one-action] pseudopod, Damage 1d8+5 bludgeoning and 1d8 acid, and you can spend an action after a hit to Grab the target." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("04b216f2-ec92-44b6-9620-fa9699ed50fe"),
                Level = "4th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("5f6d54fd-730e-45b8-b368-7a92e4678418"), Type = TextBlockType.Text, Text = "Your battle form is Large, and your attacks have 10-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 30 temporary HP; resistance 7 to acid, piercing, and slashing; attack modifier +16; damage bonus +9; and Athletics +16. Your motion sense has a range of 40 feet." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("a6422153-79d6-4928-821a-0ccf44855a32"),
                Level = "5th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("3321527b-354b-4316-ba92-f75028b571ec"), Type = TextBlockType.Text, Text = "Your battle form is Huge, and your attacks have 15-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 40 temporary HP; resistance 10 to acid, piercing, and slashing; attack modifier +18; damage bonus +6 and double damage dice; and Athletics +20. Your motion sense has a range of 60 feet." }
                }
            };

            yield return new SpellHeightening
            {
                Id = Guid.Parse("2b88cf80-8e68-4851-88a0-48c9f71f1c19"),
                Level = "8th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("59a6026d-db9c-44d5-a57b-d2f5ce5824a2"), Type = TextBlockType.Text, Text = "Your battle form is Gargantuan (20-footby- 20-foot space), and your attacks have 20-foot reach. You must have enough space to expand into or the spell is lost. You instead gain 60 temporary HP; resistance 12 to acid, piercing, and slashing; attack modifier +28; damage bonus +13 and double damage dice; and Athletics +29. Your motion sense has a range of 60 feet" }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("e8046b72-ee9e-4d6b-ad86-5cdf8ea497e2"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("6e4a5d47-82a2-40d0-81d7-e71cd2d83f97"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("263f4a3e-977e-4529-abe5-3430733a2f69"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 119
            };
        }
    }
}
