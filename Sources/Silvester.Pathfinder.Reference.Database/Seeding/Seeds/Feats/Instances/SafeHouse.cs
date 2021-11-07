using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SafeHouse : Template
    {
        public static readonly Guid ID = Guid.Parse("e7c57c60-770c-4455-8a65-3c54bb2a6a92");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Safe House",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bbcee98a-8bd7-41fd-bc5d-3cf5879f84d1"), Type = TextBlockType.Text, Text = "You establish a safe house – a secure space in which to hide your secrets from the outside world. This safe house is roughly the size of a 10-foot cube. It’s in a location you have access to, and it can be part of a larger building or structure, like a hidden room or an underground cave. The safe house protects objects and people inside it from magical detection. This has the effects of (spell: nondetection), using your Deception modifier for the counteract DC and half your level rounded up for the counteract level. Setting up or moving your safe house takes a week of downtime. The size of the safe house expands to four 10-foot cubes if you’re an expert in Deception, eight cubes if you’re a master, and 16 cubes if you’re legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c4ab3101-bfc6-467f-8371-9b4dac29b32b"), Feats.Instances.VigilanteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b5b9aba6-a7c1-48f1-89b8-fcae65e28a51"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
