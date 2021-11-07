using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Lysianassa : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElementalLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Lysianassa",
                Edicts = "Respect and aid natural cycles, promote life and growth, change to avoid stagnation, swim.",
                Anathema = "Pollute clean bodies of water, dam a river, disrespect sincere gifts of water or drink.",
                Title = "Empress of the Torrent",
                AreasOfConcern = "Currents, tides, and water.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Lysianassa, Empress of the Torrent, is the elemental lord of currents, tides, and water. Before she was trapped in theGasping Pearl, the benevolent lord of water patrolled her plane as a powerful sailfish made of coral and streaked with mother of pearl. When she realized her capture was imminent, Lysianassa preserved the last of her strength within theBreath of Lysianassa, a vial that allowed her nautilus servant Riam the Unyielding to control thePlane of Water'stides. Since Riam's death, the currents of the Plane of Water have begun to slow, and may eventually come to a halt. Few recall the Empress of the Torrent's name, but cults dedicated to an enigmatic figure called the Queen of the Depths have begun to arise, heralding an event they refer to as the Awakening, and some planar scholars believe these cultists seek to free Lysianassa from her prison." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.HydraulicPush.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AqueousOrb.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ControlWater.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Spear.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Water.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
