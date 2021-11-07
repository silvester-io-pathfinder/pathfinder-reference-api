using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PhaseOut : Template
    {
        public static readonly Guid ID = Guid.Parse("1af8534c-eb57-4883-83a9-6c9b7fbb01ab");

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
            yield return new TextBlock { Id = Guid.Parse("182a7251-3fcd-4b08-9bed-8db333e7656b"), Type = TextBlockType.Text, Text = "Your eidolon phases out of reality slightly, gaining resistance to all damage (except force and negative) equal to half your level. It’s not (trait: incorporeal), but it can’t use (action: Strikes | Strike) or actions that require a fully physical form, such as (action: Grapple), (action: Shove), or (action: Trip). Your eidolon can return to its normal form with a single action, which has the (trait: concentrate) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("2fd15de4-15a9-49fb-8e95-4c6779e321df"), "Your eidolon is a phantom.");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f255a872-aca9-46d8-b38e-6c7fc47ad747"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
