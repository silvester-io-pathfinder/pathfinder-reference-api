using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Delver : Template
    {
        public static readonly Guid ID = Guid.Parse("377e13ba-06a0-45d2-bd74-6adffaa46781");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Delver",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd40dec3-0acd-43ca-b0fa-91a45ca87144"), Type = TextBlockType.Text, Text = "Subterranean life taught you to swim through the ground like water. You gain a burrow Speed of 10 feet through loose soil or dirt." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afd8433c-1e6f-400f-a5fb-3e2b99fb9df9"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
