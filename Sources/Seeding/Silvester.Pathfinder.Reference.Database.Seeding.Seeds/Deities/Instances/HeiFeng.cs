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
    public class HeiFeng : Template
    {
        public static readonly Guid ID = Guid.Parse("058d80f6-e2d1-4683-8547-efde1d7e7a50");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.TianGods.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "Hei Feng",
                Edicts = "Follow your passions, make token attempts to apologize to those you have wronged, respect the power of the sea and sky, encourage flashy entertainment.",
                Anathema = "Fake friendship with those you despise, disrespect Hei Feng or Hei Feng's estranged wife Lady Jingxi, ignore an affront to you or Hei Feng.",
                Title = "Duke of Thunder",
                AreasOfConcern = "Sea, storms, tengu, sailors.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("038a81bd-1bf9-433a-931c-297640d6b644"), Type = TextBlockType.Text, Text = "Hei Feng, the tengu god of storms, is as unpredictable as the sea, as destructive as a hurricane, and, more often than not, as drunk and foulmouthed as the sailors who pray to him. Impulsive and passionate, his heart moves between joy, sorrow, and anger in the time it takes him to finish his cup, though whatever his mood, he rarely feels it lightly. He may be so moved by a fisher's prayer that he blesses her with a catch large enough to feed her village, while later unleashing torrential waves against that same village for a slight. This unpredictability leads the rest of the Heavenly Court to regard him as troublesome, and mortals to view him with wary respect." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("54aa1406-8b73-497a-a046-3d28a2e7719f"), Spells.Instances.GustOfWind.ID);
            builder.GainSpecificSpell(Guid.Parse("c76bc163-a38d-46f1-971d-929dfa1197a6"), Spells.Instances.HydraulicTorrent.ID);
            builder.GainSpecificSpell(Guid.Parse("5a04a41a-a535-49e8-90db-6b2329ec9f6c"), Spells.Instances.ChainLightning.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.NineRingSword.ID;
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
                Id = Guid.Parse("e201b27a-6d2e-4a3c-a7da-620e33bf1d9d"),
                Description = "The Duke of Thunder's intercessions are seen more commonly than other deities' because of the god's closeness to mortals, but also because of his tendency to dispense both boons and curses while in the depths of his drink.",
                MinorBoon = "The Heavenly Court's most boastful deity ensures your boasts hit home. Once, when you fail an Intimidation check, you critically succeed instead. Hei Feng grants this boon capriciously based on his mood, sometimes even for trivial or inconsequential boasts, and he sometimes grants it for other skill checks related to boasts.",
                ModerateBoon = "Fair winds and currents speed your passage. Any vessel you use to travel over the sea gains a +10-foot status bonus to its Speeds.",
                MajorBoon = "The instruments of the storm spare you from their fury. You ignore all effects and penalties caused by precipitation and winds, and you can see normally through fog, rain, and other weather conditions.",
                MinorCurse = "Hei Feng's belligerence hangs over you like a thunderhead. You take a –1 status penalty to checks with Charisma-based skills. If you consume even a drop of alcohol, this penalty becomes –3 until the next sunrise.",
                ModerateCurse = "Your heart is as quick to change as Hei Feng's. If you roll a failure on a saving throw against an emotion effect, you get a critical failure instead.",
                MajorCurse = "The Duke of Thunder's ire follows you wherever you go. The weather in a 500-foot radius around you is always stormy. Roughly twice each minute you are outside, you are struck by a bolt of lightning that deals 10d6 electricity damage (DC 40 basic Reflex save).",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("58840cbb-b4ba-46da-b137-be10e7d9c566"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 7
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Performance.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Lightning.ID;
            yield return Domains.Instances.Water.ID;
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
                Id = Guid.Parse("dc8750b0-c7bc-458f-9117-e8527713d07a"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 63
            };
        }
    }
}
