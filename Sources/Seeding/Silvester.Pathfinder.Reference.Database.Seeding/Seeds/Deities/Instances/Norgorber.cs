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
    public class Norgorber : Template
    {
        public static readonly Guid ID = Guid.Parse("918c516d-4fb7-4e33-b773-6a602b7bf209");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Norgorber",
                Edicts = "Keep your true identity secret, sacrifice anyone necessary, take every advantage in a fight, work from the shadows.",
                Anathema = "Allow your true identity to be connected to your dark dealings, share a secret freely, show mercy.",
                Title = "Blackfingers, Father Skinsaw, The Gray Master, Reaper of Reputation",
                AreasOfConcern = "Greed, murder, poison, secrets.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("c765cb2c-9db9-4475-a0f5-c7959f98545e"), Type = TextBlockType.Text, Text = "Norgorber is the most mysterious of the Ascended, the group of mortals who assumed godhood after passing the Test of the Starstone. Unlike Iomedae's and Cayden Cailean's mortal existences, Norgorber's life before his ascension is a mystery; the god himself has shrouded details of his mortal life in secrecy. This is no surprise to those familiar with Norgorber—he is the master of all secrets, a calculating manipulator who cleverly and ruthlessly wields the power of hidden knowledge to achieve his own ends. Only his most trusted worshippers know enough about his goals to assist in the god's plans, and even those worshippers often have their memories modified after their parts in Norgorber's schemes are complete." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("f1aba162-7e96-44ee-a97c-ab4735751c3f"), Spells.Instances.IllusoryDisguise.ID);
            builder.GainSpecificSpell(Guid.Parse("8025d97f-be42-41ec-872a-f50183cf10aa"), Spells.Instances.Invisibility.ID);
            builder.GainSpecificSpell(Guid.Parse("49bdcc62-2d4d-4a20-9ade-b20404578f98"), Spells.Instances.PhantasmalKiller.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Shortsword.ID;
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
                Id = Guid.Parse("4b6e0266-4d6d-4148-bb5a-4b50bed6aac3"),
                Description = "Norgorber's favor and displeasure are subtle, yet powerful.",
                MinorBoon = "Norgorber protects your secrets and lies. Once, when you roll a failure at a Deception check to tell a Lie, you get a critical success instead. Norgorber typically chooses to grant this boon to protect an extremely consequential lie.",
                ModerateBoon = "Your poisons are everlasting. If your Strike with a poisoned weapon critically fails, or succeeds but fails to deal slashing or piercing damage, the poison is not spent. The poison is still spent once successfully applied to a creature.",
                MajorBoon = "You become a living secret. You are immune to divination effects and attempts to magically alter your memory, unless you choose to be affected or those effects come from a deity, artifact, or similarly powerful source. You also can never be tricked or forced by mundane means into uttering a secret you wish to keep.",
                MinorCurse = "Norgorber allows thieves to get the better of you. Whenever you Earn Income, you earn money as if the task were 2 levels lower due to theft, loss, or bad fortune.",
                ModerateCurse = "Poisons are quick to debilitate you. When you roll a failure at a Fortitude save against a poison, you get a critical failure instead.",
                MajorCurse = "Norgorber steals away your memories. Once each day when you awake from rest, roll 1d4. On a 1, you forget the events of the previous day forever. On a 2, you temporarily experience complete retrograde amnesia for that day, unable to recall information from the past, including who you are. On a 3, you temporarily forget a single important subject for that day (Norgorber tends to intentionally chooses a memory to cause distress, such as making you forget your spouse on your anniversary). On a 4, you temporarily remember false memories on a single important subject for that day, blended seamlessly into your true memories.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("e10d0d54-9d1c-4e06-82fa-c2c17c873f37"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 37
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Trickery.ID;
            yield return Domains.Instances.Wealth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("86747876-82a1-4692-a8e0-d476814b286a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
