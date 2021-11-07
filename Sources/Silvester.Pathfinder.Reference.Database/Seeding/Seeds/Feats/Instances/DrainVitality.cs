using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrainVitality : Template
    {
        public static readonly Guid ID = Guid.Parse("bbe0a7c6-6c60-4dcc-bd0a-ab7d03909bef");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Drain Vitality",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per minute"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("21ffdb3f-0032-4cf1-af29-654053496b48"), Type = TextBlockType.Text, Text = "You draw out the bestial magic energy within your bonded beast gun to fortify yourself, purge ongoing harm, and bolster your life force with a sheath of swirling life essence. You gain temporary Hit Points equal to your level and attempt a flat check against any ongoing persistent damage, using the DC appropriate for particularly effective assistance. Using this ability depletes the magic within your bonded beast gun, preventing you from using any of its activated abilities until the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a57ebca6-1ae1-4a3d-b33c-6958708f8de3"), Feats.Instances.BeastGunnerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bca94833-4e68-499e-8809-c7d9e2953657"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
