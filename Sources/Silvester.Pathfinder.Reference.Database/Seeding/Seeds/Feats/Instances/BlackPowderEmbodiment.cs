using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BlackPowderEmbodiment : Template
    {
        public static readonly Guid ID = Guid.Parse("5f433cf7-e6e8-4250-835a-71db2331cb45");

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
            yield return new TextBlock { Id = Guid.Parse("27b42046-6050-4eaf-a88e-e48928891a54"), Type = TextBlockType.Text, Text = "You infuse your entire being into a single shot, merging your body into the blast and enabling you to travel the same path as your bolt or bullet. (action: Strike) a creature with the required weapon. On a success, if the target was within 120 feet, you and all your gear are teleported to an open space of your choice within 10 feet of the target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f1058018-889e-4c48-97eb-c0b63d1444ec"), Feats.Instances.SpellshotDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("45dde253-b2d6-4bea-9cd8-2f71711a0e18"), Proficiencies.Instances.Master.ID, Skills.Instances.Arcana.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c94a6346-72d5-45c9-a7b3-76d7c9f3a63e"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
