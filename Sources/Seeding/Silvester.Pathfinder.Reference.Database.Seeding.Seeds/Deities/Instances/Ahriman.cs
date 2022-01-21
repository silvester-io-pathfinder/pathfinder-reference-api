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
    public class Ahriman : Template
    {
        public static readonly Guid ID = Guid.Parse("c61df3cf-06e0-41cc-8943-4ee61f40df2d");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Ahriman",
                Edicts = "Foil rulers, the proud, and the powerful; ruin anything created by mortals.",
                Anathema = "Create arts or crafts, serve a mortal, assist in mortal aims except to subvert and corrupt them.",
                Title = "Lord of the Divs",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("25ac006d-67df-492c-82af-b112f99da28b"), Type = TextBlockType.Text, Text = "The dread shadow known as Ahriman counts servants mainly amongdivas well as a scattering of followers throughout the mortal realm." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("71b928a3-6aa9-4f5b-b27c-16ba77fd42b4"), Spells.Instances.IllOmen.ID);
            builder.GainSpecificSpell(Guid.Parse("8bb41d53-a9f3-4f62-a6e1-aa3891e6a26e"), Spells.Instances.Nondetection.ID);
            builder.GainSpecificSpell(Guid.Parse("d7dab621-b986-47c2-9c6c-c271966cdc99"), Spells.Instances.CrushingDespair.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Whip.ID;
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
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Trickery.ID;
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
                Id = Guid.Parse("91cfd0e1-f26d-4264-983f-c50076f7b52e"),
                SourceId = Sources.Instances.Bestiary3.ID,
                Page = 68
            };
        }
    }
}
