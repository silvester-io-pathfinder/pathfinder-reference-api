using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ActionCallGun : Template
    {
        public static readonly Guid ID = Guid.Parse("94681f9b-3710-4c9c-a6b3-eef8070c113d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Action - Call Gun",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("36bd0284-eaf7-44ca-bacd-03317012e834"), Type = TextBlockType.Text, Text = $"You hold aloft a free hand and call the firearm or crossbow you chose during your daily preparations into your hand. As long as the weapon you chose is on the same plane, it appears in your hand." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("41963667-7107-4ce5-a0d8-e9b29548f9a9"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
