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
    public class Sairazul : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.ElementalLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Sairazul",
                Edicts = "Shelter others within stone and earth, care for Sairazul‘s children, aid childbirths, mine responsibly.",
                Anathema = "Damage subterranean natural wonders, collapse an earthen structure on a creature.",
                Title = "The Crystalline Queen",
                AreasOfConcern = "Caves, earth, and gems.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Sairazul, the Crystalline Queen, is the elemental lord of caves, earth, and gems. Planar scholars who know of the benevolent lord of earth speak of Sairazul as a mother and creator who gave birth to numerous races of outsiders, including agrawghs and xiomorns. She is currently imprisoned within theMoaning Diamond, a pure gemstone encircled by eternally crying winds, unable to contact the outside world. Several of her consorts still live to this day, searching the planes for her prison in the hopes that her release will usher in an era of renewed creation across thePlane of Earth. Though the Crystalline Queen can't grant power of any kind to her followers, a handful of her children on the Plane of Earth remain faithful to their creator, and she is remembered with great reverence byMaterial Planecultists who exalt creation and reproduction." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ShatteringGem.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.ExpeditiousExcavation.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Stoneskin.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Pick.ID;
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
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Earth.ID;
            yield return Domains.Instances.Family.ID;
            yield return Domains.Instances.Toil.ID;
            yield return Domains.Instances.Wealth.ID;
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
