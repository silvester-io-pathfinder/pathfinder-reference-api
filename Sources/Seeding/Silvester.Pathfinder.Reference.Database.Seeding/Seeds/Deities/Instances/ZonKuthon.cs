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
    public class ZonKuthon : Template
    {
        public static readonly Guid ID = Guid.Parse("87b30915-8ce1-483e-9727-fc9a69f427b6");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Zon-Kuthon",
                Edicts = "Bring pain to the world, mutilate your body.",
                Anathema = "Create permanent or long-lasting sources of light, provide comfort to those who suffer.",
                Title = "Midnight Lord",
                AreasOfConcern = "Darkness, envy, loss, and pain.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("0c0a93a0-9a42-4d0a-b1ff-c4236b1c34f3"), Type = TextBlockType.Text, Text = "The Midnight Lord embodies and glorifies pain, shadows, and mutilation, and he is one of the most twisted and malevolent gods on the face of Golarion. Once known as Dou-Bral, he crafted the immense Star Towers that still help keepRovagugpinned in his prison at Golarion's heart, lending his own skill and ability to the great deific alliance to bind that evil entity. Yet a divine argument between him and his sisterShelynresulted in the god departing for parts unknown. Zon-Kuthon traveled beyond the edges of the multiverse and stared into the face of the incomprehensible things that dwell there. No one knows what he found in that place, but he returned—changed, but claiming to be strengthened by what he had endured. Likewise, the nation of Nidal on Golarion, which is bound to him, is a nation of survivors, founded by those few strong enough to do what they must so their people could survive the terrible aftermath of Earthfall and the Age of Darkness that followed." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("65c6d1fd-bd30-481b-baec-4f512d819572"), Spells.Instances.PhantomPain.ID);
            builder.GainSpecificSpell(Guid.Parse("b633aba0-5e7b-41d7-abfb-eb4c56db1795"), Spells.Instances.WallOfThorns.ID);
            builder.GainSpecificSpell(Guid.Parse("21c88a79-f70d-47f8-8169-3cea640bb407"), Spells.Instances.ShadowWalk.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.SpikedChain.ID;
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
                Id = Guid.Parse("284c90e5-7ddb-41cd-a8e2-ddd89ac372ea"),
                Description = "Zon-Kuthon rarely intervenes directly in mortal affairs, but when he does take a personal interest in a creature, the effect is as terrible as the god himself.",
                MinorBoon = "The Midnight Lord turns your blood and pain into chains of midnight darkness to destroy your foes. Once, for 1 minute, whenever you take slashing, piercing, or bleed damage, chains rip forth from your body, affecting creatures in a line from your position in the direction of the attack (or in the direction of your choice for bleed damage or if you deal the damage yourself) with the effect of a grim tendrils spell whose level is equal to half your level rounded up, and whose DC is your highest spell DC (or 10 + your level + your Wisdom modifier if you have no spell DC).",
                ModerateBoon = "Each morning, during your daily preparations, scars gather into words on your flesh. The scars function as a scroll of a divine spell of Zon- Kuthon's choosing. After you use the scroll or receive magical healing, the boon fades for the day, though some or all of the scars might remain as a reminder.",
                MajorBoon = "Shadows are deeper around you. Darkvision and greater darkvision cannot penetrate darkness within 60 feet of you, but you can see through it normally.",
                MinorCurse = "You are surrounded by spectral chains that cause you to always be encumbered and that have the same effects as armor with the noisy trait.",
                ModerateCurse = "You share the pain of others, and even minor wounds bring you incredible pain. Whenever you see (or otherwise sense) a creature take damage, you take 1d6 mental damage. Whenever you take damage any other way than from the first part of this curse, you take 1d6 mental damage from increased pain and are sickened 1. Mental damage from this curse ignores any resistance you have to mental damage.",
                MajorCurse = "Zon-Kuthon steals away your joy, leaving you with only pain. You lose that which you cherish the most forever, and lose the ability to feel joy. You can't gain benefits from emotion effects based on positive emotions. If Zon-Kuthon feels you are ready to renounce, destroy, mutilate, or torture that which you once cherished most, he might return it to you to allow you to do so.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("771c9c07-4ea0-495c-8ed3-566f40d2a8c0"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 51
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Pain.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("19b1766c-ece8-4563-b416-7a7b746be15d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 440
            };
        }
    }
}
