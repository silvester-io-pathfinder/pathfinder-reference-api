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
    public class Hastur : Template
    {
        public static readonly Guid ID = Guid.Parse("5d1ffa97-e452-473f-82aa-f9097b7bb435");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OuterGodsAndGreatOldOnes.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Hastur",
                Edicts = "Spread Hastur's Yellow Sign, hide the true nature of your worship, promulgate the play The King in Yellow.",
                Anathema = "None.",
                Title = "The King in Yellow",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("0ac1e7ca-68a0-4d11-b874-ba0635e459d2"), Type = TextBlockType.Text, Text = "Hastur is a Great Old One who, though confined to the city of Carcosa on a planet orbiting a faraway star, is nevertheless in the midst of a transformation into a true Outer God. He works toward this feat through his avatar, the King in Yellow, which can manifest anywhere in the universe the light from Carcosa's sun can be seen. The King in Yellow appears as a humanoid figure draped in yellow clothing, but there is nothing within the clothes save a shapeless, horrifying presence. Hastur himself is also referred to as Him Who Is Not To Be Named, or simply the Unspeakable." };
            yield return new TextBlock { Id = Guid.Parse("95c7f9b1-8510-452a-bc60-f9b49ac2a724"), Type = TextBlockType.Text, Text = "Self-indulgence and nihilism are at the heart of Hastur's worship, and he is popular among debauched artists and nobles who recognize no purpose to life other than gratifying their own increasingly grotesque and outlandish tastes. Cults of Hastur are united in their use of the Yellow Sign, a triskelion design that allows Hastur to observe and possess those who gaze upon it. The presence of the Yellow Sign among a city's graffiti is a foreboding indication that Hastur's attention has been drawn there, and these settlements soon find themselves under attack either by Hastur himself—who seeks to draw cities into Carcosa, fueling his transformation into an Outer God—or byXhamen-Dor, a parasitic deity spawned by Hastur as he walked Carcosa's sewers." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e1794aa9-4fa8-4909-ab3c-f3c59c4a2f97"), Spells.Instances.IllusoryDisguise.ID);
            builder.GainSpecificSpell(Guid.Parse("59423526-10b4-4951-be07-5351d1fea7df"), Spells.Instances.Confusion.ID);
            builder.GainSpecificSpell(Guid.Parse("4a1c1a94-5094-41d8-a504-377650d37ddb"), Spells.Instances.Hallucination.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Rapier.ID;
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
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Void.ID;
            yield return Domains.Instances.Wealth.ID;
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
                Id = Guid.Parse("9a615569-5f1e-47e1-9742-5e4627ab551e"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
