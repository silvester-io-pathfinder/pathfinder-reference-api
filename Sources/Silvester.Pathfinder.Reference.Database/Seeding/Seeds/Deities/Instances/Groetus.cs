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
    public class Groetus : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Groetus",
                Edicts = "Preach of the upcoming end times, destroy that which has outlived its usefulness, put the suffering out of their misery.",
                Anathema = "Artificially extend something's existence or lifespan, spread hope.",
                Title = "God of the End Times",
                AreasOfConcern = "Apocalypse, empty places, oblivion, ruins.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Ancient beyond mortal reckoning, Groetus is an entity who cannot be easily understood. He hangs in the sky above the Boneyard, a skull-faced moon constantly observing the passage of the souls below. Events can cause him to draw ominously closer toPharasma'sSpire, or to retreat back to a safer distance, with little obvious rhyme or reason for these actions. He evinces little regard for anything but his singular aim: the dissolution of the universe." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PhantomPain.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.CrushingDespair.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Disjunction.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.WarFlail.ID;
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
                Description = "The God of the End Times almost never directly intervenes in the world, but he sometimes offers flashes of insight or inflicts terrible psychic distress.",
                MinorBoon = "You wield power over disorder. Once, when you are confused, you act normally enough to control your own actions in combat without penalty for the duration, though you still babble incoherently and otherwise behave strangely.",
                ModerateBoon = "Groetus grants you knowledge to further the end times. Each week, he sends you a cryptic, incoherent message about something important to the end times that will happen in the coming week.",
                MajorBoon = "Your touch unravels things that have survived past their appointed time, according to Groetus's reckoning. Such a creature or object takes 10d6 negative damage each round you continue touching it; the damage ignores all Hardness and is capable of destroying nonliving objects, creatures immune to negative effects, and even undead or other creatures with negative healing. This boon might even be able to destroy some artifacts that have survived past their time.",
                MinorCurse = "Whenever you are illuminated by a light source other than natural sunlight, your head appears to be a bare skull. The DC for your recovery checks is 12 + your dying value, rather than 10 + your dying value, and you don't benefit from effects that reduce the DC, such as from the Toughness feat.",
                ModerateCurse = "The horrors at the end of reality become overwhelming and constantly race through your mind. You are permanently stupefied 2.",
                MajorCurse = "You bring about the end to everything around you. Every item you carry or wear gains the broken condition after 10 minutes of exposure to you, and is destroyed after a further hour. This effect can't destroy artifacts or items of similar power.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 6
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Void.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 61
            };
        }
    }
}
