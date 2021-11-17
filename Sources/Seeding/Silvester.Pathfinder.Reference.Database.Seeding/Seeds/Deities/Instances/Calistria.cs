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
    public class Calistria : Template
    {
        public static readonly Guid ID = Guid.Parse("34a35484-85d0-4537-b6e2-ef651117a470");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Calistria",
                Edicts = "Pursue your personal freedom, seek hedonistic thrills, take revenge.",
                Anathema = "Become too consumed by love or a need for revenge, let a slight go unanswered.",
                Title = "The Savored Sting",
                AreasOfConcern = "Lust, revenge, and trickery.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("d55d0527-a53a-419c-a8e7-1bd163758bfb"), Type = TextBlockType.Text, Text = "As symbolized by the three daggers of her religious symbol, Calistria has three aspects: lust, revenge, and trickery. Silver-tongued and charming, she is a master of weaving insults into compliments and laying intricate groundwork for retribution at its finest. She is a goddess of vengeance, but it would be a mistake to assume that means she pursues justice. Calistria is fickle, shifting her loyalties and interests as her whims take her—though she never forgets a slight, and any who think she has forgiven will surely find it is only a matter of time before they are targeted by a long-term plot of revenge to lay them thoroughly low." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("38bf543d-0a41-49e1-96dc-8afdd95bf256"), Spells.Instances.Charm.ID);
            builder.GainSpecificSpell(Guid.Parse("4d250796-0a80-46ea-af67-fb96af92151a"), Spells.Instances.Enthrall.ID);
            builder.GainSpecificSpell(Guid.Parse("9131363e-bab4-4a5d-9def-ad06e87226f4"), Spells.Instances.Mislead.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Whip.ID;
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
                Id = Guid.Parse("2c3226e6-a2c3-4d3b-95cf-63d1b4613145"),
                Description = "Signs of favor or displeasure from the Savored Sting are sometimes subtle and at other times incontrovertible. Calistria typically grants her boon to those on the path toward great vengeance and curses those who slight her followers, particularly if those followers are sex workers, though her fickle heart rarely commits to any absolute guidelines.",
                MinorBoon = "Calistria smiles on the riskiest deceptions. Once, when you roll a failure on a check to Lie, you get a critical success instead. Calistria typically grants this boon for an extremely consequential lie.",
                ModerateBoon = "A foot-long wasp finds and befriends you. It serves you as a familiar as long as you maintain Calistria's grace. The wasp always has the burrower and flier familiar abilities.",
                MajorBoon = "Calistria guides you towards vengeance. You always know the direction and distance towards the nearest creature that has wronged you and thus far gone unpunished.",
                MinorCurse = "Whenever a new person desires vengeance against you, you suffer a painful sting and are afflicted with giant wasp venom at stage 1.",
                ModerateCurse = "People react as though you're insulting them, even in normal conversation. Whenever you attempt to Make an Impression, the outcome is one degree of success worse than the result of your roll. If you converse with someone over a long enough period of time but don't attempt to Make an Impression, you still insult them, and you suffer the effect of a critical failure to Make an Impression.",
                MajorCurse = "You have wronged those unable to obtain revenge for themselves, and Calistria's curse grants their revenge its own life. Whenever another creature imagines vengeance upon you but can't pursue that vengeance because you are too powerful, well connected, or otherwise untouchable, a creature of roughly your level manifests out of their imagination and performs their desired revenge. Once the revenge is complete or the manifestation is destroyed, the summoned creature vanishes from existence.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("823a6840-ee9e-4304-baea-b6eea8a2f2d7"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 17
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Pain.ID;
            yield return Domains.Instances.Passion.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Trickery.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("7988f70b-c759-4d9f-a76e-a2abf4dbca8d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 437
            };
        }
    }
}
