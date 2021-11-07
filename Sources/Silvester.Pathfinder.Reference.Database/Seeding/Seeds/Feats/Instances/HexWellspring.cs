using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HexWellspring : Template
    {
        public static readonly Guid ID = Guid.Parse("898fa8ec-7758-4c1a-bf72-0098aca8561b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hex Wellspring",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5a1b4f70-a28b-4957-81b0-9df2fdc9a148"), Type = TextBlockType.Text, Text = "Focus flows from your patron each time you commune with your familiar. You can recover 3 Focus Points when you (action: Refocus) instead of 1 if you have spent at least 3 Focus Points since the last time you (action: Refocused | Refocus)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4e096464-a65b-4599-bd8a-300b0635237f"), Feats.Instances.HexFocus.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ce6ae5b7-20bb-4d18-a027-6a4c5e5bb069"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
