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
    public class GrandmotherSpider : Template
    {
        public static readonly Guid ID = Guid.Parse("e859e795-8ec5-4c0e-8754-bedbb712d90b");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Grandmother Spider",
                Edicts = "Be skilled and clever, think for yourself, take due payment for your work, humiliate the powerful.",
                Anathema = "Abuse someone you have power over, harm someone who has given you sincere kindness, let a slight go unanswered, own a slave.",
                Title = "The Weaver",
                AreasOfConcern = "Family, illusion, stories, twilight, weaving.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("797b4514-bb50-4413-9eae-7277d585c817"), Type = TextBlockType.Text, Text = "Also known as Nana Anadi, Grandmother Spider began her existence as a servant of the other gods, meant to weave fate and reality into existence. Infuriated at her position as a lackey, she made fools of the greater gods through mischief and disruption. She stole and copiedAsmodeus'keys, resulting in widespread chaos, and pilfered some ofSarenrae'sfire, leading numerous followers astray. Nimbly avoiding any retribution for her antics, Grandmother Spider rewove the strands of fate for herself, gaining her freedom. She regularly pleads with her brotherAchaekekto follow her lead and rebel against the gods, and while he always refuses, seemingly indifferent, Achaekek has on one notable occasion proven vengeful toward those who harm his sister or her followers." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("13b11286-d912-45c7-8db7-60ca8beccf76"), Spells.Instances.PestForm.ID);
            builder.GainSpecificSpell(Guid.Parse("7d785cfd-dd39-4735-b5c3-5aab2f7dcc2f"), Spells.Instances.Web.ID);
            builder.GainSpecificSpell(Guid.Parse("837fb661-1feb-4f1c-8858-00e02ad3002e"), Spells.Instances.Glibness.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return Items.RangedWeapons.Instances.Bola.ID;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            
            return new DivineIntercession
            {
                Id = Guid.Parse("7fb929b6-3ae5-4010-be55-5c314a8ffda4"),
                Description = "Though the Weaver often condones bad decisions so long as a lesson is learned, and is even willing to accept being fairly tricked herself, cruelty and predation upon the weak draw her outrage.",
                MinorBoon = "Grandmother Spider rescues your prank from the jaws of failure. Once, when you would fail a Deception check, you critically succeed instead. Grandmother Spider typically grants this boon for deceptions that are necessary for an interesting or consequential prank.",
                ModerateBoon = "You can feel tugs on the strands of fate. You gain a +2 status bonus to initiative rolls.",
                MajorBoon = "Grandmother Spider rejoices in freedom and tricks those who would limit it. Any time you would become grabbed, immobilized, or restrained, attempt a DC 10 flat check. On a success, you ignore the effect, and the originator of the effect becomes grabbed, immobilized, or restrained instead. If this simply causes a creature to grab itself, it can usually Escape as a free action, but it might be stuck if it tried to immobilize you in other ways.",
                MinorCurse = "When your pranks start going wrong, they dissolve into a string of catastrophic failures. When you roll a failure on a Deception or Stealth check, you get a critical failure instead.",
                ModerateCurse = "Grandmother Spider weaves a web to ensnare you, and you trail webs behind you wherever you go. You become permanently slowed 1 and take a –10-foot circumstance penalty to your Speeds.",
                MajorCurse = "Grandmother Spider throws all of her might behind the underdog. Any time a creature with a level lower than yours rolls a success on a check against you, it critically succeeds instead; any time you roll a failure on a check against a creature with a level lower than yours, you critically fail instead.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("07c64179-74fc-48cd-885b-6b66e0d922f0"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 5
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
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Trickery.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("9ca953ef-52f4-413e-a503-8a3fb557aacf"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 60
            };
        }
    }
}
