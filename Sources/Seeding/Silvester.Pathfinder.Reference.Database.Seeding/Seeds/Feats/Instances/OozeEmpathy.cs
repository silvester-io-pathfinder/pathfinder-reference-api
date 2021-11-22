using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OozeEmpathy : Template
    {
        public static readonly Guid ID = Guid.Parse("a99ab46c-997a-4df1-bb78-0ebd3a851fbf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ooze Empathy",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a30713b-0ea5-45bf-a4f1-f8c87b36cbe7"), Type = TextBlockType.Text, Text = "You can connect with oozes (and other amorphous aberrations, at the GM's discretion) on a rudimentary level. You can use Diplomacy to (action: Make an Impression) on oozes and to make very simple (action: Requests | Request) of them. In most instances, oozes will give you time to make your case." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c7044bbd-e241-48a3-ab6e-951d5159fc57"), Feats.Instances.OozemorphDedication.ID);
            builder.Manual(Guid.Parse("a52469fb-44cd-4702-9c5a-5a4a56095f99"), "At least two other class feats from the oozemorph archetype.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("59a337e2-ea72-4de1-b33a-dab5e5cdde36"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
