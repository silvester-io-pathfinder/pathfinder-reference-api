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
    public class TheLostPrince : Template
    {
        public static readonly Guid ID = Guid.Parse("a04f8bdd-2a4f-441a-b984-2b5cda843612");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "The Lost Prince",
                Edicts = "Aid the depressed, wear somber clothing, maintain neutrality, ruminate on the past.",
                Anathema = "Abandon someone who has no family, take public credit for your good deeds.",
                Title = "The Melancholy Lord",
                AreasOfConcern = "Loneliness, sadness, and forgotten things.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("f28e95d5-ddf2-4bd6-8d74-1d9dc233b161"), Type = TextBlockType.Text, Text = "The Eldest of loneliness, sadness, and forgotten things, the Lost Prince spends most of his time brooding in the throne room of his crumbling tower. Although his precise origin is a hotly debated issue, the Lost Prince is known to hail from a place other than the First World. The melancholy lord doesn't speak of his home, and in fact he doesn't speak much at all, as he's prone to bouts of depression powerful enough to leach color from his surroundings and press his coterie of followers into respectful silence. Appearing as a gaunt, pale human man dressed in black finery, the Lost Prince bears vivid red runes on his brow and on the backs of his hands. He is studiously neutral in the schemes of the other Eldest, which makes his opinions and his favor particularly valuable." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("d2c1d837-1d5f-4fc6-a770-f09c4e6f5064"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("04050d14-33e3-44cc-9866-f4ab86a1fc55"), Spells.Instances.ModifyMemory.ID);
            builder.GainSpecificSpell(Guid.Parse("5f450ddb-f0d4-4b9b-9911-3f0c495acd43"), Spells.Instances.CrushingDespair.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Staff.ID;
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
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Repose.ID;
            yield return Domains.Instances.Sorrow.ID;
            yield return Domains.Instances.Vigil.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d7a3757-d0ea-4270-a7ea-8ebe2b05ad62"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
