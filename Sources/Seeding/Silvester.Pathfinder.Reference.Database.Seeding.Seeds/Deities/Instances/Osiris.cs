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
    public class Osiris : Template
    {
        public static readonly Guid ID = Guid.Parse("edbda8a3-9dee-4a84-a633-efbb7b3fd528");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.AncientOsirianGods.ID,
                AlignmentId = Alignments.Instances.LawfulGood.ID,
                Name = "Osiris",
                Edicts = "Ensure the health of crops and vegetation, protect the bodies and souls of the worthy dead, avenge the wrongly murdered.",
                Anathema = "Dismember a creature, desecrate a corpse, show ingratitude for a sincere gift.",
                Title = "Lord of the Living",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("97c43134-7571-49b7-92ac-e29407ae4329"), Spells.Instances.Soothe.ID);
            builder.GainSpecificSpell(Guid.Parse("fff0b758-8249-4a6d-b0c5-1895031902e2"), Spells.Instances.FalseLife.ID);
            builder.GainSpecificSpell(Guid.Parse("e6993a38-5c14-495e-9f74-cb4f265bafcf"), Spells.Instances.TanglingCreepers.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Flail.ID;
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
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Healing.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Soul.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("f52f6a6d-8fa9-4d0c-ad3f-097b088da41e"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
