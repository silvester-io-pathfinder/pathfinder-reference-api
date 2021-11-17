using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlackPowderEmbodiment : Template
    {
        public static readonly Guid ID = Guid.Parse("f7aac812-efd5-4e29-9e06-a44901bc3ea8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Black Powder Embodiment",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("10179f36-2730-4a16-81e7-75cfa3dc2eb1"), Type = TextBlockType.Text, Text = "You infuse your entire being into a single shot, merging your body into the blast and enabling you to travel the same path as your bolt or bullet. (action: Strike) a creature with the required weapon. On a success, if the target was within 120 feet, you and all your gear are teleported to an open space of your choice within 10 feet of the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f69dbfc7-7441-4f34-a2d6-b9b5ae8a0929"), Feats.Instances.SpellshotDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("2d8e2181-acb0-4c34-8d15-576db96c7fda"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf9d5e79-f414-42af-ab86-9ade6a9723a0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
