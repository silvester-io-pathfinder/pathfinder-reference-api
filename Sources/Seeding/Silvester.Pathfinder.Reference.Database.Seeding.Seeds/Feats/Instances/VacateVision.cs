using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VacateVision : Template
    {
        public static readonly Guid ID = Guid.Parse("aff3d9d1-0df3-464a-8c0f-6fc2e59a99f8");

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
            yield return new TextBlock { Id = Guid.Parse("248b56c9-1237-4232-b4f8-9cd7c178df62"), Type = TextBlockType.Text, Text = $"You cause your eyes to liquefy and run out of your eye sockets, leaving them empty. You get a success on the save against the triggering effect, but you are blinded for the duration the effect would have had on a failure. At that time, your eyes regrow and your normal vision returns." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4831965b-1617-4165-a7d3-701f76f68876"), Feats.Instances.OozemorphDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c42100fc-5869-4e75-a135-dc4aa800873e"),
                SourceId = Sources.Instances.TheSlithering.ID,
                Page = -1
            };
        }
    }
}
