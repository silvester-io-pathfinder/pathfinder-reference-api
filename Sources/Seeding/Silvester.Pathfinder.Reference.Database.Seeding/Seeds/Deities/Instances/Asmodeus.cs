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
    public class Asmodeus : Template
    {
        public static readonly Guid ID = Guid.Parse("20773d6e-496f-4127-9d00-640c8b6a407a");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Asmodeus",
                Edicts = "Negotiate contracts to your best advantage, rule tyrannically and torture weaker beings, show subservience to your betters.",
                Anathema = "Break a contract, free a slave, insult Asmodeus by showing mercy to your enemies.",
                Title = "The Prince of Darkness",
                AreasOfConcern = "Contracts, pride, slavery, and tyranny.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("b579fc83-9464-4f07-b2cb-9645a9df90f1"), Type = TextBlockType.Text, Text = "Asmodeus is the First, the Dark Prince, the lord of darkness and law, and the ruler of the plane of Hell. If Asmodeus's own scriptures are to believed—and they are corroborated by certain other accounts, like the angel-pennedBook of the Damned—he is one of the oldest beings of the multiverse. These texts claim that in time before time, in a world not yet created, Asmodeus and his brother Ihys were among the first gods in existence. During these unnamed ages, the two gods quarreled over the fate of the souls of their creations, and Asmodeus slew his brother. Confident that Ihys's act of granting mortals free will was folly, Asmodeus made his own convictions known: that existence is best served by absolute order and discipline. These claims contradict other popular creation myths, and both theologians and immortal agents of the gods doubt Asmodeus's claims to varying degrees, but while there is no evidence to prove them, they are also difficult to refute." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("65b5dd24-313c-4c32-ac6c-d821fd3f4b04"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("5c6c9b15-7f37-41a1-9822-4ce2b778fb9a"), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse("c06ba226-d2c0-4927-8550-a455870f4d9a"), Spells.Instances.Mislead.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Mace.ID;
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
                Id = Guid.Parse("7e9e5adc-0ee8-4252-8b09-5633d9b2517c"),
                Description = "Asmodeus tends to offer his gifts to entice those on the precipice of yielding to his vile temptations. His curses come most often in response to those who break contracts in his name, or commit other personal insults.",
                MinorBoon = "Pleased by your talent for manipulation, Asmodeus amplifies your skills. Once, when you fail at the Diplomacy check to make a significant or consequential Request, you can cast suggestion on the target of your Request, suggesting the same course of action. This is a divine innate spell.",
                ModerateBoon = "Your eyes glow red like embers and your skin takes on a crimson tone. You gain darkvision and fire resistance 5.",
                MajorBoon = "Asmodeus helps enforce your bargains and contracts. When a creature enters a bargain or contract with you, uncoerced and of its own free will, it can't voluntarily violate its side of the bargain as long as you uphold your side. You can always choose to violate the bargain yourself, but if you do, the creature is no longer bound to fulfill its part.",
                MinorCurse = "Asmodeus's flames burn you with great malice. You gain weakness 5 to fire.",
                ModerateCurse = "Asmodeus forces your compliance. You can't voluntarily back out of an agreement or contract or go back on your word, though you need follow only the letter of the agreement, not the spirit.",
                MajorCurse = "Asmodeus has taken note of the chaos you have wrought. You receive an ancient wound that feels older than time itself. You become permanently drained 4, and nothing short of another intercession can remove the condition. Your wound aches fiercely whenever you perform a particularly chaotic act, causing you to become sickened 1.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("594c72e5-9251-4721-aa09-e41f32234eb2"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 15
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("cba53990-3960-421c-889b-80a19c30aab1"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 437
            };
        }
    }
}
