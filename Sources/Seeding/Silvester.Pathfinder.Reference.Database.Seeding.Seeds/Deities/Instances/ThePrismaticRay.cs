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
    public class ThePrismaticRay : Template
    {
        public static readonly Guid ID = Guid.Parse("a1a86f77-499b-4e3e-a68e-73839542125f");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "The Prismatic Ray",
                Edicts = "Create works that inspire good acts, defend those who cannot defend themselves, pursue evil.",
                Anathema = "Allow evil to spread, destroy that which brings joy to others, fail to offer evil a chance to surrender.",
                
                AreasOfConcern = "Defeating evil, guarding innocents, and wholesome creations.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("f07201fe-811e-4535-bc22-14c5a29f48e8"), Spells.Instances.Sleep.ID);
            builder.GainSpecificSpell(Guid.Parse("7d0bf705-99e8-4758-9175-5f20e68c8426"), Spells.Instances.Fireball.ID);
            builder.GainSpecificSpell(Guid.Parse("d3788a6e-8341-4702-a300-26386026e8b3"), Spells.Instances.Creation.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Shortsword.ID;
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
            yield return Skills.Instances.Diplomacy.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Moon.ID;
            yield return Domains.Instances.Protection.ID;
            yield return Domains.Instances.Sun.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("4e162da0-012f-40b3-a501-d00cfc8da748"),
                SourceId = Sources.Instances.FriendsInHighPlaces.ID,
                Page = 1
            };
        }
    }
}
