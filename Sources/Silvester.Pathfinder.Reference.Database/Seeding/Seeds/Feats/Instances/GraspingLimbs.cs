using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GraspingLimbs : Template
    {
        public static readonly Guid ID = Guid.Parse("2a0f94a7-6cf8-4372-bbb6-afcd4fd4d82f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grasping Limbs",
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
            yield return new TextBlock { Id = Guid.Parse("7b57d0c3-b9af-467e-8844-c30a7faba8ee"), Type = TextBlockType.Text, Text = "Your eidolon grabs enemies. Choose one of the eidolon’s unarmed attacks with the (trait: grapple) trait. It gains the Grab action (Bestiary pg. 343) on that unarmed attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5dc9995d-e0ad-46c8-818d-dd90a608162e"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
