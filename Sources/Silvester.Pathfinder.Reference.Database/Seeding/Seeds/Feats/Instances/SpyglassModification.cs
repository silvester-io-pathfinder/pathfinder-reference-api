using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpyglassModification : Template
    {
        public static readonly Guid ID = Guid.Parse("6d8d35de-35ad-4880-a79b-a9015c00367f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Spyglass Modification",
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
            yield return new TextBlock { Id = Guid.Parse("98bc385f-73eb-4dd4-89a0-64578a6f64a7"), Type = TextBlockType.Text, Text = "Your enhanced visual gear includes a regulating scope and reflectors, combined in an ingenuous setup that allows you to see around corners within the area of your overwatch field. This permits your overwatch field to extend around a single corner or turn and allows you to see around that corner as well. This ability doesn’t let you see through walls or other barriers. You can’t use it to see around a second or further corner, and it doesn’t allow you to make ranged attacks or perform other actions that require line of effect with your target." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5a9abeb2-1e1a-452f-bf4b-c2ec3d4072b9"), Feats.Instances.OverwatchDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c239af7f-4a64-405c-a107-98a9aafea097"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
