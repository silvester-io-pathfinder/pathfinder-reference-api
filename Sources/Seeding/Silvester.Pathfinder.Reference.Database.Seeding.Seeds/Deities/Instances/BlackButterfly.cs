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
    public class BlackButterfly : Template
    {
        public static readonly Guid ID = Guid.Parse("2d5a04d4-af10-40be-889a-95afa295c72a");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Black Butterfly",
                Edicts = "Study the stars, notice moments of silence, perform anonymous acts of kindness.",
                Anathema = "Disrupt another's meditation, interrupt tranquil moments, play noisy or discordant music.",
                Title = "The Silence Between",
                AreasOfConcern = "Distance, silence, and space.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("01fa80ee-ca22-426f-807c-cda6147ad681"), Type = TextBlockType.Text, Text = "The Silence Between flutters among and between the stars, representing distance, silence, and space. Often called Desna's Shadow, the Black Butterfly is sometimes believed to be an aspect of Desna that has broken off and taken on its own life; her interest in distance and space certainly reflects Desna's love of travel. The Black Butterfly finds the silence of the sea of stars useful for introspection and learning about oneself. Those who follow her take opportunities when they can to sit in silent meditation, in zones of silence and darkness when possible. Travel across large distances offers plenty to think about and contemplate, and the Black Butterfly encourages such journeys. She hates all evil, but she truly despises the powerful beings of evil that populate the Dark Tapestry, and her followers are expected to fight these beings and their followers without mercy." };
            yield return new TextBlock { Id = Guid.Parse("615b9f34-384f-406b-a464-0cf50a408725"), Type = TextBlockType.Text, Text = "The Silence Between manifests as the silhouette of a woman with butterfly wings, and white hair and eyes. Her wings contain a shadow—or reflection—of all of the Dark Tapestry and everything within it. Parted lovers, the isolated, the introverted, those who have sworn vows of silence or don't communicate verbally, stargazers, explorers, and the melancholy are all found among the followers of the Black Butterfly." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("8bab6ce2-de12-47ed-bdcd-4ea2dd3383a0"), Spells.Instances.PenumbralShroud.ID);
            builder.GainSpecificSpell(Guid.Parse("7766b8f6-def1-4379-a75f-79d2d740a73d"), Spells.Instances.Blur.ID);
            builder.GainSpecificSpell(Guid.Parse("5cc10530-6351-4b0d-b5dc-3ca71ab29f1e"), Spells.Instances.Blink.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Starknife.ID;
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
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Star.ID;
            yield return Domains.Instances.Void.ID;
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
                Id = Guid.Parse("e1520b23-4f90-449e-97ac-b3e6c48e1dec"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
