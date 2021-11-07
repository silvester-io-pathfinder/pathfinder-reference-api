using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DefianceUntoDeath : Template
    {
        public static readonly Guid ID = Guid.Parse("c58a6650-24dd-43de-b5cd-5beb420ed550");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defiance Unto Death",
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
            yield return new TextBlock { Id = Guid.Parse("e89d71e1-7402-4948-ac18-a913d0a255f6"), Type = TextBlockType.Text, Text = "~ Access: Spiresworn elf" };
            yield return new TextBlock { Id = Guid.Parse("d2eeb91f-af6e-464b-87bc-1e75a28e6088"), Type = TextBlockType.Text, Text = "You loathe the alghollthus and their mind magic, and you’ve been trained to be willing to die rather than give into mental manipulation. If you would start your turn confused, controlled, or fleeing due to a failed Will save, you can attempt a Will save against the same DC; on a success, you become paralyzed until your next turn, rather than act against your will." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3904b4d3-42ca-4002-83fb-18cdb90e562a"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
