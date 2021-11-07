using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VacateVision : Template
    {
        public static readonly Guid ID = Guid.Parse("be9f7a44-8189-4a8c-97f7-6a60a7c69c12");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Vacate Vision",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail (but don't critically fail) a saving throw against an effect with the visual trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6307c308-f8fe-40a9-a380-616d9356bf64"), Type = TextBlockType.Text, Text = "You cause your eyes to liquefy and run out of your eye sockets, leaving them empty. You get a success on the save against the triggering effect, but you are blinded for the duration the effect would have had on a failure. At that time, your eyes regrow and your normal vision returns." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cddad995-3961-4869-bfa7-3b14120a1259"), Feats.Instances.OozemorphDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5a24c0fd-4792-4d83-ad38-40df78f93e7f"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
