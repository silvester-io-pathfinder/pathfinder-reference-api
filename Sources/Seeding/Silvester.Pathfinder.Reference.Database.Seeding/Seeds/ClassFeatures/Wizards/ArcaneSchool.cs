using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;


using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Wizards
{
    public class ArcaneSchool : Template
    {
        public static readonly Guid ID = Guid.Parse("69f340b1-e633-4633-9d60-fe098836a46c");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Arcane School", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ebeed0ec-e4d1-44a9-a736-0abd82f9c6bb"), Type = TextBlockType.Text, Text = "Many arcane spellcasters delve deeply into a single school of magic in an attempt to master its secrets. If you want to be a specialist wizard, choose a school in which to specialize. You gain additional spells and spell slots for spells of your school." };
            yield return new TextBlock { Id = Guid.Parse("7e7c5ea7-2a50-405d-9068-196ce38e5e6e"), Type = TextBlockType.Text, Text = "If you don�t choose a school, you�re a universalist, a wizard who believes that the path to true knowledge of magic requires a multidisciplinary understanding of all eight schools working together. Though a universalist lacks the focus of a specialist wizard, they have greater fiexibility." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse("d67808ad-144e-4212-902e-ed05d060d734"), or => 
            {
                or.AddAnd(Guid.Parse("423234b9-78a1-4edb-8374-e30f2f60eea4"), and =>
                {
                    and.Name("Abjuration");
                    and.Addendum("As an abjurer, you master the art of protection, strengthening defenses, preventing attacks, and even turning magic against itself. You understand that an ounce of prevention is worth a pound of cure. You add one 1st-level abjuration spell (such as feather fall) to your spellbook.");
                    and.GainSpecificMagicSchool(Guid.Parse("a20bf863-3f32-40b2-885b-aae2ace26e2e"), MagicSchools.Instances.Abjuration.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse("60e72909-18aa-4159-93c3-77f39fd7f157"), MagicSchools.Instances.Abjuration.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse("708288c1-9003-41da-a665-23e70cb0620f"), Spells.Instances.ProtectiveWard.ID);
                });

                or.AddAnd(Guid.Parse("4a3fc66b-787b-4799-87d0-aa855e22f2ae"), and =>
                {
                    and.Name("Conjuration");
                    and.Addendum("As a conjurer, you summon creatures and objects from places beyond, and use magic to transport to distant locales. You understand that the true key to victory is strength in numbers. You add one 1st-level conjuration spell (such as summon animal) to your spellbook. You learn the augment summoning school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse("18f8c54b-9b66-4b5b-bfd5-343ce84144ef"), MagicSchools.Instances.Conjuration.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse("1063a7a3-a9d3-4213-afbd-1b7171e36b61"), MagicSchools.Instances.Conjuration.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse("7b343eb1-815c-4211-b60e-5f37ab60552f"), Spells.Instances.AugmentSummoning.ID);
                });

                or.AddAnd(Guid.Parse("4a4ee2c6-512d-4111-a256-7b2c2cce252a"), and =>
                {
                    and.Name("Divination");
                    and.Addendum("As a diviner, you master remote viewing and prescience, learning information that can transform investigations, research, and battle strategies. You understand that knowledge is power. You add one 1st-level divination spell (such as true strike) to your spellbook. You learn the diviner�s sight school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse("c98408e9-93fe-4d41-a88b-5a566bec80b8"), MagicSchools.Instances.Divination.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse("b6dd3c5c-9302-4a45-9361-3e535affd00d"), MagicSchools.Instances.Divination.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse("d1f78868-03e9-42b9-b4cd-55569914ee3b"), Spells.Instances.DivinersSight.ID);
                });

                or.AddAnd(Guid.Parse("4904a059-780a-461d-a372-589d5d627bfc"), and =>
                {
                    and.Name("Enchantment");
                    and.Addendum("As an enchanter, you use magic to manipulate others� minds. You might use your abilities to subtly influence others or seize control over them. You understand that the mind surpasses matter. You add one 1st-level enchantment spell (such as charm) to your spellbook. You learn the charming words school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse("6caf0f5c-98a7-4f44-ab2c-33e069e72505"), MagicSchools.Instances.Enchantment.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse("0ccde980-5b2a-49b5-826f-cfe6eb0a9ad2"), MagicSchools.Instances.Enchantment.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse("b99cc287-773a-48aa-98e4-0d7b8cb9b344"), Spells.Instances.CharmingWords.ID);
                });

                or.AddAnd(Guid.Parse("fd1c957e-3e70-455b-bb86-2d2cf2b173b5"), and =>
                {
                    and.Name("Evocation");
                    and.Addendum("As an evoker, you revel in the raw power of magic, using it to create and destroy with ease. You can call forth elements, forces, and energy to devastate your foes or to assist you in other ways. You understand that the most direct approach is the most elegant. You add one 1st-level evocation spell (such as shocking grasp) to your spellbook. You learn the force bolt school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse("04754631-cfbb-476f-9b20-155fb58a3b5c"), MagicSchools.Instances.Evocation.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse("436ffb79-ee68-4250-904f-8115d8ba806f"), MagicSchools.Instances.Evocation.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse("86914c63-9117-4d95-954d-2ac5fcb1d963"), Spells.Instances.ForceBolt.ID);
                });

                or.AddAnd(Guid.Parse("c3aecc33-a7d1-47c5-9d32-aee60e79e8df"), and =>
                {
                    and.Name("Illusion");
                    and.Addendum("As an illusionist, you use magic to create images, figments, and phantasms to baffle your enemies. You understand that perception is reality. You add one 1st-level illusion spell (such as illusory object) to your spellbook. You learn the warped terrain school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse("1c75beca-fdde-4892-8d77-c2936ea5973c"), MagicSchools.Instances.Illusion.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse("712bb65f-8be0-4ff3-b228-5e24608acb34"), MagicSchools.Instances.Illusion.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse("e0432ee2-9e69-4125-99fb-e65424c5c01d"), Spells.Instances.WarpedTerrain.ID);
                });

                or.AddAnd(Guid.Parse("719a7c51-ce2f-48c1-9aa6-0a77b2cf2d9e"), and =>
                {
                    and.Name("Necromancy");
                    and.Addendum("As a necromancer, you call upon the powers of life and death. While your school is often vilified for its association with raising the undead, you understand that control over life also means control over healing. You add one 1st-level necromancy spell (such as grim tendrils) to your spellbook. You learn the call of the grave school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse("5d34f57f-bcd3-45dc-9993-de8847e8aba1"), MagicSchools.Instances.Necromancy.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse("56ab8379-14d9-4858-a104-9055bf304436"), MagicSchools.Instances.Necromancy.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse("724efde3-55e8-4315-8acb-f68009cdc79b"), Spells.Instances.CallOfTheGrave.ID);
                });

                or.AddAnd(Guid.Parse("b8dd4bde-3107-4a41-9a08-3196ea024b03"), and =>
                {
                    and.Name("Transmutation");
                    and.Addendum("As a transmuter, you alter the physical properties of things, transforming creatures, objects, the natural world, and even yourself at your whim. You understand that change is inevitable. You add one 1st-level transmutation spell (such as magic weapon) to your spellbook. You learn the physical boost school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse("9ad7176f-756e-47af-8b9c-4852c0bd95eb"), MagicSchools.Instances.Transmutation.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse("dcaa914e-c658-4f0a-ad39-3e1c3652266d"), MagicSchools.Instances.Transmutation.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse("4fc79ca6-fa82-4955-bf8f-d13131edaaf4"), Spells.Instances.PhysicalBoost.ID);
                });

                or.AddAnd(Guid.Parse("2896bb31-6b87-4926-a8f6-941988ce0199"), and =>
                {
                    and.Name("Universalist");
                    and.Addendum("Instead of specializing narrowly in an arcane school, you can become a universalist wizard�by studying all the schools equally, you devote yourself to understanding the full breadth of the arcane arts. For each level of wizard spell slots you have, you can use Drain Bonded item once per day to recall a spell of that level (instead of using it only once per day in total). You gain an extra wizard class feat, and you add one 1st-level spell of your choice to your spellbook.");
                    and.GainAnyClassFeat(Guid.Parse("1038a2c2-f383-44f6-87f6-d80075315673"), Classes.Instances.Wizard.ID, level: 1);
                    and.GainSpecificLevelSpell(Guid.Parse("60e88c66-0365-43ba-9345-52e16a7b6761"), level: 1);
                    //TODO: Modification of DrainBondedItem feat.
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ccf31c9b-2182-4aa0-b46e-5ed6fd027b03"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 205
            };
        }
    }
}
