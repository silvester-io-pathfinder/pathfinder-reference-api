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
    public class Shyka : Template
    {
        public static readonly Guid ID = Guid.Parse("14521094-1b59-4f8e-a3e5-90196b5e569f");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Shyka",
                Edicts = "Learn from the past, leave hourglasses in unusual places, give random gifts, create ephemeral things.",
                Anathema = "Willingly tread where time does not pass.",
                Title = "The Many",
                AreasOfConcern = "Entropy, reincarnation, and time.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("fede2fba-d846-44a5-8057-bd87f13bec3b"), Type = TextBlockType.Text, Text = "The Eldest of entropy, reincarnation, and time, Shyka the Many is not a single entity but rather multiple beings who travel forward and backward through time. Each has sequentially held the title of Shyka, picking up the mantle and the knowledge that comes with it upon the passing (or disappearance) of a predecessor. Shyka visits so many overlapping temporal locations that other creatures encounter a random-seeming Shyka each time. This Eldest knows of the multiverse's birth as well as its death, having experienced both. Although Shyka claims to merely watch over the continuum of time, it's an open secret that the Eldest makes slight changes in line with their own goals—or requests that their worshippers do so, with abstruse promptings." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("4c85f4fc-d53a-4659-b85b-93887216d6a6"), Spells.Instances.AnticipatePeril.ID);
            builder.GainSpecificSpell(Guid.Parse("84a327cc-286a-4958-a1d6-027c869d45db"), Spells.Instances.Haste.ID);
            builder.GainSpecificSpell(Guid.Parse("d0b944d8-2134-4b38-853a-20da86ee9b43"), Spells.Instances.TimeBeacon.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.LightMace.ID;
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
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Delirium.ID;
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Time.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("48ab6cae-784d-418c-a583-c4d7b8d3b6d7"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
