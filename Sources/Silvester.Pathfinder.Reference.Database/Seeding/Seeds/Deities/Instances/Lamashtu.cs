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
    public class Lamashtu : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Lamashtu",
                Edicts = "Bring power to outcasts and the downtrodden, indoctrinate children in Lamashtu's teachings, make the beautiful monstrous, reveal the corruption and flaws in all things.",
                Anathema = "Attempt to treat a mental illness or deformity, provide succor to Lamashtu's enemies.",
                Title = "Mother of Monsters",
                AreasOfConcern = "Aberrance, monsters, and nightmares.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "For those who revel in the corruption of the pure or who find themselves spurned and neglected by a world that despises their differences, Lamashtu offers respite among her grotesque brood. The Mother of Monsters readily accepts mortals into her fold and has made it her goal to twist mortal life toward her abhorrent ideals. Her intervention is widely known to inflict corruptions and terrible nightmares. Ostracized individuals who share her ideals will find this intervention a boon, while others treat similar events as horrible curses." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MagicFang.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.AnimalForm.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Nightmare.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Falchion.ID;
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
                Description = "Lamashtu rewards kinship with monsters and brutal dominance in combat. Those who offend her serve the brood as prey or unwilling sacrifices.",
                MinorBoon = "Lamashtu's touch mutates a part of your body. You gain either an unarmed Strike that deals 1d6 damage or one that deals 1d4 damage and has the finesse and agile traits. Whether the attack deals bludgeoning, slashing, or piercing damage depends on the mutation. If the unarmed Strike replaces a limb, you can still use the mutated limb for its original functions. Lamashtu chooses the form and function of your mutation.",
                ModerateBoon = "You spread Lamashtu's nightmares everywhere you go. You can cast confusion once per day as an divine innate spell.",
                MajorBoon = "Lamashtu uses your body to birth a new monster, regardless of your gender. Once per day, you can spend 1 minute to birth a monster determined by the GM, which rips its way from your belly. The monster's level is up to your level and it does as it pleases, following Lamashtu's will, though it doesn't attack you unless you have lost her favor. You are drained 3 from the ordeal.",
                MinorCurse = "Horrid visions torment your mind, overlaying reality at inopportune times. You treat everything around you as if it was concealed.",
                ModerateCurse = "Lamashtu marks you as prey. Any creature with imprecise or better scent can smell you from 100 × the usual range of their scent and can't shake the feeling that you smell like prey, so they might attack you even if they would normally avoid attacking creatures of your ancestry. This smell doesn't magically compel their action, and the scent of prey doesn't overcome a deeper bond such as that with an animal companion.",
                MajorCurse = "Your dreams are an unending stream of nightmares. You need 16 hours of rest to try to get enough sleep to recover resources in daily preparation that normally require an 8-hour rest, and even then, you must succeed at a DC 15 flat check to do so, and you are still fatigued on a successful check.Feats Requiring Worship of Lamashtu...Chosen of Lamashtu",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse(""),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 33
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
            yield return Stats.Instances.Strength.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Trickery.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
