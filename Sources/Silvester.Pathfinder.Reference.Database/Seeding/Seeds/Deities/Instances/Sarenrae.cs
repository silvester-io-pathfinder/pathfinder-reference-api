using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Alignments.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DeityCategories.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.DivineFonts.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Domains.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Skills.Instances;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class Sarenrae : Template
    {
        public static readonly Guid ID = Guid.Parse("6e4564c3-6765-47d3-bf6a-e707d41388c2");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = NeutralGood.ID,
                Name = "Sarenrae", 
                Description = "The Dawnflower is goddess of healing, honesty, redemption, and the sun. Once a powerful angel and empyreal lord, Sarenrae led the charge to imprison Rovagug. She seeks to redeem evil where possible, or else destroy it swiftly.",
                Edicts = "Destroy the Spawn of Rovagug, protect allies, provide aid to the sick and wounded, seek and allow redemption.",
                Anathema = "Create undead, lie, deny a repentant creature an opportunity for redemption, fail to strike down evil.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Medicine.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Fire.ID;
            yield return Healing.ID;
            yield return Sun.ID;
            yield return Truth.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulGood.ID;
            yield return NeutralGood.ID;
            yield return ChaoticGood.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("49691e06-ea52-48a1-bc0f-76a56364f2b6"),
                SourceId = CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
