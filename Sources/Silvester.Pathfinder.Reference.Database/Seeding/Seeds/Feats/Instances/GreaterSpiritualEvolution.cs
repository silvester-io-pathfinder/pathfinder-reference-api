using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GreaterSpiritualEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("edc24ac6-c7d5-49fc-8c41-7ededbf0a72a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Greater Spiritual Evolution",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5d1dc12d-bf4c-48c9-bbfb-982788cd0c3c"), Type = TextBlockType.Text, Text = "Your magical blood is rich with spiritual essence, and this infusion within you allows your spells to be fully effective against incorporeal creatures, spirits, and creatures on the Ethereal Plane. Your spells have the effects of a ghost touch property rune. They can target or affect a creature projecting its consciousness (such as via (spell: project image)) or possessing another creature, even if its body is elsewhere, though you must know about the possession or projection and choose to do so. Your spells can affect creatures on the Ethereal Plane, though this doesn’t grant you any particular ability to locate them." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("1894a6ba-e65e-4c6c-850f-c474340d3bbe"), or => 
            {
                or.HaveSpecificFeat(Guid.Parse("21c5b0ef-cd24-4aac-b3a8-4a5d227bf02c"), Feats.Instances.DivineEvolution.ID);
                or.HaveSpecificFeat(Guid.Parse("6bf05b17-a477-4772-8578-7e8602b1402b"), Feats.Instances.OccultEvolution.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("13dd20c7-d601-4d30-929d-ea49f9e777f2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
