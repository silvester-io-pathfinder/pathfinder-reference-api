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
    public class Apollyon : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Horsemen.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Apollyon",
                Edicts = "End all mortal life through disease and poison, cultivate diseased animals.",
                Anathema = "Prevent plagues, bury or burn the dead.",
                Title = "Prince of Locusts",
                AreasOfConcern = "Disease.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Prince of Plagues seized power for himself after the disappearance of the previous Horseman of Pestilence by obsessively eliminating all potential rivals. Apollyon commands his vast army of leukodaemons to spread oblivion like a virus. He wastes no time on trivial acts of violence and lacks the patience to wait for long-term schemes to come to fruition. Instead, his plagues carry oblivion through cities like lightning, decimating entire kingdoms in the span of a few days. His greatest creations have been diseases that corrupt the soul itself, ensuring thatPharasmasends his victims to Abaddon once they've succumbed." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Apollyon appears as a hulking, bruised giant wrapped in black leather straps, with the head of a rotting ram. His cloak is stitched from the skin of angels who attempted to rescue the souls he had claimed—after flaying the angels alive, he preserved their faces in permanent agony upon the cloak. Apollyon delights in witnessing the deaths his diseases cause, not in dispassionate obligation but out of self-righteous glee. He sends his plague carriers out across the Material Plane knowing that even if they are defeated quickly, the sicknesses they carry will spread and take more lives than they could ever hope to alone. The moans and wails from the infected are prayers that fill him with more power to launch his next sickness onto the living." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GoblinPox.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.VomitSwarm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Cloudkill.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Scythe.ID;
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
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Plague.ID;
            yield return Domains.Instances.Swarm.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
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
