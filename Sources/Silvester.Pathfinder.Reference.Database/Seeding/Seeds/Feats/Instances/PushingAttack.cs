using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PushingAttack : Template
    {
        public static readonly Guid ID = Guid.Parse("0f6fc54e-5e1b-43bf-a55e-499e766ff804");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pushing Attack",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("39cbf880-d335-4e58-b982-1b676913a9b6"), Type = TextBlockType.Text, Text = "Your eidolon has an attack that pushes away enemies. Choose one of the eidolon’s unarmed attacks with the (trait: shove) trait. It gains the Push action (Bestiary pg. 343) for that attack." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("04384191-934b-471f-acec-ebea2078fe38"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
