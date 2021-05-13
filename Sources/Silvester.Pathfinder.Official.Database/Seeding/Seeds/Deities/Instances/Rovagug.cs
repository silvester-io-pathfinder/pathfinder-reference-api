using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Alignments.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DeityCategories.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.DivineFonts.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Domains.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Skills.Instances;
using Silvester.Pathfinder.Official.Database.Seeding.Seeds.Sources.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Deities.Instances
{
    public class Rovagug : Template
    {
        public static readonly Guid ID = Guid.Parse("1290de63-f6c8-4319-b76f-361db860eb0e");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = ChaoticEvil.ID,
                Name = "Rovagug", 
                Description = "The Rough Beast is the god of destruction, disaster, and wrath. He was long ago imprisoned within Golarion’s core at the hands of many other deities working in concert, and seeks to one day break free and wreak havoc upon the world.",
                Edicts = "Destroy all things, free Rovagug from his prison.",
                Anathema = "Create something new, let material ties restrain you, torture a victim or otherwise delay its destruction.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Harm.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Air.ID;
            yield return Destruction.ID;
            yield return Earth.ID;
            yield return Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return NeutralEvil.ID;
            yield return ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8a552441-1cd8-4431-8ef2-ea69421e7d83"),
                SourceId = CoreRulebook.ID,
                Page = 439
            };
        }
    }
}
