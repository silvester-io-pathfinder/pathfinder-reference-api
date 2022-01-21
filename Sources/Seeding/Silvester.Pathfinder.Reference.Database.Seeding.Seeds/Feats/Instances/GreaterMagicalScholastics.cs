using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterMagicalScholastics : Template
    {
        public static readonly Guid ID = Guid.Parse("57dabe38-f68f-4bbe-a46d-02ab11aa4966");

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
            yield return new TextBlock { Id = Guid.Parse("6b66104a-1944-4f21-b110-e6abafc03c51"), Type = TextBlockType.Text, Text = "You broaden your magical studies, allowing you to find the right path, detect objects, and conceal those objects from unscrupulous rivals. You can cast (spell: augury), (spell: locate), and (spell: nondetection) as occult innate spells, each once per day. You can cast this (spell: nondetection) spell only on an object, and it is automatically heightened to the same spell level as your cantrips from (feat: Magical Scholastics)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0ccd4fc5-ba4d-4525-b9b2-30e933366ff6"), Feats.Instances.ArchaeologistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4df19ddc-69d2-4f4e-a4d3-aacb77441907"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
