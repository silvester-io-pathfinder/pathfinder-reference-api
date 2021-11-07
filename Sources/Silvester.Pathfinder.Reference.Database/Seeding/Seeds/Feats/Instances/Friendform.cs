using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Friendform : Template
    {
        public static readonly Guid ID = Guid.Parse("1a608561-7fa4-414f-b3eb-a0a0d2ab53c4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Friendform",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6ec9c1db-6f06-4cfe-b843-bc11e11efc9c"), Type = TextBlockType.Text, Text = "The shared bond between you and your allies allows you to act on their behalf. During your daily preparations, you can perform a simple ritual with up to five willing Small or Medium humanoids, where participants exchange minor tokens of personal significance. As long as you hold onto a participant’s token, you can assume their form with your (action: Change Shape | Change Shape - Anadi) ability, gaining a +4 status bonus to Deception checks to pass as that person and adding your level to the check even if you’re untrained. You lose access to a participant’s form if they’re not carrying your token or if you use the ritual again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5f596781-1d6e-4347-8e8b-3ce7b388a7a6"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
