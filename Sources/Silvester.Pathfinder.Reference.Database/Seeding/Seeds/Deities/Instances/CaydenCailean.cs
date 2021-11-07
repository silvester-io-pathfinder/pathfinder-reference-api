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
    public class CaydenCailean : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Cayden Cailean",
                Edicts = "Drink, free slaves and aid the oppressed, seek glory and adventure.",
                Anathema = "Waste alcohol, be mean or standoffish when drunk, own a slave.",
                Title = "The Accidental God",
                AreasOfConcern = "Ale, bravery, freedom, and wine.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Once a mortal human, Cayden Cailean is now one the few deities known as the Ascended. In his mortal years, Cayden was a sellsword of no small fame, known for his boisterous manner, skill with a blade, and fearless resolve. During a particularly rowdy night of drinking, a series of escalating dares led the wandering mercenary to attempt the Test of the Starstone. He emerged from the Starstone Cathedral 3 days later, laughing, a fully realized god. Divine responsibility did little to change Cayden's attitude from what it was in his mortal life. He continues to crave adventure, drink, and pleasurable company while abhorring bullies, tyrants, and cowards." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FleetStep.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TouchOfIdiocy.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Hallucination.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Rapier.ID;
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
                Description = "Cayden sometimes hands out his blessings and communicates his ire at seemingly random opportunities based on his drunken whims. In particular, Cayden blesses the recently liberated to help secure their freedom. Cayden is also known to grant particularly trivial and harmless curses to those who disrupt revelry. These curses typically cause the disruptor to change in appearance, taking on a comical or farcical look. He is quick to lift these curses by dawn or for those who give in to the enjoyment of the evening and join the festivities.",
                MinorBoon = "Cayden Cailean helps you recover from nights of carousing. While you still get drunk and otherwise experience the effects of alcohol normally, you are never hung over the next morning.",
                ModerateBoon = "You share some of the bravery Cayden espoused during his ascension. When you roll a success on a saving throw against a fear effect, you get a critical success instead. If you have the fighter bravery class feature, when you roll a critical failure on a save against a fear effect, you get a failure instead.",
                MajorBoon = "An embodiment of freedom, you break fetters with ease. At the end of each of your turns, you can end one effect that is currently making you immobilized (including effects that make you immobilized by grabbing or restraining you) as a free action.",
                MinorCurse = "Individuals who raise Cayden's passing displeasure awake as if from a hard night of drinking and find that drink tastes foul.",
                ModerateCurse = "Cayden has afflicted you with cowardice. Whenever you roll a critical success on a saving throw against a fear effect, you get a success instead, and each time you roll a failure on a saving throw against a fear effect, you get a critical failure instead.",
                MajorCurse = "Cayden curses you to suffer in the presence of drinking, making it hard for you to bear entering any tavern. Whenever any creature drinks alcohol within 100 feet of you, you suffer all negative effects from the alcohol (but only the alcohol) instead. This doesn't apply if the creature gains any special effect from drinking alcohol.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 19
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Cities.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Might.ID;
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
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 437
            };
        }
    }
}
