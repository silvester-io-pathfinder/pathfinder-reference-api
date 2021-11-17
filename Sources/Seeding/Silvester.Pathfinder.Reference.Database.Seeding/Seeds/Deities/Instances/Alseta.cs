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
    public class Alseta : Template
    {
        public static readonly Guid ID = Guid.Parse("a8cb66d4-99be-49cb-995d-eddf4b4d567f");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Alseta",
                Edicts = "Offer to protect passageways and guide others through transitions, treat all other beings with courtesy and respect.",
                Anathema = "Destroy a door or block a path for personal gain, stop a transition without good reason.",
                Title = "The Welcomer",
                AreasOfConcern = "Doors, portals, thresholds, traditions.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("7fa610da-e3a5-40cb-a083-f18876fed234"), Type = TextBlockType.Text, Text = "Alseta holds sway over transitions. Physical transitions through doorways and portals or over thresholds, metaphorical transitions, and even the forward flow of time—Alseta influences them all. She watches over city gates, helping keep invaders out and defenders safe. She also watches over those moving into a new stage in life, whether that means a birthday, a marriage, or a more fitting body. It is common for anyone entering into a life change, such as moving to a new town or changing careers, to look to Alseta for guidance. Likewise, birth and death are both transitions, and expectant mothers and the bereaved both offer her prayers, linking Alseta's church to that ofPharasma. Some consider Alseta to be the goddess of teleportation, though she does not officially claim that title. She is also a popular god among some elven nations and cultures, who frequently associate Alseta with theaiudara, or elf gates, around Golarion." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("2883397a-03c9-402c-8410-375fef7e3008"), Spells.Instances.AnticipatePeril.ID);
            builder.GainSpecificSpell(Guid.Parse("2615e4a4-dd2d-4be0-97ec-f0991484dbd2"), Spells.Instances.Knock.ID);
            builder.GainSpecificSpell(Guid.Parse("ce161b1f-1346-4f3e-bbbc-190e3c473b33"), Spells.Instances.DimensionDoor.ID);
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
                Id = Guid.Parse("dd59c8d7-628d-4008-a0ac-98f393af3e29"),
                Description = "The Welcomer is a patient goddess that rewards her followers. Incurring her wrath through discourtesy, lack of respect or intentionally making doors unpassable for any reason other than preventing harm can lead to reprimands that range from annoying to frustrating.",
                MinorBoon = "Alseta's guiding hand aids your journeys. Once, when employing teleportation magic, you appear exactly on target, even if you used a notoriously imprecise spell like plane shift. Alseta typically grants this boon for extremely consequential magical travel, especially when time is of the essence.",
                ModerateBoon = "New doors open themselves for you. You can cast knock once per day as a divine innate spell.",
                MajorBoon = "You transition unimpeded through the world. You can open any door or portal simply by placing your palm upon it with a single Interact action, even if it's locked or magically sealed, and you can enter any open door or threshold, even if it's magically warded to prevent entry. This doesn't overcome the locks and magic of artifacts, deities, and similarly powerful effects.",
                MinorCurse = "Doors jam and locks stick when you try to open them. It takes 3 Interact actions for you to open even an unlocked door, and each attempt to Pick a Lock takes you 2 rounds instead of 2 actions.",
                ModerateCurse = "Crossing thresholds becomes daunting. Whenever you move through a portal, gateway, or door, you gain the sickened 2 condition. Magical travel is even more exhausting; after traveling via teleportation, plane shift, or the like, you also gain the fatigued condition until you get a full night's rest.",
                MajorCurse = "Transportation magic no longer works for you. You cannot be transported by any magical means, nor can you transport, conjure, or summon others. Even extradimensional spaces like bags of holding are inaccessible and unusable to you, as using them requires magical transportation to the extradimensional space.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("0e65978f-ab37-4367-8fbb-661599539379"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 3
                }
            };
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
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Protection.ID;
            yield return Domains.Instances.Time.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("b95d86cb-0958-4640-97f8-04d72a5282c0"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 53
            };
        }
    }
}
