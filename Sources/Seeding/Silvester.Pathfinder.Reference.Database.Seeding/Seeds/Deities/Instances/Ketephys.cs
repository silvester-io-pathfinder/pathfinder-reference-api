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
    public class Ketephys : Template
    {
        public static readonly Guid ID = Guid.Parse("e8e69bff-bc88-4510-8ad1-de8d9abbcccc");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElvenGods.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Ketephys",
                Edicts = "Hunt and kill demons and undead, maintain the health of the forest, provide for your community.",
                Anathema = "Take more than needed from the wilderness, hunt an animal for sport, aid Treerazer or his minions.",
                Title = "The Hunter",
                AreasOfConcern = "Hunting and the moon.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("e5048340-c10e-47fc-9924-52098e605dbc"), Spells.Instances.PassWithoutTrace.ID);
            builder.GainSpecificSpell(Guid.Parse("7f3027bd-abdc-4c2f-a629-7a176f8d4845"), Spells.Instances.Invisibility.ID);
            builder.GainSpecificSpell(Guid.Parse("dde75f6b-d931-4714-9158-91ce624f2ad5"), Spells.Instances.AnimalVision.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Longbow.ID;
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
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Moon.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Secrecy.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("767bc308-d9ed-4c2c-a453-84c22a283948"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
