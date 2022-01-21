using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhaseOut : Template
    {
        public static readonly Guid ID = Guid.Parse("1dcd7ce4-48fa-4389-b466-43f455c8bdda");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Phase Out",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("82d2d590-90c9-48ea-8167-3f20c968560f"), Type = TextBlockType.Text, Text = "Your eidolon phases out of reality slightly, gaining resistance to all damage (except force and negative) equal to half your level. It's not (trait: incorporeal), but it can't use (action: Strikes | Strike) or actions that require a fully physical form, such as (action: Grapple), (action: Shove), or (action: Trip). Your eidolon can return to its normal form with a single action, which has the (trait: concentrate) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("4fbbcb11-13c2-44a9-b8f2-315e48a42cf8"), "Your eidolon is a phantom.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ddfba091-2210-4069-b8c6-3482602a80a1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}