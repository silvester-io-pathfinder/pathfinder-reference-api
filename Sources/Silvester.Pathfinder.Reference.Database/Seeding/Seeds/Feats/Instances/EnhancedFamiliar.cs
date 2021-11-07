using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnhancedFamiliar : Template
    {
        public static readonly Guid ID = Guid.Parse("7c948e19-6a91-4954-94ef-d3fa2bcbaa89");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Enhanced Familiar",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("906b01fb-e585-4f7f-9adc-e06bc6489bfd"), Type = TextBlockType.Text, Text = "By applying the best of multiple traditions of magic, you’ve found a more efficient way for your familiar to store its energy. You can select four familiar or master abilities each day, instead of two." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyFamiliar(Guid.Parse("34beb49e-51c9-4e9c-b8c1-64eac3254503"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cbb3534a-fb0f-48b1-9a4a-2dfee367dbc9"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
