using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TillersAid : Template
    {
        public static readonly Guid ID = Guid.Parse("70e688ee-8044-4071-98f0-91c12381b430");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Tiller's Aid",
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
            yield return new TextBlock { Id = Guid.Parse("f4d02f39-22c9-4c19-97fc-cd2804f64cf6"), Type = TextBlockType.Text, Text = "You can use the (action: Aid) reaction to help a member of your crop even if you haven’t prepared to do so." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("698e9db7-626e-4383-862e-f1974bcb2e3b"), Feats.Instances.BellflowerTillerDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("53c22146-4e16-4503-b4ee-f668351ed0bb"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
