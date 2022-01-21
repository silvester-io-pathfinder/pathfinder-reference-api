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
    public class Arazni : Template
    {
        public static readonly Guid ID = Guid.Parse("0d1e223d-c9d7-4251-8602-a0dfd59bf473");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.NeutralEvil.ID,
                Name = "Arazni",
                Edicts = "Act with dignity, do whatever it takes to survive, despise and never forgive those who have hurt you.",
                Anathema = "Create unwilling undead, insult Arazni.",
                Title = "The Unyielding",
                AreasOfConcern = "Abused, dignity, unwilling undeath.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("fef3a3a5-a32a-469a-9e47-2c7781dd8600"), Type = TextBlockType.Text, Text = "More than anything, Arazni is a survivor. Once, long ago, she was a force for good, a warrior-mage who sought to improve the quality of life for residents of her homeland. Long after her mortal death, she returned as a herald of the god Aroden and fought alongside mortals during one of their darkest hours. But humanity and her patron alike abandoned her—first to the Whispering Tyrant, then to the necromancer Geb—and the torments she endured because of it changed her deeply. Still she survived, her broken body reanimated against her will as a powerful undead monstrosity. For over a millennium she was held captive as the lich queen of the undead nation of Geb, and her view of mortals, and humanity in particular, soured." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("b4fa843f-2fc6-4a49-a187-972fc3747faf"), Spells.Instances.Endure.ID);
            builder.GainSpecificSpell(Guid.Parse("0351a526-9653-4610-bbb5-dc53a31a7cce"), Spells.Instances.AnimusMine.ID);
            builder.GainSpecificSpell(Guid.Parse("b5a00370-f01c-4e2a-849c-0a1735929110"), Spells.Instances.Feeblemind.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Rapier.ID;
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
                Id = Guid.Parse("48bd81f4-ad7e-417c-9491-61b8ec844de4"),
                Description = "While the Unyielding has little regard for her followers, if suitably irritated or impressed, she might bestow the following banes or boons.",
                MinorBoon = "Once, when you fail a saving throw against an effect that would compel you to take some action against your will, you critically succeed instead. Arazni typically grants this boon for consequential actions or particularly egregious violations of free will.",
                ModerateBoon = "Blood from your wounds forms into armor or a piece of equipment you need. If what you need most is information, the blood forms letters spelling out that information.",
                MajorBoon = "Upon death, you return to life with the effects of a critical success on a resurrect ritual to enact vengeance against your killers. When you successfully achieve vengeance, abandon your vengeance for other pursuits, or fail outright, you crumble to scarlet dust.",
                MinorCurse = "Someone you've wronged gains information they desire about you, with the effects of a critical success at the commune ritual.",
                ModerateCurse = "Creatures weaker than you gain a status bonus on all attack rolls against you equal to your difference in levels, to a maximum of +4. Whenever you are damaged by a such a creature, you take persistent bleed damage equal to twice the difference between your levels (no maximum).",
                MajorCurse = "When you would regain Hit Points due to either a positive or negative effect, you lose that many Hit Points instead.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("67e54f09-03d7-4253-9cf6-93a86d3037c7"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 3
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
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Freedom.ID;
            yield return Domains.Instances.Pain.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("abf1c89b-445f-4100-b4b1-b3eee506656e"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 54
            };
        }
    }
}
