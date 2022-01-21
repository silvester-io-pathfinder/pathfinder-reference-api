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
    public class ThePathOfTheHeavens : Template
    {
        public static readonly Guid ID = Guid.Parse("adf82793-f02b-4972-abb9-743d50d4d996");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "The Path of the Heavens",
                Edicts = "Guide travelers; observe the movements of the moon, planets, and stars.",
                Anathema = "Mislead a traveler, permanently blind an enemy.",
                
                AreasOfConcern = "Celestial bodies, navigation, travelers.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("0f52ed1b-f60d-4ec8-b82e-b0f558868b7b"), Type = TextBlockType.Text, Text = "The Path of the Heavens is well known to those who make their way in Golarion. Looking down from above, these deities help travelers and voyagers find their path. Their guidance can be literal, or for others, more spiritual—some worshippers seek to know the progress ofSarenrae(the sun),Tsukiyo(the moon), andDesna(the stars) and through this knowledge gain enlightenment.Nocticula, the last member of the pantheon, for her part uses the cover of the darkness, the gaps in between the others, to shelter travelers and outcasts. Some who worship her as their primary deity in the pantheon seek to use the void between the stars to defend voyagers on the road. Though this is frowned upon by the other members of the Path of the Heavens, it does not seem to disrupt the harmony between the gods." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("b3e3ebf8-cf89-43fc-92d7-1bba7cd00d92"), Spells.Instances.Longstrider.ID);
            builder.GainSpecificSpell(Guid.Parse("978eee87-3b04-4679-b3b2-0c6ed411e6f6"), Spells.Instances.FlamingSphere.ID);
            builder.GainSpecificSpell(Guid.Parse("ab62aa72-412e-4911-b69d-b4736567ee7b"), Spells.Instances.GravityWell.ID);
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
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Moon.ID;
            yield return Domains.Instances.Star.ID;
            yield return Domains.Instances.Sun.ID;
            yield return Domains.Instances.Travel.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("97a2456a-efdf-4c30-a035-518583e56eb7"),
                SourceId = Sources.Instances.BattleOfThePantheons.ID,
                Page = 1
            };
        }
    }
}
