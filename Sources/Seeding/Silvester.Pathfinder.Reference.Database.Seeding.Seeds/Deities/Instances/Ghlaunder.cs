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
    public class Ghlaunder : Template
    {
        public static readonly Guid ID = Guid.Parse("8d31da52-f72c-45d6-a246-93a5c5191f7c");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Ghlaunder",
                Edicts = "Corrupt pieces of land, water sources, and communities; infect the weak; spread and nurture disease.",
                Anathema = "Aid in ending a plague or infection, destroy something out of hand when you could have instead corrupted it or leeched off it first.",
                Title = "The Gossamer King",
                AreasOfConcern = "Infection, insects, parasites, and stagnation.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("bcc6e07c-5fac-4f9b-9b79-97832f691200"), Type = TextBlockType.Text, Text = "Ghlaunder is the god of pestilence, infection, and insects. His form resembles that of a giant mosquito, warped and distended by the parasites he hosts. He leaves malaise in his wake, laying waste to everything he can. Ghlaunder revels in suffering, especially that caused by sickness: the last gasp of air into fluid-filled lungs, the terrorizing dreams that come only from the hottest of fevers. It is said that the Gossamer King was once swaddled in a cocoon, but was released by the curious Desna into the world with a cleave of her starknife. Since then, the goddess has pursued him in a macabre dance, hoping to kill him as they flit between planes." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("cb65f211-a96b-4ef3-b406-e0f0de936bab"), Spells.Instances.GoblinPox.ID);
            builder.GainSpecificSpell(Guid.Parse("41234803-1ba4-4e9b-8deb-0813b9635b38"), Spells.Instances.VomitSwarm.ID);
            builder.GainSpecificSpell(Guid.Parse("c156c32d-4061-4477-a3d4-9dd577ac81eb"), Spells.Instances.InsectForm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Spear.ID;
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
                Id = Guid.Parse("32343a1e-8cf7-46ce-88f9-2249b2a14c16"),
                Description = "The Gossamer King's gifts seem bizarre and cruel to those outside of his following, but his faithful crave his gifts zealously and fear his punishments.",
                MinorBoon = "Your commitment to filth draws a small cloud of disease-laden insects. Once, you can summon a cloud of midges, mosquitos, and flies to surround you for 1 minute. Creatures adjacent to you at any point during that time become drained 1, sickened 1, and exposed to a blood-borne illness. Ghlaunder typically grants this boon when you can infect a significant number of creatures.",
                ModerateBoon = "Ghlaunder teaches you to bide your time, corrupting and infecting until the time is right. When you expose a creature to a disease and it succeeds at its Fortitude save, it is still infected unless it critically succeeds. However, such a creature experiences no effects and the disease does not progress for the first 24 hours, even if the disease is normally fast-acting or someone uses another ability to progress the disease. It's very difficult to detect the infection in the first day; the DC for Medicine checks to do so is 5 higher.",
                MajorBoon = "Ghlaunder rewards his followers with the ability to safely spread illness—or on occasion, offers respite to desperate petitioners who please him. You do not take negative effects from any disease you are infected with unless or until Ghlaunder rescinds this benefit.",
                MinorCurse = "Ghlaunder drains away your life force for himself. You become drained 1 and can't reduce your drained condition below 1.",
                ModerateCurse = "Ghlaunder leeches your energy from you as easily as blood. Any time you fail a Fortitude save, you become fatigued in addition to all other effects.",
                MajorCurse = "You are struck with a contagious disease of the GM's choice. You and anyone else you infect can't be cured of the disease or improve its condition to an earlier stage in any way until you infect two other sapient beings with the disease.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("c05366bf-e227-428a-8936-c897a4de503c"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 5
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Decay.ID;
            yield return Domains.Instances.Plague.ID;
            yield return Domains.Instances.Swarm.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("75de64ae-c78b-4f93-b299-f718665bc331"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 59
            };
        }
    }
}
