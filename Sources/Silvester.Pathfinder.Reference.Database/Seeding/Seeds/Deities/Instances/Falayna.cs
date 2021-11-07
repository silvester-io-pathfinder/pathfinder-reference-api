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
    public class Falayna : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Falayna",
                Edicts = "Wear and make beautiful things, train for combat, recover and return lost mementos.",
                Anathema = "Disrupt or destroy romantic unions, enforce a dress code, cower from fights.",
                Title = "Warrior's Ring",
                AreasOfConcern = "Femininity, martial training, and rings.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Femininity, martial training, and rings are the purview of the Warrior's Ring. In the eyes of Falayna, there is as much grace and beauty in the martial arts as exists in any culture's definition of femininity. The strength of womanhood is a hallmark of femininity, and strength in arms reflects this, with the flourish and personality of a fighting style a vibrant means for self-expression. Followers of Falayna learn to fight so they can both express their body and defend themselves if necessary, and strive to feel beautiful doing so, both in form and in dress. Falayna also enjoys rings, and as such she is associated with events in which rings are given or exchanged, such as weddings." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "When the Warrior's Ring appears to mortals, her form is most often that of a muscular woman with the hair and eye colors most commonly associated with feminine beauty in the mortal's mind. She wears a bright silver breastplate on top of flowing, silken robes, her longswordBetrothalsheathed across her back. On her fingers she wears rings of varying colors, styles, and stones; this jewelry seems to constantly shift, as if her fingers wear all the rings found in all the worlds. Followers of Falayna include warriors, soldiers, squires, jewelers, and those engaged to be married." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.GhostlyWeapon.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CloakOfColors.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Longsword.ID;
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
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
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
