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
        public static readonly Guid ID = Guid.Parse("cc0a4c87-87cc-47c6-9c7f-150e8f4f66bf");

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
            builder.GainSpecificSpell(Guid.Parse("786f2d97-32e7-4ea4-9d90-1fbe0113e67f"), Spells.Instances.ShatteringGem.ID);
            builder.GainSpecificSpell(Guid.Parse("2ffa7d8f-cbdc-4de3-b8f3-3f9514ae577d"), Spells.Instances.ShapeWood.ID);
            builder.GainSpecificSpell(Guid.Parse("9633712a-ef20-4aad-861b-a784b100af45"), Spells.Instances.MeldIntoStone.ID);
            builder.GainSpecificSpell(Guid.Parse("0c82b3f9-ed68-4a20-b47d-20a3b0eaf009"), Spells.Instances.SpeakWithPlants.ID);
            builder.GainSpecificSpell(Guid.Parse("151d3f4c-7063-4e97-ba7e-4e8ebc1d0e95"), Spells.Instances.TreeStride.ID);
            builder.GainSpecificSpell(Guid.Parse("9622f8bc-9a84-44d8-a6d0-00fd6485d1cf"), Spells.Instances.TanglingCreepers.ID);
            builder.GainSpecificSpell(Guid.Parse("4aa58d0d-69f5-4970-bc1a-afe592035972"), Spells.Instances.UnfetteredPack.ID);
            builder.GainSpecificSpell(Guid.Parse("4361e56c-34c9-4721-ae2f-3434a9a3ac1a"), Spells.Instances.PrismaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse("ed1ceb0e-2a57-4eae-b761-de8cc4809a9b"), Spells.Instances.NaturesEnmity.ID);
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
                Id = Guid.Parse("c437a8e0-e0ec-4286-aa35-84d74c1602be"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
