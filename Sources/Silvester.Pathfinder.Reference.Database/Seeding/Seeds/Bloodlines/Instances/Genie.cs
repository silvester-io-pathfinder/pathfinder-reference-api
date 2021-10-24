using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

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

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddOr(Guid.Parse(""), or =>
            {
                or.AddAnd(Guid.Parse(""), and => 
                {
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CreateFood.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Banishment.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ScintillatingPattern.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResplendentMansion.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Invisibility.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.IllusoryScene.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PunishingWinds.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResplendentMansion.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enlarge.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ElementalForm.ID, "Only the Fire elemental form can be used.");
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Maze.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResplendentMansion.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WaterWalk.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ControlWater.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.HorridWilting.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResplendentMansion.ID);
                });

                or.AddAnd(Guid.Parse(""), and =>
                {
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GeniesVeil.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.DetectMagic.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.IllusoryDisguise.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Glitterdust.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Creation.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WallOfStone.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueSeeing.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.EnergyAegis.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Earthquake.ID);
                    and.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ResplendentMansion.ID);
                });
            });
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
