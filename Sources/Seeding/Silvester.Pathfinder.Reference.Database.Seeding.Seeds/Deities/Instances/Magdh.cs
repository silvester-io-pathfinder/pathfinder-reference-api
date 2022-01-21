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
    public class Magdh : Template
    {
        public static readonly Guid ID = Guid.Parse("0d2e527e-6e5c-4be8-81c2-e5fea9009922");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Magdh",
                Edicts = "Use divination.",
                Anathema = "Lie, share your divinations without payment (no matter how trivial).",
                Title = "The Three",
                AreasOfConcern = "Foreknowledge, complexity, and triplets.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("363c6574-368b-4794-857f-20e017549801"), Type = TextBlockType.Text, Text = "Magdh is the Eldest of foreknowledge, complexity, and triplets, and she is the greatest seer in the First World. Most often appearing as a woman with three faces set equidistantly around her head, Magdh looks across the skeins of fate into myriad alternate realities and possible futures. Among all the Eldest, she has the deepest knowledge of reality's true design and the ripples a single action or inaction can create throughout all of existence. Her communications are veiled in conditional language and oddly juxtaposed statements to an almost maddening degree, and thus she never communicates the prophetic truths she sees—so plain to her six eyes—in a straightforward way. Because of their shared knowledge of branching timelines, Shyka and Magdh can communicate more easily with each other about such topics, though the other Eldest are cautious around Magdh, lest a careless comment or errant gesture cause her to predict apocalyptic dooms." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("dfae13d0-1ecc-4973-a332-53aa14151639"), Spells.Instances.AnticipatePeril.ID);
            builder.GainSpecificSpell(Guid.Parse("694c921e-565c-4245-9483-1d4a5a7e8a31"), Spells.Instances.ThreefoldAspect.ID);
            builder.GainSpecificSpell(Guid.Parse("d53f107d-8f5e-49b8-8399-00d0f3f124ef"), Spells.Instances.Scrying.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Scythe.ID;
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
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Truth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("87177aff-60fb-4803-b6f3-c23a4fe3a843"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
