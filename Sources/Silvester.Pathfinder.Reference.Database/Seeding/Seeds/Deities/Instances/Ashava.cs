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
    public class Ashava : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Ashava",
                Edicts = "Dance even when there is no music, cast light in places of darkness, lead the lost.",
                Anathema = "Intentionally mislead someone, desecrate graves, abandon a creature in darkness.",
                Title = "The True Spark",
                AreasOfConcern = "Moonlight, dancing, and lonely spirits.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Ashava, the True Spark, embodies moonlight, dancing, and lonely spirits. Dancing is Ashava's true love, and she encourages her followers to dance often. For some, she is little more than a patron of that art, but Ashava is also a guide, both in spirit and in the physical world. For the living, she leads the lonely out of their difficult times, her lights guiding lost wanderers back to safety. For the dead, her haunting moonlit dances lead lost and lonely spirits onward to their eternal judgment. She encourages her followers to steer those who are lost—whether in the wilderness or in their hearts—to where they need to go. Priests of Ashava are the dancing light that guides the way, but will-o'-wisps are anathema to Ashava, and her followers destroy these creatures wherever they are found." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The True Spark appears as a tall woman, flushed with the exertion of prolonged dancing. Her features are difficult to see unless under moonlight, when they instead become crystal clear. She wears a beautiful gown woven from starlight that always sways in motion, and she never appears to be standing still. On her brow she wears a wreath of many-colored moss. Some of Ashava's followers include dancers, artists, the nocturnal, the lonely, the bereaved, lovers, and travelers." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Glitterdust.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.UncontrollableDance.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.BladedScarf.ID;
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
            yield return Skills.Instances.Performance.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Moon.ID;
            yield return Domains.Instances.Repose.ID;
            yield return Domains.Instances.Soul.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
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
