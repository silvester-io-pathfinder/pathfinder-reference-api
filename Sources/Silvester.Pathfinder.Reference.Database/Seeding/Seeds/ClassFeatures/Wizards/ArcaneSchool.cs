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
        public static readonly Guid ID = Guid.Parse("");

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
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Many arcane spellcasters delve deeply into a single school of magic in an attempt to master its secrets. If you want to be a specialist wizard, choose a school in which to specialize. You gain additional spells and spell slots for spells of your school." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "If you don’t choose a school, you’re a universalist, a wizard who believes that the path to true knowledge of magic requires a multidisciplinary understanding of all eight schools working together. Though a universalist lacks the focus of a specialist wizard, they have greater fiexibility." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or => 
            {
                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Abjuration");
                    and.Addendum("As an abjurer, you master the art of protection, strengthening defenses, preventing attacks, and even turning magic against itself. You understand that an ounce of prevention is worth a pound of cure. You add one 1st-level abjuration spell (such as feather fall) to your spellbook.");
                    and.GainSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Abjuration.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse(""), MagicSchools.Instances.Abjuration.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ProtectiveWard.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Conjuration");
                    and.Addendum("As a conjurer, you summon creatures and objects from places beyond, and use magic to transport to distant locales. You understand that the true key to victory is strength in numbers. You add one 1st-level conjuration spell (such as summon animal) to your spellbook. You learn the augment summoning school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Conjuration.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse(""), MagicSchools.Instances.Conjuration.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AugmentSummoning.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Divination");
                    and.Addendum("As a diviner, you master remote viewing and prescience, learning information that can transform investigations, research, and battle strategies. You understand that knowledge is power. You add one 1st-level divination spell (such as true strike) to your spellbook. You learn the diviner’s sight school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Divination.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse(""), MagicSchools.Instances.Divination.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DivinersSight.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Enchantment");
                    and.Addendum("As an enchanter, you use magic to manipulate others’ minds. You might use your abilities to subtly influence others or seize control over them. You understand that the mind surpasses matter. You add one 1st-level enchantment spell (such as charm) to your spellbook. You learn the charming words school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Enchantment.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse(""), MagicSchools.Instances.Enchantment.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CharmingWords.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Evocation");
                    and.Addendum("As an evoker, you revel in the raw power of magic, using it to create and destroy with ease. You can call forth elements, forces, and energy to devastate your foes or to assist you in other ways. You understand that the most direct approach is the most elegant. You add one 1st-level evocation spell (such as shocking grasp) to your spellbook. You learn the force bolt school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Evocation.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse(""), MagicSchools.Instances.Evocation.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ForceBolt.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Illusion");
                    and.Addendum("As an illusionist, you use magic to create images, figments, and phantasms to baffle your enemies. You understand that perception is reality. You add one 1st-level illusion spell (such as illusory object) to your spellbook. You learn the warped terrain school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Illusion.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse(""), MagicSchools.Instances.Illusion.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WarpedTerrain.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Necromancy");
                    and.Addendum("As a necromancer, you call upon the powers of life and death. While your school is often vilified for its association with raising the undead, you understand that control over life also means control over healing. You add one 1st-level necromancy spell (such as grim tendrils) to your spellbook. You learn the call of the grave school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Necromancy.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse(""), MagicSchools.Instances.Necromancy.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CallOfTheGrave.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Transmutation");
                    and.Addendum("As a transmuter, you alter the physical properties of things, transforming creatures, objects, the natural world, and even yourself at your whim. You understand that change is inevitable. You add one 1st-level transmutation spell (such as magic weapon) to your spellbook. You learn the physical boost school spell.");
                    and.GainSpecificMagicSchool(Guid.Parse(""), MagicSchools.Instances.Transmutation.ID);
                    and.GainSpecificMagicSchoolSpell(Guid.Parse(""), MagicSchools.Instances.Transmutation.ID, level: 1);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PhysicalBoost.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.Name("Universalist");
                    and.Addendum("Instead of specializing narrowly in an arcane school, you can become a universalist wizard—by studying all the schools equally, you devote yourself to understanding the full breadth of the arcane arts. For each level of wizard spell slots you have, you can use Drain Bonded item once per day to recall a spell of that level (instead of using it only once per day in total). You gain an extra wizard class feat, and you add one 1st-level spell of your choice to your spellbook.");
                    and.GainAnyClassFeat(Guid.Parse(""), Classes.Instances.Wizard.ID, level: 1);
                    and.GainSpecificLevelSpell(Guid.Parse(""), level: 1);
                    //TODO: Modification of DrainBondedItem feat.
                });
            });
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 205
            };
        }
    }
}
