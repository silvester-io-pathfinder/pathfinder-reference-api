using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeshSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("1dc985b3-02b4-4547-b040-a3be3f5ab42c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pesh Skin",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("665f9091-9b14-4d9c-ac85-a2a252d99582"), Type = TextBlockType.Text, Text = "~ Access: elite member of the Poison Maker's Guild" };
            yield return new TextBlock { Id = Guid.Parse("8ebe3a98-1032-4d9d-a932-893cd1f04a49"), Type = TextBlockType.Text, Text = "Your plant form sprouts hundreds of spines, and your blood causes mild hallucinations in creatures exposed to it. Each time a creature touches you, hits you with an unarmed attack, or hits you with a melee weapon attack while adjacent to you, that creature takes 1d6 piercing damage." };
            yield return new TextBlock { Id = Guid.Parse("bf43fdc2-2f4b-466d-bc66-e4e089791800"), Type = TextBlockType.Text, Text = "Increase the damage to 2d6 if the (trait: polymorph) spell is 8th level or higher, or to 3d6 if it's 10th level." };
            yield return new TextBlock { Id = Guid.Parse("6a99c2f9-a891-4076-be49-bfc6d69ed90f"), Type = TextBlockType.Text, Text = "When an adjacent creature damages you with piercing or slashing damage, it must succeed at a Fortitude save against your class DC or become stupefied 1 (or stupefied 2 on a critical failure) until the end of its next turn." };
            yield return new TextBlock { Id = Guid.Parse("51c49a61-152a-4dc8-9c12-493f3c1165d3"), Type = TextBlockType.Text, Text = "These benefits last until you're no longer polymorphed into a plant." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc00a53e-1527-48a3-86b3-37fc4b4b1a25"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
