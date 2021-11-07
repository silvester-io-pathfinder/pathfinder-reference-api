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
    public class Yuelral : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElvenGods.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Yuelral",
                Edicts = "Practice herbalism, use and enchant gems, encourage and teach magicians and jewelers, preserve elven magic and knowledge.",
                Anathema = "Cut a gem for aesthetic purposes, defile nature, allow the irresponsible use of magic.",
                Title = "The Wise",
                AreasOfConcern = "Gems, craft, and magic.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShatteringGem.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShapeWood.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.MeldIntoStone.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.SpeakWithPlants.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TreeStride.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.TanglingCreepers.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.UnfetteredPack.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PrismaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.NaturesEnmity.ID);
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
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Magic.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
