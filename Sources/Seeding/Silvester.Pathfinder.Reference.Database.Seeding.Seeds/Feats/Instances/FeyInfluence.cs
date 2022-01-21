using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeyInfluence : Template
    {
        public static readonly Guid ID = Guid.Parse("d2a338c0-5e06-45a5-a4d1-907f11e5a48e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fey Influence",
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
            yield return new TextBlock { Id = Guid.Parse("5df2fdba-8c27-4103-93ce-4bd5dd82f69a"), Type = TextBlockType.Text, Text = "You have been exposed to powerful fey magic. You become trained in primal DCs and spell attack rolls. You gain the (trait: fey) trait and one of the following features which grant an innate primal spell that can be used once per day." };
            yield return new TextBlock { Id = Guid.Parse("28bab903-8ecd-4df3-a214-67bd6111f0b3"), Type = TextBlockType.Enumeration, Text = " Anteater: You can launch your tongue forward as a deadly attack, gaining (spell: grim tendrils)." };
            yield return new TextBlock { Id = Guid.Parse("51fd7366-9869-41ae-a810-3241b847be3a"), Type = TextBlockType.Enumeration, Text = " Dryad: Your body is covered in elegant vines, granting you (spell: summon plant or fungus)." };
            yield return new TextBlock { Id = Guid.Parse("81f3fe7b-a68f-474f-84a4-4500a89bb50c"), Type = TextBlockType.Enumeration, Text = " Gremlin: You have long, bat-like ears and gain (spell: bane)." };
            yield return new TextBlock { Id = Guid.Parse("7b2159fc-e3d2-440d-8122-64d13f6e00a9"), Type = TextBlockType.Enumeration, Text = " Monarch: You have vestigial, insectile features and gain (spell: spider sting)." };
            yield return new TextBlock { Id = Guid.Parse("9e0db388-ae7a-4da5-81e7-df0086e8e1e5"), Type = TextBlockType.Text, Text = "This feat gains the trait appropriate for your ancestry (human for human, goblin for goblin, etc)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7a354f11-f791-41e2-a356-aa72a0fe930b"),
                SourceId = Sources.Instances.PathfinderSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
