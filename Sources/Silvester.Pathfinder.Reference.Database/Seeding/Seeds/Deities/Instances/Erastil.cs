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
    public class Erastil : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Erastil",
                Edicts = "Care for your home and family, fulfill your duties, keep the peace, protect the community.",
                Anathema = "Abandon your home in its time of need, choose yourself over your community, tarnish your reputation, tell lies.",
                Title = "Old Deadeye",
                AreasOfConcern = "Family, farming, hunting, and trade.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Unlike many other good deities, Erastil does not send his followers out into the world to fight and crush evil. Eschewing crusades and other ventures that take his followers away from their homes, Erastil watches over those who devote their lives to family and community. He is primarily an agricultural deity, specifically focusing on those aspects of nature that either can be tamed or are of use to his followers. His domain encompasses the plants and animals that farmers, hunters, and ranchers deal with in their everyday lives. While he is a protective deity, Erastil steps in only when quiet, pastoral lives are threatened. He desires his followers to live their lives in peace, with no risk of being conscripted into armies, devoured by monsters, or destroyed by magic." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TrueStrike.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.WallOfThorns.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TreeStride.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Longbow.ID;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse(""),
                Description = "Erastil favors those who commit themselves to their communities and detests those who disrupt these families.",
                MinorBoon = "Erastil shares in his bounty as long as you work for it. Whenever you roll a critical failure at a check to Subsist in the wild, you get a failure instead.",
                ModerateBoon = "You share Erastil's sharp eye, allowing you to use a longbow in any situation. When you attack with a longbow, you can ignore the longbow's volley trait, and longbows have double the normal range increment for you.",
                MajorBoon = "You become a friend to the land. You can cast speak with plants as a divine innate spell. When you are in a healthy natural environment, the land sustains you without need for food or drink. You can cast the commune with nature ritual without any secondary casters or secondary checks.",
                MinorCurse = "Erastil curses your table and punishes you for relying on others' hard work. Any food you didn't grow, gather, or otherwise harvest yourself tastes like ash and leaves you fatigued.",
                ModerateCurse = "Erastil's beasts take a dislike to you. Animals' attitudes toward you are one category worse (friendly instead of helpful, indifferent instead of friendly, and so on).",
                MajorCurse = "Erastil leaves you unable to have children (or otherwise reproduce or propagate if you do so in a different manner). This curse also affects your livestock, pets, and crops.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 23
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
