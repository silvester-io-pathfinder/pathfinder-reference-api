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
    public class Ymeri : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElementalLords.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Ymeri",
                Edicts = "Inspire your lessers with zeal and strategy, be passionate and quick of wit, destroy your foes with fire.",
                Anathema = "Extinguish destructive blazes, allow yourself to stagnate or lose motivation.",
                Title = "Queen of the Inferno",
                AreasOfConcern = "Fire, heat, and smoke.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The elemental lord of fire is Ymeri, Queen of the Inferno, lord of fire, heat, and smoke. The sole ruler of thePlane of Fire, Ymeri governs from her Auroric Palace, taking the form of a six-armed reptilian centaur with burning wings. She has systematically destroyed all record of her birth and true origins, claiming to have always existed, and she wages a never-ending war against the other denizens of the Plane of Fire and against theshaitanof the Plane of Earth." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Of all the elemental lords, Ymeri has the largest following. Somemephitsand mostfire elementalsrevere her, alongside someefreetand a few other creatures of the Plane of Fire, though fewsalamandershonor her name, and a covert order of efreeti known as the Secret Fire is dedicated to opposing her rule. On Golarion, the Queen of the Inferno is worshipped primarily by cabals of fire wizards, arsonists, andred dragons." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SummonElemental.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WallOfFire.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Longsword.ID;
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
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Dust.ID;
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
