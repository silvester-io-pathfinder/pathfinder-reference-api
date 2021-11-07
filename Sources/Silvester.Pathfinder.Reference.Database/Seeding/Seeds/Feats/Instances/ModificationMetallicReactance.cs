using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationMetallicReactance : Template
    {
        public static readonly Guid ID = Guid.Parse("666e8e1b-0e14-4307-afde-9f3be5f993ff");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Metallic Reactance",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3049d6a0-dd0a-4b6c-824c-e4d38040c006"), Type = TextBlockType.Text, Text = "The metals in your armor are carefully alloyed to ground electricity and protect from acidic chemical reactions. You gain resistance equal to 3 + half your level to acid and electricity damage. When under the effects of (feat: Overdrive), the resistance increases by 2." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1d0ebfae-a4e8-485b-9357-7fda2c98f535"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
