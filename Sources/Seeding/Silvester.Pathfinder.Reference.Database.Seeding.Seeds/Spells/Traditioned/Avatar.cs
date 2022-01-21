using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Spells.Instances
{
    public class Avatar : Template
    {
        public static readonly Guid ID = Guid.Parse("f708a194-3783-46f4-8cb0-bb512ed08727");

        public override Spell GetSpell()
        {
            return new Spell
            {
                Id = ID,
                Name = "Avatar",
                IsDismissable = true,
                Level = 10,
                Duration = "1 minute.",
                SpellTypeId = SpellTypes.Instances.Spell.ID,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                MagicSchoolId = MagicSchools.Instances.Transmutation.ID,
            };
        }

        public override IEnumerable<TextBlock> GetSpellDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fe2d955b-f3ef-43eb-9ae2-e42430f0a0d0"), Type = Utilities.Text.TextBlockType.Text, Text = "You transform into an avatar of your deity, assuming a Huge battle form.You must have space to expand or the spell is lost. You have hands in this battle form and can take manipulate actions." };
            yield return new TextBlock { Id = Guid.Parse("c11e0547-ec12-4c4b-a40b-bc5177fa1527"), Type = Utilities.Text.TextBlockType.Text, Text = "You gain the following statistics and abilities regardless of which deity's battle form you assume:" };
            yield return new TextBlock { Id = Guid.Parse("2b7a891d-5e49-4e72-86e4-0d0d8fc5f99d"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "AC = 25 + your level. Ignore your armor's check penalty and Speed reduction." };
            yield return new TextBlock { Id = Guid.Parse("95d2bd40-775a-43e7-b421-e46792dd7ebc"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "30 temporary Hit Points." };
            yield return new TextBlock { Id = Guid.Parse("0e46e684-dda7-4d66-9a64-0ae231eda72f"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Darkvision." };
            yield return new TextBlock { Id = Guid.Parse("87ae08fa-7ec5-4c5e-99e3-918c6530e65b"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "One or more attacks specific to your deity's battle form, which are the only attacks you can use. You're trained with them. Your attack modifier is +33, and you use the listed damage. Melee attacks are Strength based (for the purposes of the enfeebled condition, for example) unless they have the finesse trait, and all ranged attacks are Dexterity based. Attacks that deal positive or negative damage don't heal creatures." };
            yield return new TextBlock { Id = Guid.Parse("498b0a9a-0524-49bc-877f-3140eac68339"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Athletics modifier of +35, unless your own is higher." };
            yield return new TextBlock { Id = Guid.Parse("90f30a66-c2fc-441e-9f77-5b0054606681"), Type = Utilities.Text.TextBlockType.Text, Text = "You also gain the specific abilities listed for your deity below:" };
            yield return new TextBlock { Id = Guid.Parse("18cfb804-b63c-42c2-8de5-57f110ed13f3"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Abadar: Speed 50 feet, burrow Speed 30 feet, immune to immobilized; Ranged[one - action] crossbow(range increment 120 feet, reload 1), Damage 6d10 + 3 piercing." };
            yield return new TextBlock { Id = Guid.Parse("a0746a57-ce84-495e-b5c9-b41c0161607c"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Asmodeus: Speed 70 feet, air walk; Melee [one-action] mace (reach 15 feet), Damage 6d10+6 bludgeoning; Ranged [one-action] hellfire (range 120 feet), Damage 6d6+3 fire." };
            yield return new TextBlock { Id = Guid.Parse("e0460453-86b5-447b-b407-f5568d63f4a6"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Calistria: Speed 30 feet, fly Speed 70 feet; Melee [one-action] whip (disarm, finesse, nonlethal, reach 20 feet), Damage 6d4+6 slashing; Ranged [one-action] savored sting (range 60 feet), Damage 6d6+3 poison." };
            yield return new TextBlock { Id = Guid.Parse("7abfa2fb-aac3-48fd-81c6-1e6522b70c15"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Cayden Cailean: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Melee [one-action] rapier (deadly, reach 15 feet), Damage 6d6+6 piercing; Ranged [one-action] ale splash (range 120 feet), Damage 6d6+3 poison." };
            yield return new TextBlock { Id = Guid.Parse("5ffa2d79-74e2-4327-9f08-4f3216cd2417"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Desna: Speed 30 feet, fly Speed 70 feet; Melee [one-action] starknife (agile, deadly, finesse, reach 15 feet, silver, thrown 60 feet), Damage 6d4+6 piercing; Ranged [one-action] moonbeam (range 120 feet, silver), Damage 6d6+3 fire." };
            yield return new TextBlock { Id = Guid.Parse("b78b210e-6ae9-4f99-8a09-9d77e4859e6b"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Erastil: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Ranged[one - action] longbow(deadly d8, range increment 150 feet), Damage 6d8 + 3 piercing." };
            yield return new TextBlock { Id = Guid.Parse("799ce61b-2cdb-4ec9-9036-649d279e9c08"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Gorum: Speed 70 feet, immune to immobilized; Melee [one-action] greatsword (versatile P, reach 15 feet), Damage 6d12+6 slashing." };
            yield return new TextBlock { Id = Guid.Parse("615ce084-3dba-407b-9239-3b7008af1d76"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Gozreh: No land Speed, fly Speed 70 feet, swim Speed70 feet, ignore difficult terrain and greater difficult terrain; Melee [one-action] waves (bull rush, reach 15 feet, thrown 20 feet), Damage 6d8+6 bludgeoning; Ranged [one-action] wind (versatile electricity, range 120 feet), Damage 6d6+3 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("039876d3-70a2-4c24-a3a8-ebd2fd3d2504"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Iomedae: Speed 70 feet, air walk; shield (15 Hardness, can't be damaged); Melee [one-action] longsword (versatile P, reach 15 feet), Damage 6d8+6 slashing." };
            yield return new TextBlock { Id = Guid.Parse("a0ba7a4e-2f91-4988-ab24-505e68e7d734"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Irori: Speed 80 feet, air walk; Melee [one-action] unfettered strike (agile, versatile P or S, finesse, reach 15 feet), Damage 6d8+6 bludgeoning; Ranged [one-action] wind strike (range 60 feet), Damage 6d4+6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("d21692fa-cd36-4823-80c9-f47bff9b8412"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Lamashtu: Speed 30 feet, fly Speed 70 feet; Melee [one-action] falchion (forceful, reach 15 feet), Damage 6d10+6 slashing; Ranged [one-action] waters of Lamashtu (range 120 feet), Damage 6d6 + 3 poison." };
            yield return new TextBlock { Id = Guid.Parse("ef3ff3a5-bf5b-4e95-89b2-4a96fc08f719"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Nethys: Nethys Speed 70 feet, air walk; Ranged [one-action] raw magic (range 120 feet; versatile cold, electricity, or fire), Damage 6d6 force." };
            yield return new TextBlock { Id = Guid.Parse("a443f87b-292a-437b-a60a-c327af9c27e9"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Norgorber: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Melee [one-action] shortsword (agile, finesse, versatile S, reach 15 feet), Damage 6d6+6 piercing; Ranged [one-action] blackfinger toss (range 120 feet), Damage 6d6+3 poison." };
            yield return new TextBlock { Id = Guid.Parse("1f160434-ebe0-4fee-8fc1-ad761d54f891"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Pharasma: Speed 70 feet, air walk; Melee [one-action] dagger (agile, finesse, reach 15 feet, thrown 40 feet), Damage 6d6+6 slashing; Ranged [one-action] spiral blast (range 120 feet, damages only undead), Damage 6d8+3 positive." };
            yield return new TextBlock { Id = Guid.Parse("d23a21c8-3019-441b-9cbb-85aa284751c5"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Rovagug: Speed 50 feet, burrow Speed 30 feet, immune to immobilized; Melee [one-action] jaws (reach 15 feet), Damage 6d12+6 piercing; Melee [one-action] leg (agile, versatile P, reach 15 feet), Damage 6d8+6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("2259126a-45a5-4687-9821-c15ce1b70cab"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Sarenrae: Speed 30 feet, fly Speed 70 feet; Melee [one-action] scimitar (forceful, nonlethal, reach 15 feet), Damage 6d6+6 slashing; Ranged [one-action] everflame (nonlethal, range 120 feet), Damage 6d6+3 fire." };
            yield return new TextBlock { Id = Guid.Parse("d1ec7d7c-0749-465f-8582-565703093c6d"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Shelyn: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Melee [one-action] glaive (deadly d8, nonlethal, reach 20 feet), Damage 6d8+6 slashing; Ranged [one-action] melody of inner beauty, (nonlethal, range 120 feet), Damage 6d6+3 sonic." };
            yield return new TextBlock { Id = Guid.Parse("802fe062-ca5f-431f-ae6e-23726d5feac2"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Torag: Speed 50 feet, burrow Speed 30 feet, immune to immobilized; shield (15 Hardness, can't be damaged); Melee [one-action] warhammer (bull rush, reach 15 feet), Damage 6d8+6 bludgeoning." };
            yield return new TextBlock { Id = Guid.Parse("a3beeee6-be5e-478b-bc1e-09f401eb8aa7"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Urgathoa: Speed 70 feet, air walk; Melee [one-action] scythe (deadly d10, trip, reach 15 feet), Damage 6d10+6 slashing; Ranged [one-action] pallid plague (range 120 feet), Damage 6d6+3 negative." };
            yield return new TextBlock { Id = Guid.Parse("d7fbbf0f-05e2-416d-960a-ced70a90df6f"), Type = Utilities.Text.TextBlockType.Enumeration, Text = "Zon-Kuthon: Speed 70 feet, air walk, ignore difficult terrain and greater difficult terrain; Melee [one-action] spiked chain (disarm, trip, reach 15 feet), Damage 6d8+6 slashing; Ranged [one-action] midnight pain (mental, nonlethal, range 120 feet), Damage 6d6+3 mental." };
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

        public override void GetTraits(ITraitBindingBuilder<SpellTraitBinding, Spell> builder)
        {
            builder.Add(Guid.Parse("fe84c04e-cdb3-4f51-9f85-5f282acf96c5"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("01e38174-172a-46ce-baf8-e35301cee06c"), Traits.Instances.Transmutation.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("374e2911-a434-40b4-b907-a22ab058a1d5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 318
            };
        }
    }
}
