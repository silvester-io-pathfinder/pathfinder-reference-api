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
    public class Moloch : Template
    {
        public static readonly Guid ID = Guid.Parse("37615433-afd2-43df-9a2d-4bc33a56028e");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Archdevils.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Moloch",
                Edicts = "Spread Hell's order through war, convert communities to sole worship of Moloch, sacrifice creatures in fire.",
                Anathema = "Defy a military superior, flee in battle [unless ordered to do so], lose your combat edge due to your vices.",
                Title = "The Ashen Bull",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("60874ee9-7eb6-4ebd-a1ed-0c3d362456d4"), Type = TextBlockType.Text, Text = "The general of Hell's armies, Moloch, embodies infernal discipline and incomparable destructive power. Across his ream of Malebolge, the sixth layer of Hell, the Ashen Bull trains countless legions of devils to wage unending war. He not only teaches obedience, but demands it, punishing even the slightest misstep or insurrection with immediate, fiery retribution. Despite his harsh nature, Moloch is the most widely worshipped of the archdevils among mortals, as he is the most likely to answer supplicants' mundane pleas. In exchange, he asks only their souls to add to his endless armies—a price many are willing to pay." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("7746aa76-46cb-45d1-81b6-c54e47944850"), Spells.Instances.BurningHands.ID);
            builder.GainSpecificSpell(Guid.Parse("b863af34-162c-49b0-9b6d-a0ab8f01b064"), Spells.Instances.AcidStorm.ID);
            builder.GainSpecificSpell(Guid.Parse("c8b0a816-dc98-48f7-acf0-acaf9b98eec7"), Spells.Instances.FieryBody.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Whip.ID;
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
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Destruction.ID;
            yield return Domains.Instances.Duty.ID;
            yield return Domains.Instances.Fire.ID;
            yield return Domains.Instances.Might.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("ab5a3800-2cf5-4d0a-9c0f-939c8b4fede5"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
