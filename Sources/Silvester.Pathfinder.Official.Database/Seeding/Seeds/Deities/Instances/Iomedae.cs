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
    public class Iomedae : AbstractDeityTemplate
    {
        public static readonly Guid ID = Guid.Parse("8bd542ba-e5e0-4c86-80eb-15cd07d594dd");

        protected override Deity GetDeity()
        {
            return new Deity 
            {
                Id = ID,
                CategoryId = GodsOfTheInnerSea.ID, 
                AlignmentId = LawfulGood.ID,
                Name = "Iomedae", 
                Description = "Iomedae is goddess of honor, justice, rulership, and valor, and she is called the Inheritor because she inherited her mantle when the god of humanity perished. Prior to her ascension, Iomedae walked the planet as a mortal. Many paladins follow her faith.",
                Edicts = "Be temperate, fight for justice and honor, hold valor in your heart.",
                Anathema = "Abandon a companion in need, dishonor yourself, refuse a challenge from an equal.",
            };
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return Heal.ID;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Confidence.ID;
            yield return Might.ID;
            yield return Truth.ID;
            yield return Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return LawfulGood.ID;
            yield return NeutralGood.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("03a680cd-2ff4-464d-be59-8a960ae9e8e9"),
                SourceId = CoreRulebook.ID,
                Page = 438
            };
        }
    }
}
