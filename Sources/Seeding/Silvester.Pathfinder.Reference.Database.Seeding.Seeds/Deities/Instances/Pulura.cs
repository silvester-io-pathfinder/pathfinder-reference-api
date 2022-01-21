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
    public class Pulura : Template
    {
        public static readonly Guid ID = Guid.Parse("e0795409-ebfb-4b3c-8768-77d305b654eb");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Pulura",
                Edicts = "Aid travelers, comfort the lonely, teach the constellations.",
                Anathema = "Mock the homesick, deny warmth to others, pollute the skies with smoke or light.",
                Title = "The Shimmering Maiden",
                AreasOfConcern = "Constellations, homesickness, and northern lights.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("4aeb6525-05b3-41e1-abc3-a4332b3f8bf0"), Type = TextBlockType.Text, Text = "Dancing through the northern sky, the Shimmering Maiden represents constellations, homesickness, and northern lights. Pulura understands that the constellations are the guide with which mortals navigate their world, lighting the way so that those who travel or explore can always find their way home. The stories of the constellations not only entertain with tales of goodness and light and strength, but they are also a tool for helping others learn and remember the stars. This ensures that the map in the sky is easy to read and never forgotten. To learn this map and to guide those who are lost or otherwise in need of direction are exceptional callings, but even more so is to teach a petitioner to navigate the skies themself on the journey." };
            yield return new TextBlock { Id = Guid.Parse("f9e47720-8cd7-4e81-a789-d011acaa8ecc"), Type = TextBlockType.Text, Text = "The Shimmering Maiden is often difficult to see, appearing to mortals from great distances as a bright, hot star. When she can be seen, she has the appearance of a Tian woman whose dark hair twinkles with bright stars. Her green and pink robes appear as though they are made of light, rather than any fabric. Travelers, guides, nomads, explorers, sailors, stargazers, and hunters are some of Pulura's followers." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("f2d2d69d-1d63-41f6-9843-b53160ade8e2"), Spells.Instances.ColorSpray.ID);
            builder.GainSpecificSpell(Guid.Parse("cda5a886-68ee-4677-a77d-091fbb9deb46"), Spells.Instances.ChromaticWall.ID);
            builder.GainSpecificSpell(Guid.Parse("c3e86682-bfab-4a85-8d75-ea1f06d8e6b2"), Spells.Instances.Teleport.ID);
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
            
            yield return Items.RangedWeapons.Instances.Sling.ID;
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
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Cold.ID;
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Sorrow.ID;
            yield return Domains.Instances.Star.ID;
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
                Id = Guid.Parse("436ce4f0-fffb-450c-a3c1-c63379b0bdf3"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
