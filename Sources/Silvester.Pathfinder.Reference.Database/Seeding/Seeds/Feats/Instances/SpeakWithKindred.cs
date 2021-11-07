using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SpeakWithKindred : Template
    {
        public static readonly Guid ID = Guid.Parse("34c5428b-1e48-476d-ab5d-58ea8e8b3763");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Speak With Kindred",
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
            yield return new TextBlock { Id = Guid.Parse("7a87404e-1206-4cad-b90e-4638f12917ae"), Type = TextBlockType.Text, Text = "You have a connection with creatures that share your physiology." };
            yield return new TextBlock { Id = Guid.Parse("f5ce94a4-0da4-45ff-abc3-52788fdb1828"), Type = TextBlockType.Text, Text = "You can ask questions of, receive answers from, and use the Diplomacy skill with plants or fungi that match your leshy heritage. Generally, fungus leshies can speak to mushrooms and fungi; gourd leshies can speak to gourds, melons, and similar fruiting plants; leaf leshies can speak with deciduous trees; and vine leshies can speak with vines and climbing plants. The GM determines which plants or fungi count for this ability." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8c8e7c47-380c-4f90-9ff8-9d24c253b4a1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
