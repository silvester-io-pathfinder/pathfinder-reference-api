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
    public class Eritrice : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Eritrice",
                Edicts = "Spread truth, debate contentious issues, aid messengers.",
                Anathema = "Sow or perpetuate lies, obstruct discussion, argue in bad faith.",
                Title = "Heart-Speaker",
                AreasOfConcern = "Honest debate, opinions, and truth.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Heart-Speaker Eritrice represents honest debate, opinions, and truth. Facts and information are important to Eritrice, but truths and wisdom gained through discussion are far more valuable to her than those gained through books. She maintains there is nothing wrong with disagreeing so long as the disagreement is respectful, and that it is crucial to be open to discussion, willing to consider new information, and receptive to forming new opinions. Opinions are valuable in that they help understand other views, but Eritrice reminds her followers that opinions are not facts and can be incorrect and even harmful. When lies are spoken or become the rule of the land, those that follow Eritrice work through networks of like-minded individuals to spread the truth using messages sent to all who will listen." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "In her mortal form, the Heart-Speaker appears as a muscular, 8-foot-tall woman with a female lion's head. She wears a rose-colored breastplate over a short kilt. When she speaks, her voice is so entrancing and compelling that those she appears to often don't take note of any of her other features. Those who value truth, from debaters to town criers to lawmakers, are among the followers of Eritrice." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Mindlink.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ComprehendLanguage.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Enthrall.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Dagger.ID;
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
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Truth.ID;
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
