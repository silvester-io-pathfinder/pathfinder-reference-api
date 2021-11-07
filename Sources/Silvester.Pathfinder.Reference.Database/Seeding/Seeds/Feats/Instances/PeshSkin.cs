using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PeshSkin : Template
    {
        public static readonly Guid ID = Guid.Parse("74457881-ad99-4f28-aa94-91a3832dd158");

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
            yield return new TextBlock { Id = Guid.Parse("a68ae258-7b77-4727-99fc-fbf53f5d8f83"), Type = TextBlockType.Text, Text = "~ Access: elite member of the Poison Maker’s Guild" };
            yield return new TextBlock { Id = Guid.Parse("b0747016-7032-4148-a821-14393dca1a1a"), Type = TextBlockType.Text, Text = "Your plant form sprouts hundreds of spines, and your blood causes mild hallucinations in creatures exposed to it. Each time a creature touches you, hits you with an unarmed attack, or hits you with a melee weapon attack while adjacent to you, that creature takes 1d6 piercing damage." };
            yield return new TextBlock { Id = Guid.Parse("2a3d1ae3-9cc8-4401-97e2-6df5f1cc01d0"), Type = TextBlockType.Text, Text = "Increase the damage to 2d6 if the (trait: polymorph) spell is 8th level or higher, or to 3d6 if it’s 10th level." };
            yield return new TextBlock { Id = Guid.Parse("37e5ff76-85be-4942-abb8-45d51c35bab3"), Type = TextBlockType.Text, Text = "When an adjacent creature damages you with piercing or slashing damage, it must succeed at a Fortitude save against your class DC or become stupefied 1 (or stupefied 2 on a critical failure) until the end of its next turn." };
            yield return new TextBlock { Id = Guid.Parse("95fa2228-4b67-446b-9753-e1929ce33f74"), Type = TextBlockType.Text, Text = "These benefits last until you’re no longer polymorphed into a plant." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64e04e9c-d956-4b2d-bd81-251c1f948e69"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
