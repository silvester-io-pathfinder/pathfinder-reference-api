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
    public class Imbrex : Template
    {
        public static readonly Guid ID = Guid.Parse("a59e004c-cb14-48da-a1e4-c47b24a954e5");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Imbrex",
                Edicts = "Pursue your own goals, bring things to their proper ending, split things in half or otherwise create pairs.",
                Anathema = "Offend Imbrex.",
                Title = "The Twins",
                AreasOfConcern = "Twins, statues, and endings.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("558a780e-f2c5-4b65-ba41-c9ddc4e9b502"), Type = TextBlockType.Text, Text = "Known as the Twins, Imbrex is the mysterious Eldest of twins, statues, and endings. Appearing as two immense stone statues hundreds of feet tall holding hands and looking outward, Imbrex neither moves nor speaks. The Eldest sometimes communicates with telepathic utterances that rend minds or deliver psychic enlightenment, but they more often express their will through startlingly realistic dreams that sometimes manifest into strange life. An entire city named Anophaeus sprawls at Imbrex's four feet, populated by jaded urbanites, eager aspirants, and prowling dream-creatures made real. An unusually high proportion of those born in Anophaeu are twins, and twins are also common among Imbrex's worshippers. Although Imbrex appears timeless in form, they are intrigued by dramatic endings, particularly apocalypses, and have foreknowledge of disasters to come." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("c41d4595-7882-4195-891d-38b9ece78aad"), Spells.Instances.Mindlink.ID);
            builder.GainSpecificSpell(Guid.Parse("380b8459-8783-43b2-922d-2afc0678a604"), Spells.Instances.MirrorImage.ID);
            builder.GainSpecificSpell(Guid.Parse("d8712b79-a7a8-430a-8241-e5a78f93df31"), Spells.Instances.Stoneskin.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.WarFlail.ID;
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
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Dreams.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Might.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("819a769e-8495-401c-aaf7-4be71fd96f4b"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
