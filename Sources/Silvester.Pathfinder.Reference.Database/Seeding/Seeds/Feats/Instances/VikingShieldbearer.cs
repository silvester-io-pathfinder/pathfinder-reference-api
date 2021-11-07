using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VikingShieldbearer : Template
    {
        public static readonly Guid ID = Guid.Parse("6b2caf86-9fd2-4cb6-8251-8d1d82c63acf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Viking Shieldbearer",
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
            yield return new TextBlock { Id = Guid.Parse("5ca3268a-1b19-4283-bb87-e7ce0da52154"), Type = TextBlockType.Text, Text = "~ Access: Ulfen ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("20ec1074-8e9b-47f4-bca7-22d3186ebab3"), Type = TextBlockType.Text, Text = "You trained with shields and weapons as soon as you were old enough to hold them, eager to win honor and glory for yourself. You gain the (feat: Shield Block) reaction and are trained in your choice of the battle axe or longsword." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5dffbcc2-27af-434a-9460-5fbc116e6ded"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
