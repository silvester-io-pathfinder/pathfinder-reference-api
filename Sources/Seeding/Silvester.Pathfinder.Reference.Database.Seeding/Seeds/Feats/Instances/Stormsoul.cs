using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Stormsoul : Template
    {
        public static readonly Guid ID = Guid.Parse("f162673f-de50-4e7e-8a19-355a9fbe1da0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Stormsoul",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1bcc99c3-d0f7-4794-9e10-df913e21edcb"), Type = TextBlockType.Text, Text = "Your elemental ancestor's influence manifests in you as tumultuous, thundering storms, with dark clouds and bolts of lightning. You gain resistance to electricity equal to half your level (minimum 1)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3da838bb-6b48-4fd7-b8b5-77e1ce0d10b5"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
