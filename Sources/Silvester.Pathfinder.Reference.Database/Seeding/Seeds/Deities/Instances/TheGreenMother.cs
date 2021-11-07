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
    public class TheGreenMother : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "The Green Mother",
                Edicts = "Frolic in vegetation, manipulate people, use what you kill, prey on the weak.",
                Anathema = "Hold a secret for too long, discriminate against sex workers or use their trade to harm them.",
                Title = "The Feasting Flower",
                AreasOfConcern = "Carnivorous plants, intrigue, and seduction.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Eldest of carnivorous plants, intrigue, and seduction, the Green Mother personifies the raw thrill and desire found throughout nature. Lush plants that entice prey only to kill with barbs or toxins lie within her authority, as do lustful acts and whispered secrets occurring in wild terrain. Her seductive form shifts from that of a beautiful fey such as nymphs to incorporating natural lures like sweet-smelling flowers and graceful verdant tresses. Just as the Green Mother's form constantly changes, her mood shifts from suggestive temptress to indifferent poisoner. No matter her form or attitude, the Green Mother is among the canniest of the Eldest, and she maintains several loyal agents who keep her well informed about goings-on in the First World and beyond. This information fuels her intrigues among the Eldest, and they all believe it wisest to keep on the Green Mother's good side lest their secrets be seductively whispered into the ears of their enemies." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PlantForm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Sickle.ID;
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
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Passion.ID;
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
                Page = 126
            };
        }
    }
}
