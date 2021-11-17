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
    public class Adanye : Template
    {
        public static readonly Guid ID = Guid.Parse("ec1042a8-2edc-439f-a915-cfdf1df07794");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Adanye",
                Edicts = "Keep your counsel, follow your heart, appreciate a warm hearth, defend those who welcome you into their home.",
                Anathema = "Force anyone into drudgery or mindless work, deny support to loved ones, surrender when escape is an option, destroy a place that has given you shelter.",
                Title = "The Warmth of the Hearth",
                AreasOfConcern = "Hearth, imagination, protection, solitude.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("b70712d6-6e09-4190-99e3-4304cb125a0c"), Type = TextBlockType.Text, Text = "Legend holds that theamurruns—known as catfolk to others—were created as guardians against threats to home, nature, and the world at large. While the goddess Adanye is not considered to be their creator, she is said to have mentored these first guardians, teaching them the skills necessary to protect and defend, both in combat and in careful interaction with others. She also taught the importance of what they protected, identifying the hearth and the home, as well as the right to self-determination and to solitude, as worthy of defense. She is said to have instilled in the amurruns their need for solitude and their esteem of imagination. A master teacher, she is depicted as a graying catfolk woman or a cat by the hearth fire, her large, gentle eyes full of wisdom." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("1b32ec56-a539-4d9d-820e-7094899f3929"), Spells.Instances.FeatherFall.ID);
            builder.GainSpecificSpell(Guid.Parse("37131d66-87ed-4592-a3d2-a7d60658ef8e"), Spells.Instances.Misdirection.ID);
            builder.GainSpecificSpell(Guid.Parse("072b9903-937e-4b66-bec6-1d6dcbe5fa25"), Spells.Instances.MagnificentMansion.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Kukri.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            
            yield return UnarmedWeapons.Instances.Claws.ID;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Duty.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Protection.ID;
            yield return Domains.Instances.Repose.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("16d2768c-cb35-4c11-926a-fe8d04626551"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 132
            };
        }
    }
}
