using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

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

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new ChoiceEffect
            {
                Id = Guid.Parse(""),
                Entries = new []
                {
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Abjuration",
                            Addendum = "As an abjurer, you master the art of protection, strengthening defenses, preventing attacks, and even turning magic against itself. You understand that an ounce of prevention is worth a pound of cure. You add one 1st-level abjuration spell (such as feather fall) to your spellbook.",
                            Entries = new Effect[]
                            {
                                new GainSpecificMagicSchoolEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Abjuration.ID },
                                new GainSpecificMagicSchoolSpellEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Abjuration.ID, Level = 1 },
                                new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ProtectiveWard.ID }
                            }
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Conjuration",
                            Addendum = "As a conjurer, you summon creatures and objects from places beyond, and use magic to transport to distant locales. You understand that the true key to victory is strength in numbers. You add one 1st-level conjuration spell (such as summon animal) to your spellbook. You learn the augment summoning school spell.",
                            Entries = new Effect[]
                            {
                                new GainSpecificMagicSchoolEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Conjuration.ID },
                                new GainSpecificMagicSchoolSpellEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Conjuration.ID, Level = 1 },
                                new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.AugmentSummoning.ID }
                            }
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Divination",
                            Addendum = "As a diviner, you master remote viewing and prescience, learning information that can transform investigations, research, and battle strategies. You understand that knowledge is power. You add one 1st-level divination spell (such as true strike) to your spellbook. You learn the diviner’s sight school spell.",
                            Entries = new Effect[]
                            {
                                new GainSpecificMagicSchoolEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Divination.ID },
                                new GainSpecificMagicSchoolSpellEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Divination.ID, Level = 1 },
                                new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DivinersSight.ID }
                            }
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Enchantment",
                            Addendum = "As an enchanter, you use magic to manipulate others’ minds. You might use your abilities to subtly influence others or seize control over them. You understand that the mind surpasses matter. You add one 1st-level enchantment spell (such as charm) to your spellbook. You learn the charming words school spell.",
                            Entries = new Effect[]
                            {
                                new GainSpecificMagicSchoolEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Enchantment.ID },
                                new GainSpecificMagicSchoolSpellEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Enchantment.ID, Level = 1 },
                                new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.CharmingWords.ID }
                            }
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Evocation",
                            Addendum = "As an evoker, you revel in the raw power of magic, using it to create and destroy with ease. You can call forth elements, forces, and energy to devastate your foes or to assist you in other ways. You understand that the most direct approach is the most elegant. You add one 1st-level evocation spell (such as shocking grasp) to your spellbook. You learn the force bolt school spell.",
                            Entries = new Effect[]
                            {
                                new GainSpecificMagicSchoolEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Evocation.ID },
                                new GainSpecificMagicSchoolSpellEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Evocation.ID, Level = 1 },
                                new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ForceBolt.ID }
                            }
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Illusion",
                            Addendum = "As an illusionist, you use magic to create images, figments, and phantasms to baffle your enemies. You understand that perception is reality. You add one 1st-level illusion spell (such as illusory object) to your spellbook. You learn the warped terrain school spell.",
                            Entries = new Effect[]
                            {
                                new GainSpecificMagicSchoolEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Illusion.ID },
                                new GainSpecificMagicSchoolSpellEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Illusion.ID, Level = 1 },
                                new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.WarpedTerrain.ID }
                            }
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Necromancy",
                            Addendum = "As a necromancer, you call upon the powers of life and death. While your school is often vilified for its association with raising the undead, you understand that control over life also means control over healing. You add one 1st-level necromancy spell (such as grim tendrils) to your spellbook. You learn the call of the grave school spell.",
                            Entries = new Effect[]
                            {
                                new GainSpecificMagicSchoolEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Necromancy.ID },
                                new GainSpecificMagicSchoolSpellEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Necromancy.ID, Level = 1 },
                                new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.CallOfTheGrave.ID }
                            }
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Transmutation",
                            Addendum = "As a transmuter, you alter the physical properties of things, transforming creatures, objects, the natural world, and even yourself at your whim. You understand that change is inevitable. You add one 1st-level transmutation spell (such as magic weapon) to your spellbook. You learn the physical boost school spell.",
                            Entries = new Effect[]
                            {
                                new GainSpecificMagicSchoolEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Transmutation.ID },
                                new GainSpecificMagicSchoolSpellEffect { Id = Guid.Parse(""), MagicSchoolId = MagicSchools.Instances.Transmutation.ID, Level = 1 },
                                new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.PhysicalBoost.ID }
                            }
                        }
                    },
                    new ChoiceEffectBinding
                    {
                        Id = Guid.Parse(""),
                        Effect = new CombinedEffect
                        {
                            Id = Guid.Parse(""),
                            Name = "Universalist",
                            Addendum = "Instead of specializing narrowly in an arcane school, you can become a universalist wizard—by studying all the schools equally, you devote yourself to understanding the full breadth of the arcane arts. For each level of wizard spell slots you have, you can use Drain Bonded item once per day to recall a spell of that level (instead of using it only once per day in total). You gain an extra wizard class feat, and you add one 1st-level spell of your choice to your spellbook.",
                            Entries = new Effect[]
                            {
                                new GainAnyClassFeatEffect { Id = Guid.Parse(""), ClassId = Classes.Instances.Wizard.ID },
                                new GainSpecificLevelSpellEffect { Id = Guid.Parse(""), Level = 1 },
                                //TODO: Modification of DrainBondedItem feat.
                            }
                        }
                    }
                }
            };
            yield return new GainSpecificFeatEffect { Id = Guid.Parse("") };
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
