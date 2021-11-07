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
    public class Nocticula : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Nocticula",
                Edicts = "Create art true to yourself, protect marginalized artists, punish those who take advantage of offered trust and shelter.",
                Anathema = "Deny shelter to the desperate, destroy harmless art you dislike, finish a work of art during daylight hours.",
                Title = "The Redeemer Queen",
                AreasOfConcern = "Artists, exiles, midnight.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "For most of her existence, Nocticula was a patron of assassins and succubi, a demon lord feared by other demon lords for her skill at assassinating the competition. Those days are behind Nocticula, for she has risen to the role of the Redeemer Queen, a patron of marginalized artists and protector of those cast out from society. She is now feared among her former peers for her persuasive words that tempt them away from their place in the Abyss and toward redemption. Her faith is strongest in the eastern reaches of New Thassilon, where her most powerful exile, Queen Sorshen, seeks to build a nation that welcomes those whom others have cast out." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PenumbralShroud.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Nondetection.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Creation.ID);
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
            
            return new DivineIntercession
            {
                Id = Guid.Parse(""),
                Description = "The Redeemer Queen smiles upon those who seek to better themselves through introspection, but she is quick to reward betrayal with a stinging rebuke. ",
                MinorBoon = "The night sky inspires you in a specific way. Once, when you roll a failure on a Crafting or Performance check under the night sky, you critically succeed instead. Nocticula typically grants this boon for a consequential piece of artwork or performance.",
                ModerateBoon = "You draw on the power of midnight to guide you on your journeys. You gain darkvision. If you already had darkvision, you can cast darkness once per day as a divine innate spell.",
                MajorBoon = "You become an idealized version of yourself, as if created by a divine artist. You permanently gain a set of 4 ability boosts that follow the same rules as the ability boosts you gain at every 5th level.",
                MinorCurse = "Midnight looms and obscures your fate. You are only able to see up to 60 feet away from you, regardless of the lighting or what senses you have.",
                ModerateCurse = "You are plagued with doubt in your own skills. You are always untrained with Crafting, Performance, and one other skill (determined by the GM, but themed to the event that brought on your curse), regardless of any effect that would improve your proficiency. You can't retrain those skills.",
                MajorCurse = "You are exiled from companionship. You can't communicate with any other creature, nor can you feel other creatures' touch.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 8
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Travel.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 68
            };
        }
    }
}
