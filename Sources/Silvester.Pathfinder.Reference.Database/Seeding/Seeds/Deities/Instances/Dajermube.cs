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
    public class Dajermube : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OldSunGods.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Dajermube",
                Edicts = "Push toward your own goals by striking your own path, try to help others achieve their goals when asked, draw upon all your resources.",
                Anathema = "Intentionally keep others from achieving honorable goals, support others to the exclusion of yourself or vice versa, use shadows to harm innocents.",
                Title = "The Sun Goddess of Eclipses",
                AreasOfConcern = "Shadows, journeys, and self-realization.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Also known as the Holder of Unquenchable Light, Dajermube is the Lioness Goddess of shadows, journeys, and self-realization. She encourages others to venture into the world to achieve their goals. Sometimes these goals are met, and sometimes not, but Dajermube teaches that the act of trying is just as important as completing a goal. She also teaches that darkness and shadow are not to be feared, as shadows are companions to light. Embracing both light and darkness is important, and Dajermube teaches that using all of one's available resources is more important than focusing on just the one that's most comfortable." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Dajermube resembles a Mwangi woman casting a striking shadow. The shadow resembles that of a lioness instead of a human, and parts of her body change to resemble those of a lion while cast in shadow. Her religious symbol depicts the moon crossing in front of the sun during a solar eclipse." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GrimTendrils.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PenumbralDisguise.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShadowSiphon.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Greatpick.ID;
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
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Moon.ID;
            yield return Domains.Instances.Sun.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.Pathfinder172.ID,
                Page = 75
            };
        }
    }
}
