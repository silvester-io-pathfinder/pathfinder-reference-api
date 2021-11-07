using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GhostHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("97c30466-41b2-486b-830d-12745715e3ca");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Hunter",
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
            yield return new TextBlock { Id = Guid.Parse("4d2b8633-4d5a-4fae-968d-4b520cfaed43"), Type = TextBlockType.Text, Text = "Your connection to the Boneyard ensures that your blows strike true against spectral beings. Your weapon and unarmed attack (action: Strikes | Strike) against incorporeal creatures become magical. If they are already magical, they instead gain the effects of a (item: ghost touch | Ghost Touch Runestone) property rune." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8bb411b7-1fa6-40e3-9e7e-1905b1590f6c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
