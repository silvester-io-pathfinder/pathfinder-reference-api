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
    public class Pharasma : Template
    {
        public static readonly Guid ID = Guid.Parse("a0313748-84b3-4974-bb3f-98212c985680");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.GodsOfTheInnerSea.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Pharasma",
                Edicts = "Strive to understand ancient prophecies, destroy undead, lay bodies to rest.",
                Anathema = "Create undead, desecrate a corpse, rob a tomb.",
                Title = "Lady of Graves",
                AreasOfConcern = "Birth, death, fate, prophecy, and time.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("d6392502-1639-44e9-a702-415f42a82b4c"), Type = TextBlockType.Text, Text = "No record of history, and not even other gods, can recall a time before Pharasma. Her throne lies within a vast, gothic cathedral located on the infinite Spire at the center of the planes. From here, she looks both forward and backward in time, observing the births, lives, and deaths of every soul, as she serves as the final arbiter of a soul's destination after death. Psychopomp servants of Pharasma guide and safeguard newly dead souls along the River of Souls to her realm, where she judges each soul and ensures it is sent to the proper plane for its afterlife, according to its alignment and mortal deeds. Although she can see all possible fates and knows the fate of each individual, free will and choice can alter a soul's final destination, and she places great weight on the individual's actions and personal choices. Therefore, Pharasma withholds her final judgment until a soul stands before her. Her prophecies are cryptic, and their full meanings are rarely revealed until the foretold events occur." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("70246b17-1188-47d8-8a6b-cec7df9d17d4"), Spells.Instances.Mindlink.ID);
            builder.GainSpecificSpell(Guid.Parse("c6b67f42-716a-497a-acfb-7fc308d6033c"), Spells.Instances.GhostlyWeapon.ID);
            builder.GainSpecificSpell(Guid.Parse("2f436b9b-bd79-437f-8d06-2b0974067e0b"), Spells.Instances.PhantasmalKiller.ID);
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
                Id = Guid.Parse("541aa4c1-0bee-451e-8a45-dfbee15d5dad"),
                Description = "Those who would prevent a soul from reaching the afterlife draw Pharasma's ire, but those who merely dabble in pursuits like lengthening their life or resurrection are usually ignored, as eventually death comes for all.",
                MinorBoon = "You see a momentary, prophetic glimpse of your fate. Once, you gain a +2 status bonus to a single check; you can apply this bonus after you determine the result, and it can potentially change the degree of success.",
                ModerateBoon = "You gain a greater mastery over the energies of life and death. Your Strikes deal 1 positive damage to undead. Your spells that deal positive damage to undead gain a +1 status bonus to damage per spell level, and your spells that heal the living gain a +1 status bonus to the Hit Points restored per spell level.",
                MajorBoon = "Pharasma keeps you alive to fulfill your fate. The GM secretly chooses a fate Pharasma knows you must fulfill. Until you fulfill this fate, any time you would die, a grave but nonfatal misfortune instead befalls you. You take at least a full day to recuperate and you potentially face permanent consequences, but you don't die. If you would have died even once without this boon, once your fate is complete, you let out a final sigh and then die peacefully.",
                MinorCurse = "Horrifying or enticing visions of your final judgment distract you from the task at hand. You take a –2 status penalty to initiative rolls.",
                ModerateCurse = "Fate turns against you and reveals dire portents. Divinations such as augury cast by you or that involve you always suggest woe. Once per day after you attempt a check, the GM can make the result of the roll a natural 1.",
                MajorCurse = "Pharasma wills the end of your life and your lineage. You become unable to have children (or otherwise procreate by any means, including create spawn abilities) and are permanently doomed 2.",
                SourcePage = new SourcePage
                {
                    Id = Guid.Parse("3c939526-d003-42b7-abd9-994bd070d949"),
                    SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                    Page = 39
                }
            };
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Death.ID;
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Knowledge.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("de359d8f-03d5-4b9d-b489-108781bfe599"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
