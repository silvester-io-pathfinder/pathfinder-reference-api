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
    public class XhamenDor : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OuterGodsAndGreatOldOnes.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Xhamen-Dor",
                Edicts = "Spread fungal growths, subtly infect others with knowledge of Xhamen-Dor.",
                Anathema = "None.",
                Title = "The Star Seed",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Xhamen-Dor, the living cancer, was born in the sewers beneath Carcosa, the alien city that is the home ofHastur. Somehow, this Great Old One was transported to Golarion within a comet, crashing into the bottom of a lake during the devastation of Earthfall. Physically, it manifests as a twisting and vaguely serpentine-shaped mass of bone, hair, and fungus." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Inmost Blot, as Xhamen-Dor is also known, exists to conquer worlds by infecting the living with itself. Its victims, the seeded, enact its will and seek to spread its influence until the entire world is just an extension of Xhamen-Dor itself. Then, once only the seeded remain, Xhamen-Dor uses the last of the planet's energy to return to Carcosa, which in turn absorbs the world Xhamen-Dor has brought to it, allowing Carcosa to slowly grow." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SummonPlantOrFungus.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WallOfThorns.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WarpMind.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
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
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Dreams.ID;
            yield return Domains.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
