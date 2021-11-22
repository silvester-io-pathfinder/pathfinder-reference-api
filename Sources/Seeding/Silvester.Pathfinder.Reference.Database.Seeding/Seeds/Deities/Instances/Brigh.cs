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
    public class Brigh : Template
    {
        public static readonly Guid ID = Guid.Parse("64c11189-6ba5-4fdd-b64a-54d96c843dd9");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Brigh",
                Edicts = "Craft new creations, pay attention to details, share achievements.",
                Anathema = "Carelessly destroy others' creations or research, enslave intelligent constructs, abuse constructs, refuse to acknowledge or learn from mistakes.",
                Title = "The Whisper In Bronze",
                AreasOfConcern = "Clockwork, invention, and time.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("47ba87cf-e265-41cd-afb8-9581d2fbfcd9"), Type = TextBlockType.Text, Text = "Brigh's exact origins are unknown, though her priests and various religious scholars have many theories on the matter. Some believe she was a construct who achieved consciousness and a spark of divinity, while others think she was a human alchemist and inventor who discovered ways to fuse mechanical components with her own physiology. Regardless of her origins, Brigh is a patient and thoughtful god who promotes unending curiosity and constant intellectual advancement. Her two most common forms are a humanoid woman made of bronze clockwork and a human woman wearing a bronze skullcap and armor composed of gears and other movable metal pieces. Though Brigh's usual demeanor is composed and reserved, she isn't an unfeeling automaton; she deeply cherishes the creations she and her followers make, and most of her worshippers feel the same way." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("b8710e57-3ae5-4675-be56-f5d93b96b835"), Spells.Instances.TemporaryTool.ID);
            builder.GainSpecificSpell(Guid.Parse("1d6343b9-6acd-40d1-9506-ddb45846f07f"), Spells.Instances.Creation.ID);
            builder.GainSpecificSpell(Guid.Parse("4cd02c96-9404-442c-ae36-7f5ea7bd759b"), Spells.Instances.DuplicateFoe.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.LightHammer.ID;
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
                Id = Guid.Parse("48c255f0-bdbd-44ac-9bf8-f5c79fee14c1"),
                Description = "The Whisper in Bronze doesn't dole out punishments or rewards to her followers lightly.",
                MinorBoon = "Knowledge floods your mind. Once, you can reroll a failed skill check to Recall Knowledge; you must use the second result, even if it's worse.",
                ModerateBoon = "You become a wellspring of invention. You gain the Inventor feat, even if you don't meet its prerequisites, and when you roll a Crafting check for the Inventor feat, you use the result one degree of success better than the result you rolled.",
                MajorBoon = "You gain the companionship of a loyal construct ally of Brigh's choice at least 1 level lower than you. If the construct is destroyed, it rebuilds itself over the course of a week, and as you gain levels, the construct upgrades and improves itself, becoming more powerful.",
                MinorCurse = "Your hands shake when attempting delicate work. All your failures to Craft or Repair items are instead critical failures.",
                ModerateCurse = "Whenever you try to perform engineering or science tasks, everything just seems to explode. Whenever you attempt to create or use an alchemical item or a construct, Disable a Device, and so on, you must attempt a DC 15 flat check. On a failure, something explodes and you take 1d6 fire damage (or a different type of damage, if appropriate) per level of the item, construct, or device (DC 40 basic Reflex save).",
                MajorCurse = "Constructs—even mindless constructs you thought you could control—seek your demise. All constructs are hostile to you and attack you when they notice your presence. Occasionally, inanimate statues and other objects animate as constructs to pursue Brigh's vengeance.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("8ef5b99f-c50f-4070-af6e-0f10649b3708"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 4
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Crafting.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Time.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("5adb8bdc-1190-4bff-9dd9-240754fa7dca"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 56
            };
        }
    }
}
