using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Bloodlines.Instances
{
    public class Genie : Template
    {
        public static readonly Guid ID = Guid.Parse("");
        
        protected override Bloodline GetBloodline()
        {
            return new Bloodline
            {
                Id = ID, 
                Name = "Genie",
                BloodMagic = "Your spellcasting warps reality and distracts your foes. Either you gain a +1 status bonus to Deception checks for 1 round, or a target takes a –1 status penalty to Perception for 1 round.",
                RarityId = Rarities.Instances.Common.ID,
                InitialBloodlineSpellId = Spells.Instances.GeniesVeil.ID,
                AdvancedBloodlineSpellId = Spells.Instances.HeartsDesire.ID,
                GreaterBloodlineSpellId = Spells.Instances.WishTwistedForm.ID,
                SpellListTraditionId = MagicTraditions.Instances.Arcane.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Through lineage, magic, or wishes made real, the blood of a noble genie flows through your veins." };
        }

        protected override IEnumerable<TextBlock> GetTypeChoiceDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "At 1st level, choose the type of genie that influenced your bloodline: janni, djinni, efreeti, marid, or shaitan. You can't change your genie type later. This determines what granted spells you receive at 2nd, 5th, and 8th level." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Janni 2nd: create food; 5th: banishment; 8th: scintillating pattern" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Djinni 2nd: invisibility; 5th: illusory scene; 8th: punishing winds" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Efreeti 2nd: enlarge; 5th: elemental form (fire only); 8th: maze" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Marid 2nd: water walk; 5th: control water; 8th: horrid wilting" };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Enumeration, Text = "Shaitan 2nd: glitterdust; 5th: wall of stone; 8th: earthquake" };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Arcana.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new GainSpecificSkillProficiencyEffect { Id = Guid.Parse(""), SkillId = Skills.Instances.Deception.ID, ProficiencyId = Proficiencies.Instances.Trained.ID };
            yield return new ChoiceEffect
            {
                Id = Guid.Parse(""),
                Entries = new Effect[]
                {
                    new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.GeniesVeil.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DetectMagic.ID},
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.IllusoryDisguise.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.CreateFood.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Enthrall.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Creation.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Banishment.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.TrueSeeing.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.EnergyAegis.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ScintillatingPattern.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ResplendentMansion.ID }
                        }
                    },
                       new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.GeniesVeil.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DetectMagic.ID},
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.IllusoryDisguise.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Invisibility.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Enthrall.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Creation.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.IllusoryScene.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.TrueSeeing.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.EnergyAegis.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.PunishingWinds.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ResplendentMansion.ID }
                        }
                    },
                          new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.GeniesVeil.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DetectMagic.ID},
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.IllusoryDisguise.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Enlarge.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Enthrall.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Creation.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ElementalForm.ID, Restrictions = "Only the Fire elemental form can be used." },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.TrueSeeing.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.EnergyAegis.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Maze.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ResplendentMansion.ID }
                        }
                    },
                             new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.GeniesVeil.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DetectMagic.ID},
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.IllusoryDisguise.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.WaterWalk.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Enthrall.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Creation.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ControlWater.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.TrueSeeing.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.EnergyAegis.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.HorridWilting.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ResplendentMansion.ID }
                        }
                    },
                                new CombinedEffect
                    {
                        Id = Guid.Parse(""),
                        Entries = new Effect[]
                        {
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.GeniesVeil.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.DetectMagic.ID},
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.IllusoryDisguise.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Glitterdust.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Enthrall.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Creation.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.WallOfStone.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.TrueSeeing.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.EnergyAegis.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.Earthquake.ID },
                            new GainSpecificSpellEffect { Id = Guid.Parse(""), SpellId = Spells.Instances.ResplendentMansion.ID }
                        }
                    }
                }
            };
        }

        protected override IEnumerable<Guid> GetSkills()
        {
            yield return Skills.Instances.Arcana.ID;
            yield return Skills.Instances.Deception.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 138
            };
        }
    }
}
