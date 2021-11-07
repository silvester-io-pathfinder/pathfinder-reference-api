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
    public class Otolmens : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Otolmens",
                Edicts = "Relentlessly document and interpret data, correct cosmic errors.",
                Anathema = "Suppress a factual report, ignore facts, misrepresent quantitative data.",
                Title = "The Universal",
                AreasOfConcern = "Machinery, math, and physics.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The primordial inevitable of machinery, math, and physics, Otolmens the Universal is tasked with keeping the galaxies, stars, planets, and other heavenly bodies moving in their proper orbits. From her observatory in the city-plane of Axis, Otolmens and her myriad axiomite assistants track the motions of these objects on the Material Plane. When an anomaly is discovered, Otolmens dispatches inevitables to correct the problem. A mechanical being with multiple heads and limbs, Otolmens is said to spin like an orrery when in a flurry of activity. Her mathematical precision is revered by engineers and scientists, who form the core of her worship. Most pray to her hoping to receive divine inspiration or to stave off inaccurate calculations, but she may call upon her more powerful worshippers to fight threats to the very planet they inhabit." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GravityWell.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ReverseGravity.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Mace.ID;
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
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Perfection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
