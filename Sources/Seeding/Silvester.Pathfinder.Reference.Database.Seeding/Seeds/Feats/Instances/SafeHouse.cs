using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SafeHouse : Template
    {
        public static readonly Guid ID = Guid.Parse("645dfe6c-1feb-4796-b04f-c3493d83dfc0");

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
            yield return new TextBlock { Id = Guid.Parse("3df028d8-93af-48c0-9102-9f6902375d1c"), Type = TextBlockType.Text, Text = "You establish a safe house – a secure space in which to hide your secrets from the outside world. This safe house is roughly the size of a 10-foot cube. It’s in a location you have access to, and it can be part of a larger building or structure, like a hidden room or an underground cave. The safe house protects objects and people inside it from magical detection. This has the effects of (spell: nondetection), using your Deception modifier for the counteract DC and half your level rounded up for the counteract level. Setting up or moving your safe house takes a week of downtime. The size of the safe house expands to four 10-foot cubes if you’re an expert in Deception, eight cubes if you’re a master, and 16 cubes if you’re legendary." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("32a0b54c-f863-4601-8573-59440275bb29"), Feats.Instances.VigilanteDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("761c8637-d35d-4c84-b91c-b91a59ff93ee"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
