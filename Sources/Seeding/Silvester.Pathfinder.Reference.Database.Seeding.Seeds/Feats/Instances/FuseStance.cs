using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FuseStance : Template
    {
        public static readonly Guid ID = Guid.Parse("116e4de1-5ee3-45bd-992e-533d46c90b22");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Fuse Stance",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0ef7a939-79a7-443a-8de7-6f104c48d4d3"), Type = TextBlockType.Text, Text = $"You have combined two stances into a single stance all your own. When you take this feat, choose two stances you know and combine them into a single fused stance. Give your new fused stance a unique name. When you enter your fused stance, you gain all the effects of both stances, including the requirements and restrictions." };
            yield return new TextBlock { Id = Guid.Parse("aa98bce4-80b5-42e9-a572-aa9b01fbcacb"), Type = TextBlockType.Text, Text = $"You can't fuse stances with fundamentally incompatible requirements or restrictions (such as {ToMarkdownLink<Models.Entities.Feat>("Ironblood Stance", Feats.Instances.IronbloodStance.ID)} and {ToMarkdownLink<Models.Entities.Feat>("Crane Stance", Feats.Instances.CraneStance.ID)}, which both require using only one type of {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)})." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificStanceAmount(Guid.Parse("0fc49299-82da-4853-87b5-f0445106c60d"), Comparator.GreaterThanOrEqualTo, 2);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ecc948e2-ce26-4eae-8531-58562a11d055"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
