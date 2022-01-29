using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class AberrantForm : Template
    {
        public static readonly Guid ID = Guid.Parse("0430ed10-92ef-4f19-942c-1bb06aa7ced4");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Aberrant Form",
                Level = 5,
                Duration = "1 minute.",
                IsSavingThrowBasic = false,
                IsDismissable = true,
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f722990b-7968-4ba9-a207-e54468ca538a"), Type = TextBlockType.Text, Text = "Harnessing the power of vile entities, you transform yourself into a Large aberration. You must have enough space to expand into or the spell is lost. When you cast this spell, choose chuul, gogiteth, gug, or otyugh. While in this form, you gain the aberration trait. You can Dismiss the spell." };
            yield return new TextBlock { Id = Guid.Parse("19cb1eed-1e5d-4994-aa66-9ee0c2341f6c"), Type = TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which battle form you choose:" };
            yield return new TextBlock { Id = Guid.Parse("b294f33f-cf7b-4926-8a1a-987f257d8332"), Type = TextBlockType.Enumeration, Text = "AC = 18 + your level. Ignore your armor's check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("cea602e7-cad8-4c2a-b50a-300b6f10931d"), Type = TextBlockType.Enumeration, Text = "13 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("aa91c9dc-880f-489a-b151-a8ea200bc44d"), Type = TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("9f0039d4-842c-46dc-abca-13dac389fa65"), Type = TextBlockType.Enumeration, Text = "One or more unarmed melee attacks specific to the battle form you choose, which are the only attacks you can use. you're trained with them. Your attack modifier is +18, and you use the listed damage. These attacks are Strength based (for the purpose of the enfeebled condition, for example). If your unarmed attack modifier is higher, you can use it instead." };
            yield return new TextBlock { Id = Guid.Parse("a6ed8a05-b1a2-48c9-8f24-216db5aabe11"), Type = TextBlockType.Enumeration, Text = "Athletics modifier of +20, unless your own modifier is higher." };
            yield return new TextBlock { Id = Guid.Parse("0f247335-30ca-4eb0-838b-31e2f84fcb3c"), Type = TextBlockType.Text, Text = "You also gain specific abilities based on the type of aberration you choose:" };
            yield return new TextBlock { Id = Guid.Parse("8cf116d4-610e-4d2d-8dbd-ed4236616c93"), Type = TextBlockType.Enumeration, Text = "Chuul - Speed 30 feet, swim 25 feet; Melee [one-action] claw (reach 10 feet), Damage 2d8+8 bludgeoning, and you can spend an action after a hit to Grab the target." };
            yield return new TextBlock { Id = Guid.Parse("76895ec4-80e0-4921-887e-5f74bb5152c3"), Type = TextBlockType.Enumeration, Text = "Gogiteth - Speed 40 feet, climb 30 feet; Melee [one-action] jaws, Damage 2d10+8 piercing, and you can spend an action after a hit to Grab the target; Melee [one-action] leg (agile, reach 10 feet), Damage 2d6+8 piercing." };
            yield return new TextBlock { Id = Guid.Parse("677820eb-d081-4598-bac9-3400e5ab2861"), Type = TextBlockType.Enumeration, Text = "Gug - Speed 40 feet, climb 20 feet; Melee [one-action] jaws (reach 10 feet), Damage 2d12+8 piercing; Melee [one-action]" };
            yield return new TextBlock { Id = Guid.Parse("beee9445-8bf7-449c-935e-c46682742e42"), Type = TextBlockType.Enumeration, Text = "Otyugh - +2 circumstance bonus on saves against disease; Speed 20 feet; Melee [one-action] jaws, Damage 3d6+8 piercing; Melee [one-action] tentacle (agile, reach 10 feet), Damage 2d6+8 bludgeoning." };
        }

        public override IEnumerable<SpellHeightening> GetHeightenings()
        {
            yield return new SpellHeightening
            {
                Id = Guid.Parse("b534cded-29aa-4c87-84ba-9d9be7d1f185"),
                Level = "6th",
                Details = new TextBlock[]
                {
                    new TextBlock {Id = Guid.Parse("1bf15425-329e-4b85-a309-2a0153b88269"), Type = TextBlockType.Text, Text = "Your battle form is Huge, and the reach of your attacks increases by 5 feet. You must have space to expand, or the spell is lost. You instead gain AC = 21 + your level, 26 temporary HP, attack modifier +22, damage bonus +13, and Athletics +23." }
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
            yield return MagicTraditions.Instances.Occult.ID;
        }

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("f3670ae7-03ef-41c3-bb65-bae75a481b85"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("9113b28d-7f90-405e-8696-587cef4c9d5b"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6869de8e-179b-401b-8114-70c10acaab29"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 88
            };
        }
    }
}
