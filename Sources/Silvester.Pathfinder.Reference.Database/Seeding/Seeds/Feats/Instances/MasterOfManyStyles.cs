using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MasterOfManyStyles : Template
    {
        public static readonly Guid ID = Guid.Parse("03f007ce-fedc-4afa-8aba-1b3e1ea6c4dd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Master of Many Styles",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("02b9b30f-00d4-4a15-9b96-0e9289744e5b"), Type = TextBlockType.Text, Text = "You move between stances in an unceasing dance. You use an action with the (trait: stance) trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("9b94bb08-a321-48f5-88c0-84116d76687a"), Feats.Instances.StanceSavant.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1edd79a0-5673-484e-b161-b71d8044ef9f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
