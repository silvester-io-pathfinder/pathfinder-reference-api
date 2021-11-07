using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterMagicalScholastics : Template
    {
        public static readonly Guid ID = Guid.Parse("a8ca3398-ffaf-4dea-ac06-ca207b8e6b65");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Magical Scholastics",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a325a59b-5cd6-4cf2-94ab-11f2a37e9b5b"), Type = TextBlockType.Text, Text = "You broaden your magical studies, allowing you to find the right path, detect objects, and conceal those objects from unscrupulous rivals. You can cast (spell: augury), (spell: locate), and (spell: nondetection) as occult innate spells, each once per day. You can cast this (spell: nondetection) spell only on an object, and it is automatically heightened to the same spell level as your cantrips from (feat: Magical Scholastics)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("63f1c349-0224-4ee9-abac-9c1900f7039a"), Feats.Instances.ArchaelogistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d4026b99-bab1-4d1f-aa0d-88cc238062f9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
