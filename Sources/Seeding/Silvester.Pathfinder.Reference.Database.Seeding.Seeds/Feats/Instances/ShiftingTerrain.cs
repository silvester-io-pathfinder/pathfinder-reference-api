using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShiftingTerrain : Template
    {
        public static readonly Guid ID = Guid.Parse("85c0bdc0-cc83-408d-8e57-91eb591f2235");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shifting Terrain",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3990b1e2-9f8f-4552-9dc4-a59bebdb0fe3"), Type = TextBlockType.Text, Text = $"You slam your fist into the ground or twirl your arms about to cause the terrain around you to shift and ripple, potentially throwing others off balance. Each creature within your area of difficult terrain from {ToMarkdownLink<Models.Entities.Feat>("Rough Terrain Stance", Feats.Instances.RoughTerrainStance.ID)} must attempt a Reflex saving throw against your spell DC with the following effects. After you use this action, you can't use it again for 1d4 rounds." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c885eb66-51e7-4743-934d-e76e8bc5aaba"), Feats.Instances.RoughTerrainStance.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("9d479d5e-3206-4017-a0ed-9f8f05f20799"), Proficiencies.Instances.Master.ID, Skills.Instances.Nature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("fe5081d0-0ced-4bef-b73d-3d0436f39e79"),
                CriticalSuccess = "The creature is unaffected.",
                Success = "The creature is clumsy 1 for 1 round.",
                Failure = "The creature is clumsy 2 for 1 round.",
                CriticalFailure = "The creature is clumsy 2 for 1 round and falls prone.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("55bfdb70-5a8c-4d52-a3ce-80bad5df7a43"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
