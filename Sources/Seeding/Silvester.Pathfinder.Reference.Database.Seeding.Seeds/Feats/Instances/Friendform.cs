using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Friendform : Template
    {
        public static readonly Guid ID = Guid.Parse("da97adbc-833a-4c01-a279-449e5442ae26");

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
            yield return new TextBlock { Id = Guid.Parse("dc0890f8-8b20-4340-a2a9-10cf8b366671"), Type = TextBlockType.Text, Text = $"The shared bond between you and your allies allows you to act on their behalf. During your daily preparations, you can perform a simple ritual with up to five willing Small or Medium humanoids, where participants exchange minor tokens of personal significance. As long as you hold onto a participant's token, you can assume their form with your {ToMarkdownLink<Models.Entities.Feat>("Change Shape", Feats.Instances.ChangeShapeAnadi.ID)} ability, gaining a +4 status bonus to Deception checks to pass as that person and adding your level to the check even if you're untrained. You lose access to a participant's form if they're not carrying your token or if you use the ritual again." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b3520fca-fb7a-4d7b-8bf3-602f14ab1945"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
