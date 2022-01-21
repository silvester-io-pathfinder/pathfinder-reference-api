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
    public class Selket : Template
    {
        public static readonly Guid ID = Guid.Parse("0d54d7eb-d739-4c13-ae02-86ba0bbca76a");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.AncientOsirianGods.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Selket",
                Edicts = "Avenge the wronged, protect the dead and the vulnerable, use poison and suffocation, heal others.",
                Anathema = "Poison someone you didn't intend to, harm a creature as punishment for a different creature's crime, desecrate a corpse.",
                Title = "Mistress of the Beautiful House",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("1b33d8a5-8d99-4a51-9786-b5ae60d95e54"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("c2d2676f-1fb4-4514-b567-100495700239"), Spells.Instances.Paralyze.ID);
            builder.GainSpecificSpell(Guid.Parse("678d4fa3-ae44-4973-a43c-77e434188b71"), Spells.Instances.PurpleWormSting.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Whip.ID;
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
            yield return Skills.Instances.Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("82b8ffe6-17df-4726-a7c5-d52420726ce6"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
